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
        static public Validate v1 = new Validate(); // для проверки на неправильное\полное пересечение дел
        static public List<MyEvent> AllEvents = new List<MyEvent>(); // для сохранения данных по всем делам а потом эту инфу тупо тока сохранять и каждый раз отрисовывать при новом запуске проги
        static public CurrentTime Current_Time1 = new CurrentTime(); // для отображения текущего времени в проге

        public class CurrentTime
        {
            public int setTimeDay { get; set; } = DateTime.Now.Day;
            public int setTimeHour { get; set; } = DateTime.Now.Hour;
            public int setTimeMin { get; set; } = DateTime.Now.Minute;
        }

        // public void LoadFromFile(string path)
        // {
        // Загрузка задач
        // }

        // public void SaveToFile(string path)
        // {
        // create file to save n load
        //string json = JsonSerializer.Serialize(Tasks);
        //File.WriteAllText("tasks.json", json);

        //var tasks = JsonSerializer.Deserialize<List<MyEvent>>(File.ReadAllText("tasks.json"));

        //jobExchangeInstance.DeserializeData("data.txt");
        //_originalData = File.ReadAllText("data.txt");
        // }
    }
}
