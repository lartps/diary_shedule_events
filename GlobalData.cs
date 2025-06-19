using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace weekly_planer
{
    public class GlobalData
    {
        //private static GlobalData _instance;
        //public static GlobalData Instance => _instance ??= new GlobalData();

        //public EventManager EventManager { get; set; } = new EventManager();
        //private GlobalData() { } // Закритий конструктор

        Validate v1 = new Validate(); // для проверки на неправильное\полное пересечение дел
    }
}
