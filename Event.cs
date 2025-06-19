using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static weekly_planer.Program;

namespace weekly_planer
{
    public class MyEvent
    {
        public static int nameCounter_ = 1;

        public string Name { get; private set; } = "Cправа " + nameCounter_++;
        public string Description { get; set; } = "";
        public string Details { get; set; } = "";
        public string Location { get; set; } = "";
        public int Day
        {
            get
            {
                return CurrentTime.setTimeDay;
            }
            set
            {
                Day = value;
            }
        }
        public int startHour
        {
            get
            {
                return CurrentTime.setTimeHour;
            }
            set
            {
                Form1.v1.IsReserved(Name, Day, value, startMin);
                startHour = value;
            }
        }
        public int startMin
        {
            get
            {
                return CurrentTime.setTimeMin;
            }
            set
            {
                Validate.IsReserved(Name, Day, startHour, value);
                startMin = value;
            }
        }
        public int endHour
        {
            get
            {
                return CurrentTime.setTimeHour + 1;
            }
            set
            {
                endHour = value;
            }
        }

        public int endMin
        {
            get
            {
                return CurrentTime.setTimeMin + 30;
            }
            set
            {
                endMin = value;
            }
        }

        public int Duration(MyEvent event1)
        {
            int duration = ((event1.endHour - (event1.startHour + 1)) * 60) + ((60 - event1.startMin) + event1.endMin);
            if (duration <= 0 || duration < 30) throw new DurationException("Duration can't be less than atleast 30 min");

            return duration;
        }

        public void Delete(MyEvent event1)
        {
            // удалить из листа всех ивентов, очистить зарезервированные имя и время
            Validate.Delete(event1.Name);
            Form1_Load.AllEvents.Remove(event1);
        }
        // проверка что другой ивент правильно перекрывается с этим ивентом
        public bool isOverlayed(MyEvent other)
        {
            if (other.Day == this.Day)
            {
                int DurationDiffFromStart = Duration(this.startHour, other.startHour, this.startMin, other.startMin); // проверка что разница между началом этого ивента и началом другого минмум 30 минут
                int OverlapsedDuration = Duration(other) - Duration(this); // проверка что перекрытие между этими ивентами минимум 30 минут
                OverlapsedDuration = OverlapsedDuration > 0 ? OverlapsedDuration : (-1) * (OverlapsedDuration);
                if (DurationDiffFromStart >= 30 && OverlapsedDuration >= 30) return true;
            }

            return false;
        }

        // изменить имя
        public void Rename(string NewName)
        {
            Validate.Change(this.Name, NewName);
            this.Name = NewName;
        }
        // создать ивент
        public MyEvent(string SetName, int SetDay, int SetStartHour, int SetStartMin, int SetEndHour, int SetEndMin, string SetDescr = "", string SetLoc = "", string SetDet = "")
        {
            Name = SetName;
            Day = SetDay;

            startHour = SetStartHour;
            startMin = SetStartMin;

            endHour = SetEndHour;
            endMin = SetEndMin;

            Validate.Reserve(SetName, SetDay, SetStartHour, SetStartMin);

            Description = SetDescr;
            Location = SetLoc;
            Details = SetDet;
            AllEvents.Add(this);
        }


    }

    public class Validate
    {
        static Dictionary<string, string> index = new Dictionary<string, string>(); // индексатор для поиска по имени или времени

        public static void Reserve(string name, int day, int startHour, int startMin)
        {
            index[name] = $"{day} {startHour}:{startMin}";
        }

        public bool IsReserved(string name, int day, int startHour, int startMin)
        {
            if (index.ContainsKey(name))
            {
                throw new ReservedNameException("This name is already reserved, please choose another one");
            }

            // Проверяем все существующие события
            foreach (var existingEvent in index.Values)
            {
                var parts = existingEvent.Split(' ');
                int existingDay = int.Parse(parts[0]);
                var timeParts = parts[1].Split(':');
                int existingHour = int.Parse(timeParts[0]);
                int existingMin = int.Parse(timeParts[1]);

                // Если это тот же день
                if (existingDay == day)
                {
                    // Проверяем, не попадает ли новое время в 30-минутный резерв от началасуществующего события
                    if (startHour == existingHour && (existingMin + 30 < 60))
                    {
                        if (startMin == existingMin || existingMin + 30 >= startMin)
                            throw new ReservedTimeException("This time overlaps with another event's 30-minute reservation period");
                    }

                    // Проверяем случай перехода через час
                    if (existingMin + 30 >= 59)
                    {
                        int nextMin = (existingMin + 30) % 60;

                        if ((startHour == existingHour + 1 && startMin <= nextMin))
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
        public void Change(string name, int day, int startHour, int startMin, int endHour, int endMin)
        {
            index[name] = $"{day} {startHour}:{startMin}";
        }
        // изменить имя
        public void Change(string name, string newName)
        {
            index[newName] = index[name];
            index.Remove(name);
        }
        // изменить имя и время
        public void Change(string name, string newName, int day, int startHour, int startMin, int endHour, int endMin)
        {
            index[newName] = $"{day} {startHour}:{startMin}";
            index.Remove(name);
        }
    }

    public class Search
    {

    }





    public static class CurrentTime
    {
        public static int setTimeDay { get; private set; } = DateTime.Now.Day;
        public static int setTimeHour { get; private set; } = DateTime.Now.Hour;
        public static int setTimeMin { get; private set; } = DateTime.Now.Minute;

    }


    // Exceptions
    public class ReservedTimeException : Exception
    {
        public ReservedTimeException() : base() { }

        public ReservedTimeException(string message) : base(message) { Console.WriteLine("RES TIME"); }
    }
    public class DurationException : ArgumentException
    {
        public DurationException() { }

        public DurationException(string message) : base(message) { Console.WriteLine("DURATION ERR"); }

    }

    public class ReservedNameException : Exception
    {
        public ReservedNameException() { }

        public ReservedNameException(string message) : base(message) { Console.WriteLine("RES NAME"); }
    }

    public class EventsOverlapseException : Exception
    {
        public EventsOverlapseException() { }

        public EventsOverlapseException(string message) : base(message) { Console.WriteLine("OVERLAY ERR"); }
    }

}
