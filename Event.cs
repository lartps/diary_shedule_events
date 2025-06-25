using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using static weekly_planer.Program;

namespace weekly_planer
{
    public class MyEvent
    {
        private static int nameCounter_ = 1;

        public string Name { get; set; } = "Cправа " + nameCounter_;
        public string Description { get; set; } = "";
        public string Details { get; set; } = "";
        public string Location { get; set; } = "";
        public int Day { get; set; }
        public int startHour { get; set; }
        public int startMin { get;set; }
        public int endHour { get; set; }
        public int endMin { get; set; }
        public int Duration { get; set; }
        public bool IsOverlapped = false; // одна накладка на одну подію
        public Panel EventOnForm { get; set; } = null; // прикріплення за івентом блоку для відображення на формі
        public bool IsOnDelayTable { get; set; } = false; // флаг для перевірки відображення на таблиці переносу Delay_table
        public bool IsOnOverlapsTable { get; set; } = false; // флаг для перевірки відображення в таблиці накладок Overlaps_table

        public MyEvent(int SetDay, int SetStartHour, int SetStartMin, int SetEndHour, int SetEndMin, string SetName = "", string SetDescr = "", string SetLoc = "", string SetDet = "")
        {
            // перевірка на ім'я лише з пробілів чи пусте
            SetName.Trim();
            string trimmed = SetName.Replace(" ", "") ?? "";
            if (SetName == "") ++nameCounter_; // замінюється на ім'я за замовчування
            else if (trimmed.All(char.IsDigit)) ++nameCounter_; // перевірка на символи які не є буквами чи цифрами
            else if (SetName.Length > 1 && trimmed.Length > 1 && (trimmed.All(c => char.IsLetterOrDigit(c) || c == ' '))) Name = SetName;
            else ++nameCounter_; // для нерозглянутих виключень

            Day = SetDay;
            startHour = SetStartHour;
            startMin = SetStartMin;

            endHour = SetEndHour;
            endMin = SetEndMin;

            SetDescr.Trim();
            SetLoc.Trim();
            SetDet.Trim();
            Description = SetDescr;
            Location = SetLoc;
            Details = SetDet;

            Duration = DurationOfEvent(this);

            if (GlobalData.v1.index.Count >= 1)
            {
                if (GlobalData.v1.IsReserved(this)) // якщо зарезервовано час або ім'я, то не можна створити 
                {
                    throw new ReservedTimeException("Це ім'я або час зарезервовані іншою подією");
                }
                foreach (var existingEvent in GlobalData.AllEvents)
                {
                    // перевіряються тільки події в той же день
                    if (existingEvent.Day == this.Day)
                    {
                        // використано метод isOverlayed для перевірки накладання
                        IsOverlapped = this.isOverlayed(existingEvent);
                        break;
                    }
                }
            }
            GlobalData.v1.Reserve(this);
            GlobalData.AllEvents.Add(this);
        }
        public int DurationOfEvent(MyEvent event1)
        {
            int duration = ((((event1.endHour - event1.startHour) * 60) - event1.startMin) + event1.endMin);
            if (duration < 30) throw new DurationException();
            return duration;
        }
        public int DurationOfEvent(int startHour, int endHour, int startMin, int endMin)
        {
            if (endHour == startHour && startMin != 0) return startMin - endMin;
            int duration = ((((endHour - startHour) * 60) - startMin) + endMin);
            if (duration < 30) throw new DurationException();
            return duration;
        }
        // видалити зі списку всіх івентів, очистити зарезервоване ім'я та час
        public void Delete(MyEvent event1)
        {
            GlobalData.v1.Delete(event1.Name);
            GlobalData.AllEvents.Remove(event1);
        }

        // перевірка що інший івент правильно перекриваеться з цим івентом
        public bool isOverlayed(MyEvent other)
        {
            if (other.IsOverlapped || this.IsOverlapped)
            {
                throw new EventsOverlapseException("У події не може бути більше однієї накладки");
            }
            if (other.Day == this.Day)
            {
                if (this.startHour > other.startHour)
                {
                    int DurationDiffFromStart = DurationOfEvent(this.startHour, other.startHour, this.startMin, other.startMin); // проверка что разница между началом этого ивента и началом другого минмум 30 минут
                    int OverlapsedDuration = DurationOfEvent(other.startHour, this.endHour, other.startMin, this.endMin); // проверка что перекрытие между этими ивентами минимум 30 минут
                    if (DurationDiffFromStart >= 30 && OverlapsedDuration >= 30) return true;
                    else if (DurationDiffFromStart < 30) throw new ReservedTimeException();
                    else if (OverlapsedDuration < 30) throw new EventsOverlapseException();
                }
                else if (this.startHour == other.startHour)
                {
                    throw new ReservedTimeException($"This time overlaps with another event's 30-minute reservation period. Event \"{this.Name}\" at {this.Day}.06 {this.startHour}:{this.startMin} overlaps with event at {other.Day}.06 {other.startHour}:{other.startMin}");
                }
                else if (this.startHour < other.startHour)
                {
                    int DurationDiffFromStart = DurationOfEvent(other.startHour, this.startHour, other.startMin, this.startMin); // проверка что разница между началом этого ивента и началом другого минмум 30 минут
                    int OverlapsedDuration = DurationOfEvent(this.startHour, other.endHour, this.startMin, other.endMin); // проверка что перекрытие между этими ивентами минимум 30 минут
                    if (DurationDiffFromStart >= 30 && OverlapsedDuration >= 30) return true;
                    else if (DurationDiffFromStart < 30) throw new ReservedTimeException();
                    else if (OverlapsedDuration < 30) throw new EventsOverlapseException();
                }
            }
            return false;
        }

        // змінити ім'я
        public void Rename(string NewName)
        {
            GlobalData.v1.Change(this);
            this.Name = NewName;
        }
        // змінити час
    }

    public class Validate
    {
        public Dictionary<string, string> index = new Dictionary<string, string>(); // ім'я - ключ, час - значення

        public void Reserve(MyEvent e1)
        {
            index[e1.Name] = $"{e1.Day} {e1.startHour}:{e1.startMin}";
        }

        public bool IsReserved(MyEvent e1)
        {
            if (index.ContainsKey(e1.Name))
            {
                throw new ReservedNameException();
            }

            // Перевіряємо всі дати які вже є
            foreach (var existingTime in index.Values)
            {
                var parts = existingTime.Split(' ');
                int existingDay = int.Parse(parts[0]);

                // Перевіряємо лише події що відбуваються в той же день
                if (existingDay == e1.Day)
                {
                    var timeParts = parts[1].Split(':');
                    int existingHour = int.Parse(timeParts[0]);
                    int existingMin = int.Parse(timeParts[1]);

                    // Перевіряємо, щоб новий час не попадав в 30-хвилинний резерв від початку події яка вже є
                    if (e1.startHour == existingHour && (existingMin + 30 < 60))
                    {
                        if (e1.startMin == existingMin || existingMin + 30 >= e1.startMin)
                            throw new ReservedTimeException($"This time overlaps with another event's 30-minute reservation period. Event \"{e1.Name}\" at {e1.Day}.06 {e1.startHour}:{e1.startMin} overlaps with event at {existingTime}");
                    }

                    // Перевіряємо випадок переходу через час
                    if (existingMin + 30 >= 59)
                    {
                        int nextMin = (existingMin + 30) % 60;

                        if ((e1.startHour == existingHour + 1 && e1.startMin <= nextMin))
                        {
                            throw new ReservedTimeException();
                        }
                    }
                }
            }
            return false;
        }

        public void Delete(string name)
        {
            index.Remove(name);
        }
        // змінити час
        public void Change(MyEvent e1, int? day = null, int? sHour = null, int? eHour = null, int? sMin = null, int? eMin = null)
        {
            day = day ?? e1.Day;
            sHour = sHour ?? e1.startHour;
            eHour = eHour ?? e1.endHour;
            sMin = sMin ?? e1.startMin;
            eMin = eMin ?? e1.endMin;

            index[e1.Name] = $"{e1.Day} {e1.startHour}:{e1.startMin}";
        }
        // змінити тільки ім'я/обидва
        public void Change(MyEvent e1)
        {
            index.Remove(e1.Name);
            Reserve(e1);
        }
    }

    // Exceptions
    public class ReservedTimeException : Exception
    {
        public ReservedTimeException() : base() { }

        public ReservedTimeException(string message = null) : base(message) { }
    }
    public class DurationException : ArgumentException
    {
        public DurationException() { }

        public DurationException(string message = null) : base(message) { }

    }
    public class ReservedNameException : Exception
    {
        public ReservedNameException() { }

        public ReservedNameException(string message) : base(message) { }
    }
    public class EventsOverlapseException : Exception
    {
        public EventsOverlapseException() { }

        public EventsOverlapseException(string message) : base(message) { }
    }

}
