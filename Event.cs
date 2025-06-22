using System;
using System.Collections.Generic;
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

        public string Name { get; set; } = "Cправа " + nameCounter_++;
        public string Description { get; set; } = "";
        public string Details { get; set; } = "";
        public string Location { get; set; } = "";
        public int Day { get; set; }
        public int startHour { get; set; }
        public int startMin { get;set; }
        public int endHour { get; set; }
        public int endMin { get; set; }
        public int Duration1 { get; set; }

        public MyEvent(string SetName, int SetDay, int SetStartHour, int SetStartMin, int SetEndHour, int SetEndMin, string SetDescr = "", string SetLoc = "", string SetDet = "")
        {
            Name = SetName;
            Day = SetDay;

            startHour = SetStartHour;
            startMin = SetStartMin;

            endHour = SetEndHour;
            endMin = SetEndMin;

            Description = SetDescr;
            Location = SetLoc;
            Details = SetDet;

            Duration1 = Duration(this);
        }
        public int Duration(MyEvent event1)
        {
            int duration = ((event1.endHour - (event1.startHour + 1)) * 60) + ((60 - event1.startMin) + event1.endMin);
            if (duration <= 0 || duration < 30) throw new DurationException("Duration can't be less than atleast 30 min");

            return duration;
        }
        public int Duration(int startHour, int endHour, int startMin, int endMin)
        {
            int duration = ((endHour - (startHour + 1)) * 60) + ((60 - startMin) + endMin);
            if (duration <= 0 || duration < 30) throw new DurationException();

            return duration;
        }
        // удалить из листа всех ивентов, очистить зарезервированные имя и время
        public void Delete(MyEvent event1)
        {

            GlobalData.v1.Delete(event1.Name);
            GlobalData.AllEvents.Remove(event1);
        }

        // проверка что другой ивент правильно перекрывается с этим ивентом
        public bool isOverlayed(MyEvent other)
        {
            if (other.Day == this.Day)
            {
                int DurationDiffFromStart = Duration(this.startHour, other.startHour, this.startMin, other.startMin); // проверка что разница между началом этого ивента и началом другого минмум 30 минут
                int OverlapsedDuration = other.Duration1 - this.Duration1; // проверка что перекрытие между этими ивентами минимум 30 минут
                OverlapsedDuration = OverlapsedDuration > 0 ? OverlapsedDuration : (-1) * (OverlapsedDuration);
                if (DurationDiffFromStart >= 30 && OverlapsedDuration >= 30) return true;
            }
            return false;
        }

        // изменить имя
        public void Rename(string NewName)
        {
            GlobalData.v1.Change(this);
            this.Name = NewName;
        }
        // создать ивент
        

        public void Validation()
        {
            if (GlobalData.v1.index.Count >= 1)
            {
                if (GlobalData.v1.IsReserved(this)) // если зарезервировано время или имя, то нельзя создать 
                {
                    throw new ReservedTimeException("RES");
                }
                foreach (var existingEvent in GlobalData.AllEvents)
                {
                    // Проверяем только события в тот же день
                    if (existingEvent.Day == this.Day)
                    {
                        // Используем метод isOverlayed для проверки наложения
                        if (this.isOverlayed(existingEvent))
                        {
                            throw new EventsOverlapseException($"Событие \"{this.Name}\" накладывается на событие \"{existingEvent.Name}\" в день {this.Day}");
                        }
                    }
                }
            }
            GlobalData.v1.Reserve(this);
            GlobalData.AllEvents.Add(this);
        }


    }

    public class Validate
    {
        public Dictionary<string, string> index = new Dictionary<string, string>(); // индексатор для поиска по имени или времени

        public void Reserve(MyEvent e1)
        {
            index[e1.Name] = $"{e1.Day} {e1.startHour}:{e1.startMin}";
        }

        public bool IsReserved(MyEvent e1)
        {
            if (index.ContainsKey(e1.Name))
            {
                throw new ReservedNameException("This name is already reserved, please choose another one");
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
                            throw new ReservedTimeException($"This time overlaps with another event's 30-minute reservation period. Event \"{e1.Name}\" at {index[e1.Name]} overlaps with event at {existingTime}");
                    }

                    // Перевіряємо випадок переходу через час
                    if (existingMin + 30 >= 59)
                    {
                        int nextMin = (existingMin + 30) % 60;

                        if ((e1.startHour == existingHour + 1 && e1.startMin <= nextMin))
                        {
                            throw new ReservedTimeException("This time overlaps with another event's 30-minute reservation period");
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
        // изменить время
        public void Change(MyEvent e1, int? day = null, int? sHour = null, int? eHour = null, int? sMin = null, int? eMin = null)
        {
            day = day ?? e1.Day;
            sHour = sHour ?? e1.startHour;
            eHour = eHour ?? e1.endHour;
            sMin = sMin ?? e1.startMin;
            eMin = eMin ?? e1.endMin;

            index[e1.Name] = $"{e1.Day} {e1.startHour}:{e1.startMin}";
        }
        // изменить только имя/оба
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

        public ReservedTimeException(string message) : base(message) { Console.WriteLine("RES_TIME"); }
    }
    public class DurationException : ArgumentException
    {
        public DurationException() { }

        public DurationException(string message) : base(message) { Console.WriteLine("DURATION_ERR"); }

    }

    public class ReservedNameException : Exception
    {
        public ReservedNameException() { }

        public ReservedNameException(string message) : base(message) { Console.WriteLine("RES_NAME"); }
    }

    public class EventsOverlapseException : Exception
    {
        public EventsOverlapseException() { }

        public EventsOverlapseException(string message) : base(message) { Console.WriteLine("OVERLAY_ERR"); }
    }

}
