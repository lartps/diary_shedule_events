using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static weekly_planer.Program;

namespace weekly_planer
{
    class Prog
    {
        public static void Main()
        {
            //Event e1 = new Event();
        }
    }

    public class Event
    {
        public static int nameCounter_ = 1;

        static Indexator i = new Indexator();

        public string Name { get; private set; } = "Cправа " + nameCounter_++;
        public string Description { get; set; } = "";
        public string Details { get; set; } = "";
        public string Location { get; set; } = "";
        public int startHour
        {
            get
            {
                return CurrentTime.setTimeHour;
            }
            set
            {

                startHour = value;
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
        public int startMin
        {
            get
            {
                return CurrentTime.setTimeMin;
            }
            set
            {
                startMin = value;
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


        public int Duration(int startHour, int endHour, int startMin, int endMin)
        {
            return ((endHour - (startHour + 1)) * 60) + ((60 - startMin) + endMin);
        }

        public void Delete()
        {
            // удалить из листа, очистить ресервд нейм и тайм

        }

        public bool isOverlayed(Event other)
        {

            int DurationDiffFromStart = Duration(this.startHour, other.startHour, this.startMin, other.startMin);
            int OverlapsedDuration = Duration(other.startHour, other.startMin, this.endHour, this.endMin);

            if (other.Day == this.Day && DurationDiffFromStart >= 30 && OverlapsedDuration >= 10) return true;
            return false;
        }

        public void Rename(string NewName)
        {
            // на место индекса поставить новое значение

            this.Name = NewName;
        }
        public Event(int? SetStartHour = null, int? SetEndHour = null, int? SetStartMin = null, int? SetEndMin = null, int? SetDay = null, string SetName = null, string SetDescr = "", string SetLoc = "", string SetDet = "")
        {
            i.Add(SetName);
            Name = Name ?? SetName;

            Day = Day ?? SetDay;

            startHour = SetStartHour;
            endHour = SetEndHour;

            startMin = SetStartMin;
            endMin = SetEndMin;

            i.ReserveTime(this.startHour, this.startMin);
            
            
            Description = SetDescr;
            Location = SetLoc;
            Details = SetDet;
            Console.WriteLine($"{SetName}, {SetDay}, {SetStartHour}:{SetStartMin} -- {SetEndHour}:{SetEndMin}, {SetDescr}");
        }




    }

    class Indexator
    {
        private Dictionary<string, List<int>> index = new Dictionary<string, List<int>>();
        private List<string> ReservedNames = new List<string>();
        int[,] ReservedTime = new int[20, 2];
        public int ReservedTimeIndex { get; set; } = 0;
        public void Add(string name)
        {
            int id = ReservedNames.Count;
            ReservedNames.Add(name.Trim().ToLower());

            index[name.Trim().ToLower()].Add(id);

            if (ReservedNames.Contains(name))
            {
                Console.WriteLine("така назва вже э");
                return;
            }
            
        }

        public void ReserveTime(int startHour, int startMin)
        {
            ReservedTime[ReservedTimeIndex,0] = startHour;
            ReservedTime[ReservedTimeIndex, 1] = startMin;
            ++ReservedTimeIndex;
        }
        public void CheckTime(int hour, int min)
        {
            for (int j = 0; j < ReservedTimeIndex; ++j)
            {
                if (ReservedTime[j, 0] == hour && (ReservedTime[j, 1] == min || ReservedTime[j, 1] == min + 10 || ReservedTime[j, 1] == min + 20))
                {
                    Console.WriteLine("this time is reserved for another event");
                    return;
                } // error

            }
        }

        public void DeleteAll(string name, int id)
        {
            ReservedTime[ReservedTimeIndex, 0] = 0;
            ReservedTime[ReservedTimeIndex, 1] = 0;

            ReservedNames.RemoveAt(ReservedNames.Count);
            index[name].RemoveAt(ReservedNames.Count);
            --ReservedTimeIndex;
        }

        public string Search(string query)
        {
            query = query.Trim().ToLower();
            if (index.ContainsKey(query))
            {
                var result = new List<string>();
                foreach (int id in index[query])
                    return ReservedNames[id]; // форма этого ивента
            }

            return ""; // не найдено
        }

    }

    public static class CurrentTime
    {
        public static int setTimeHour { get; set; } = 17;
        public static int setTimeMin { get; set; } = 0;
        public static int setTimeDay { get; set; } = 7;

    }

    class Remainder
    {
        int setTimeToNotify = 10;
        public Remainder(int currentHour, int currentMin)
        {
            if (CurrentTime.setTimeMin == currentMin - setTimeToNotify && CurrentTime.setTimeHour == currentHour) 
            {
                Console.WriteLine("notify");
            }
        }

    }







}
