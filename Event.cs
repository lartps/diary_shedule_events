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
            int duration = ((endHour - (startHour + 1)) * 60) + ((60 - startMin) + endMin);
            //if (duration <= 0 || duration < 30) throw new DurationException();
                
            return duration;

        }

        public void Delete()
        {
            // удалить из листа, очистить ресервд нейм и тайм

        }

        public bool isOverlayed(MyEvent other)
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
        public MyEvent(string SetName, int SetDay, int SetStartHour, int SetStartMin, int SetEndHour, int SetEndMin, string SetDescr = "", string SetLoc = "", string SetDet = "")
        {
            i.Add(SetName);
            Name = SetName;
            Day = SetDay;

            startHour = SetStartHour;
            startMin = SetStartMin;

            endHour = SetEndHour;
            endMin = SetEndMin;

            i.ReserveTime(this.startHour, this.startMin);
            
            Description = SetDescr;
            Location = SetLoc;
            Details = SetDet;
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
                //Console.WriteLine("така назва вже э");
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
                    //throw new ReservedTimeException();
                }

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
        public static int setTimeDay { get; private set; } = DateTime.Now.Day;
        public static int setTimeHour { get; private set; } = DateTime.Now.Hour;
        public static int setTimeMin { get; private set; } = DateTime.Now.Minute;

    }

    //public class ReservedTimeException : Exception
    //{
    //    public new void Message(string error)
    //    {
    //        Console.WriteLine("This time is alrady reserved for another event");
    //    }
    //}
    //public class DurationException : ArgumentException
    //{
    //    DurationException() : base() { Console.WriteLine("Duration cant be less than atleast 30 min"); }
    //}

}
