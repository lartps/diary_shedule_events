using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekly_planer
{
    public interface IEventRequester
    {
        string Name { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        string Details { get; set; }
        int Day { get; set; }
        int startHour { get; set; }
        int endHour { get; set; }
        int startMin { get; set; }
        int endMin { get; set; }
        int Duration { get; set; }

        void Delete(MyEvent e1);
        void Rename(string newName);
        void ChangeTime(int newStartDay, int newStartHour, int newEndHour, int newStartMin, int newEndMin);
    }
}
