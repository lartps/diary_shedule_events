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
    public class MyEvent : IEventRequester
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
        public MyEvent IsOverlappedWith = null; // одна накладка на одну подію
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
                if (GlobalData.v1.IsReserved(this))
                {
                    throw new ReservedTimeException("Це ім'я або час зарезервовані іншою подією");
                }
                foreach (var existingEvent in GlobalData.AllEvents)
                {
                    // перевіряються тільки події в той же день.
                    // щоб івенти мали пересічення час кінця верхнього ранішого івенту existingEvent(other) повинен бути меньше(тобто більше тому що в годинах)
                    // ніж початок пізнішого івенту this
                    if (existingEvent.Day == this.Day && existingEvent.endHour > this.startHour)
                    {
                        // використано метод isOverlayed для перевірки накладання
                        if (this.isOverlayed(existingEvent))
                        {
                            if (existingEvent.IsOverlappedWith != null)
                                throw new EventsOverlapseException("У події не може бути більше однієї накладки"); // якщо вже є накладка, то не можна створити нову
                            this.IsOverlappedWith = existingEvent;
                            existingEvent.IsOverlappedWith = this; // встановлюємо накладку в обох подіях
                            break;
                        }
                    }
                }
            }
            GlobalData.v1.Reserve(this);
            GlobalData.AllEvents.Add(this);
        }
        private int DurationOfEvent(MyEvent event1)
        {
            int duration = ((((event1.endHour - event1.startHour) * 60) - event1.startMin) + event1.endMin);
            if (duration < 30) throw new DurationException("Подія має тривати не менше 30 хвилин");
            return duration;
        }
        private int DurationOfEvent(int startHour, int endHour, int startMin, int endMin)
        {
            if (endHour == startHour && startMin != 0) return (startMin - endMin) * (startMin - endMin > 0 ? 1 : (-1));
            int duration = ((((endHour - startHour) * 60) - startMin) + endMin);
            duration *= (duration > 0 ? 1 : (-1));
            if (duration < 30) throw new DurationException("Подія має тривати не менше 30 хвилин");
            return duration;
        }


        // перевірка що інший івент правильно перекриваеться з цим івентом
        private bool isOverlayed(MyEvent other)
        {
            if (other.IsOverlappedWith != null || this.IsOverlappedWith != null)
            {
                throw new EventsOverlapseException("У події не може бути більше однієї накладки");
            }
            if (other.Day == this.Day)
            {
                if (this.startHour > other.startHour || (this.startHour == other.startHour && this.startMin > other.startMin))
                {
                    try
                    {
                        int DurationDiffFromStart = DurationOfEvent(other.startHour, this.startHour, other.startMin, this.startMin); // перевірка що різница між початком цього івента і початком другого мінімум 30 хвилин
                        int OverlapsedDuration = DurationOfEvent(other.endHour, this.startHour, other.endMin, this.startMin); // перевірка що перекриття між цими івентами мінімум 30 хвилин. беремо початок іншого івента і кінець цього івента
                        if (DurationDiffFromStart >= 30 && OverlapsedDuration >= 30) return true;
                        else if (OverlapsedDuration < 30) throw new EventsOverlapseException("Перекриття між подіями повинно тривати більше 30 хвилин");
                    }
                    catch (DurationException)
                    {
                        throw new ReservedTimeException("Накладка повинна починатися мінімум на 30 хвилин пізніше ніж початок події на яку накладається");
                    }
                }
            }
            return false;
        }

        // видалити зі списку всіх івентів, очистити зарезервоване ім'я та час, тд
        public void Delete(MyEvent event1)
        {
            if (event1.IsOverlappedWith != null) event1.IsOverlappedWith.IsOverlappedWith = null; // очищаємо накладку, якщо вона була
            GlobalData.v1.Delete(event1.Name);
            GlobalData.AllEvents.Remove(event1);
        }
        // змінити ім'я
        public void Rename(string prevName) // нове ім'я автоматично вже присвоєно через датабинд
        {
            GlobalData.v1.Change(prevName, this);
        }
        // змінити час
        public void ChangeTime(int newStartDay, int newStartHour, int newEndHour, int newStartMin, int newEndMin)
        {
            GlobalData.v1.Change(this.Name, this.Day, this.startHour, this.startMin);
            Duration = DurationOfEvent(this);
            foreach (var existingEvent in GlobalData.AllEvents)
            {
                if (existingEvent.Day == this.Day)
                {
                    // використано метод isOverlayed для перевірки накладання
                    if (this.isOverlayed(existingEvent))
                    {
                        this.IsOverlappedWith = existingEvent;
                        existingEvent.IsOverlappedWith = this;
                        break;
                    }
                }
                else if (this.IsOverlappedWith != null)
                {
                    this.IsOverlappedWith = null; // при зміні часу очищаємо накладку, якщо вона була
                    this.IsOnOverlapsTable = false; // очищаємо флаг для відображення в таблиці накладок
                }
            }
        }
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
                throw new ReservedNameException("Справа з такою назвою вже існує");
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
                        if (e1.startMin == existingMin || existingMin + 30 > e1.startMin)
                            throw new ReservedTimeException($"Цей час перекривається з 30-хвилинним зарезервованим періодом від початку іншої події. Подія \"{e1.Name}\" в {e1.Day}.06 {e1.startHour}:{e1.startMin} перекривається з подією в {existingDay}.06 {existingHour}:{existingMin}");
                    }

                    // Перевіряємо випадок переходу через час
                    if (existingMin + 30 >= 59)
                    {

                        int nextMin = (existingMin + 30 + (existingMin + 30 == 59 ? 1 : 0)) % 60;

                        if ((e1.startHour == existingHour + 1 && e1.startMin <= nextMin))
                        {
                            throw new ReservedTimeException($"Цей час перекривається з 30-хвилинним зарезервованим періодом від початку іншої події. Подія \"{e1.Name}\" в {e1.Day}.06 {e1.startHour}:{e1.startMin} перекривається з подією в {existingDay}.06 {existingHour}:{existingMin}");
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

        // змінити лише значення
        public void Change(string name, int day, int sHour, int sMin)
        {
            index[name] = $"{day} {sHour}:{sMin}";
        }
        // змінити тільки ключ або і значення
        public void Change(string prevName, MyEvent e1)
        {
            if (index.Remove(prevName)) Reserve(e1);
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
