using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekly_planer
{
    public interface IFormRequester
    {

        string Name { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        string Details { get; set; }
        int startHour { get; set; }
        int endHour { get; set; }
        int startMin { get; set; }
        int endMin { get; set; }

        void Delete();
        void Rename(string newName);
        void ChangeDescr(string newStr);
        void ChangeLoc(string newStr);
        void ChangeDetails(string newStr);

        void ChangeDay(int newStartDay);
        void ChangeStartHour(int newStartHour);
        void ChangeEndHour(int newEndHour);
        void ChangeStartMin(int newStartMin);
        void ChangeEndMin(int newEndMin);



    }
}
