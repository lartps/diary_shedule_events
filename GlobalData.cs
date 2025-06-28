using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace weekly_planer
{
    public class GlobalData
    {
        static public Validate v1 = new Validate();
        static public List<MyEvent> AllEvents = new List<MyEvent>(); // для сохранения данных по всем делам а потом эту инфу тупо тока сохранять и каждый раз отрисовывать при новом запуске проги
        static public CurrentTime Current_Time1 = new CurrentTime(); // для отображения текущего времени в проге
        static public bool IsTimeManuallySet = false; // флаг, показывающий, была ли нажата кнопка установки времени

        public class CurrentTime
        {
            public int setTimeDay { get; set; }
            public int setTimeHour { get; set; }
            public int setTimeMin { get; set; }
        }

        // збереження в текстовий файл
        public static void SaveToFile(string filePath = "data.txt")
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Сохраняем события
                    writer.WriteLine("EVENTS:");
                    foreach (var evt in AllEvents)
                    {
                        writer.WriteLine($"{evt.Name}|{evt.Description}|{evt.Location}|{evt.Details}|{evt.Day}|{evt.startHour}|{evt.startMin}|{evt.endHour}|{evt.endMin}");
                    }

                    // Сохраняем валидацию
                    writer.WriteLine("VALIDATION:");
                    foreach (var kwv in v1.index)
                    {
                        writer.WriteLine($"{kwv.Key}|{kwv.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Помилка збереження: {ex.Message}", "Помилка",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        // завантаження з текстового файлу
        public static void LoadFromFile(string filePath = "data.txt")
        {
            try
            {
                if (!File.Exists(filePath)) return;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool readingEvents = false;
                    bool readingValidation = false;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == "EVENTS:")
                        {
                            readingEvents = true;
                            readingValidation = false;
                            continue;
                        }
                        else if (line == "VALIDATION:")
                        {
                            readingEvents = false;
                            readingValidation = true;
                            continue;
                        }

                        if (readingEvents && !string.IsNullOrEmpty(line))
                        {
                            var parts = line.Split('|');
                            if (parts.Length >= 9)
                            {
                                try
                                {
                                    var evt = new MyEvent(
                                        int.Parse(parts[4]), // Day
                                        int.Parse(parts[5]), // startHour
                                        int.Parse(parts[6]), // startMin
                                        int.Parse(parts[7]), // endHour
                                        int.Parse(parts[8]), // endMin
                                        parts[0], // Name
                                        parts[1], // Description
                                        parts[2], // Location
                                        parts[3]  // Details
                                    );
                                }
                                catch
                                {
                                    // некорректні записи пропускаються
                                }
                            }
                        }
                        else if (readingValidation && !string.IsNullOrEmpty(line))
                        {
                            var parts = line.Split('|');
                            if (parts.Length >= 2)
                            {
                                v1.index[parts[0]] = parts[1];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Помилка завантаження: {ex.Message}", "Помилка",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
