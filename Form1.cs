using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace weekly_planer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // загружаються збережені данні
            GlobalData.LoadFromFile();

            // відображаються загружені події
            foreach (var loadedEvent in GlobalData.AllEvents)
            {
                AddPanel(loadedEvent);
            }

            GlobalData.Current_Time1.setTimeDay = int.Parse(set_TimeD.Text);
            GlobalData.Current_Time1.setTimeHour = int.Parse(set_TimeH.Text);
            GlobalData.Current_Time1.setTimeMin = int.Parse(set_TimeM.Text);
            
            Timer.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
            // для перевірки івентів на просроченість при загрузці
            isExpired(DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute);

            // для фарбування поточного дня неділі
            var days = new[]
            {
                sunday,
                monday,
                tuesday,
                wednesday,
                thursday,
                friday,
                saturday
            };

            DayOfWeek today = DateTime.Now.DayOfWeek;

            int index = (int)today; // Sunday = 0 ... Saturday = 6

            days[index].BackColor = Color.PaleGoldenrod;
        }

        // для додавання блоку справи на таблицю неділі
        private void AddPanel(MyEvent Event)
        {
            int hourHeight = 32; // висота однієї години в пікселях
            int dayWidth = 118;  // фиксована ширина дня
            int duration = Event.Duration; // тривалість в хвилинах
            // розрахунок координати y для початку івенту на панелі
            // 16 - це фіксований відступ зверху, 4 - це початок дня (з 4 години ранку)
            int y = 16 + (hourHeight * (Event.startHour - 4) + ((Event.startMin + 5) / 30) * (hourHeight / 2)); // +-5хв від стартової хвилини щоб дотянути до півгодини
            // розрахунок висоти панелі івенту відносно його тривалості. спочатку рахуються години в тривалості, потім півгодини. +1 тому що максимально 59 хв
            int height = (((duration + 1) / 60) * hourHeight) + ((((duration + 1) % 60) / 30) * (hourHeight / 2));

            // шукаємо за датою день неділі на таблиці 
            var days_tables = new[]
            {
                sunday,
                monday,
                tuesday,
                wednesday,
                thursday,
                friday,
                saturday
            };

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = Event.Day;
            DateTime eventDate = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = eventDate.DayOfWeek;

            int index = (int)dayOfWeek; // Sunday = 0 ... Saturday = 6

            // стврорюємо панель звіряючи довжину з тривалістю івента по таблиці часу
            Panel eventPanel = new Panel
            {
                Location = new Point(3, y),
                Size = new Size(dayWidth, height),
                BackColor = Color.FromArgb(128, Color.CornflowerBlue),
                BorderStyle = BorderStyle.FixedSingle
            };
            // додаємо вверху блоку назву івенту 
            Label Name_label = new Label
            {
                Text = Event.Name,
                Dock = DockStyle.Top
            };
            // додаємо кнопку видалення збоку, зправа
            Button btnDelete = new Button
            {
                Dock = DockStyle.Right,
                Size = new Size(26, 26),
                Image = global::weekly_planer.Resource2.delete2,
                BackColor = Color.White
            };

            // підписка на подію Click за допомогою лямбда-виразу
            btnDelete.Click += (sender, e) =>
            {
                if (Event.IsOnDelayTable)
                {
                    foreach (Panel p in Delay_table.Controls)
                    {
                        if (p.Name == Event.Name)
                        {
                            Delay_table.Controls.Remove(p);
                            p.Dispose();
                            break;
                        }
                    }
                }
                if (Event.IsOnOverlapsTable)
                {
                    Event.IsOverlappedWith.IsOverlappedWith = null;

                    foreach (Panel p in Overlaps_table.Controls)
                    {
                        if (p.Name == Event.Name)
                        {
                            Overlaps_table.Controls.Remove(p);
                            p.Dispose();
                            break;
                        }
                    }
                }
                Event.Delete(Event);
                Event = null; // обнулення посилання

                // з таблиці днів видаляється панель, на якій лежить кнопка
                var parentControl = btnDelete.Parent;
                if (parentControl != null)
                {
                    parentControl.Parent.Controls.Remove(parentControl);
                    parentControl.Dispose();
                    parentControl = null;
                }
            };
            // при дабл кліку на панель відкривається форма редагування справи 
            eventPanel.DoubleClick += (sender, e) =>
            {
                //EditDblClicked?.Invoke(this, EventArgs.Empty);
                using (EventForm EditForm = new EventForm(Event))
                {
                    EditForm.isEditMode = true;

                    if (EditForm.ShowDialog() == DialogResult.OK)
                    {
                        // після закриття форми зміни автоматично попадуть в об'єкт iвенту
                        // вібображення на таблиці оновиться якщо були змінені ім'я або чаc
                        Event.EventOnForm = eventPanel; // оновлюємо посилання на панель івенту
                        if (EditForm.nameChanged == true)
                        {
                            Name_label.Text = Event.Name;
                        }
                        if (EditForm.timeChanged == true)
                        {
                            // видаляємо стару панель івенту
                            var parentControl = Event.EventOnForm.Parent;
                            if (parentControl != null)
                            {
                                parentControl.Controls.Remove(Event.EventOnForm);
                                Event.EventOnForm.Dispose();
                            }
                            AddPanel(Event);
                        }
                    }
                }
            };

            eventPanel.Controls.Add(Name_label);
            eventPanel.Controls.Add(btnDelete);
            days_tables[index].Controls.Add(eventPanel);
            Event.EventOnForm = eventPanel;
            eventPanel.BringToFront();
        }
        private void Add_Event_Btn_Click(object sender, EventArgs e)
        {
            using (EventForm AddForm = new EventForm())
            {
                if (AddForm.ShowDialog() == DialogResult.OK && AddForm.newEvent != null)
                {
                    AddPanel(AddForm.newEvent);
                    if (AddForm.newEvent.IsOverlappedWith != null)
                    {
                        AddEventOnTable(AddForm.newEvent, Overlaps_table);
                        AddEventOnTable(AddForm.newEvent.IsOverlappedWith, Overlaps_table);
                        AddForm.newEvent.IsOnOverlapsTable = true;
                        AddForm.newEvent.IsOverlappedWith.IsOnOverlapsTable = true;
                    }
                }
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            var searchName = searchBox.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Щоб знайти справу введіть її повне точне ім'я і натисніть \"Пошук\"");
                return;
            }
            else
            {
                // Поиск по точному совпадению
                foreach (var existingEvent in GlobalData.AllEvents)
                {
                    if (existingEvent.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        // Открываем форму редактирования для найденного события
                        using (EventForm EditForm = new EventForm(existingEvent))
                        {
                            EditForm.isEditMode = true;

                            if (EditForm.ShowDialog() == DialogResult.OK)
                            {
                                // Обновляем отображение если были изменения
                                if (EditForm.nameChanged == true)
                                {
                                    // Обновляем название в панели события
                                    if (existingEvent.EventOnForm != null)
                                    {
                                        var nameLabel = existingEvent.EventOnForm.Controls.OfType<Label>().FirstOrDefault();
                                        if (nameLabel != null)
                                        {
                                            nameLabel.Text = existingEvent.Name;
                                        }
                                    }
                                }
                                if (EditForm.timeChanged == true)
                                {
                                    // Удаляем старую панель и создаем новую с обновленным временем
                                    if (existingEvent.EventOnForm != null)
                                    {
                                        var parentControl = existingEvent.EventOnForm.Parent;
                                        if (parentControl != null)
                                        {
                                            parentControl.Controls.Remove(existingEvent.EventOnForm);
                                            existingEvent.EventOnForm.Dispose();
                                        }
                                    }
                                    AddPanel(existingEvent);
                                }
                            }
                        }
                        return; // вихід після першого знайденої події
                    }
                }

                // якщо точне співпадення не знайдено, то шукається часткове
                var partialMatches = new List<MyEvent>();
                foreach (var existingEvent in GlobalData.AllEvents)
                {
                    if (existingEvent.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        partialMatches.Add(existingEvent);
                    }
                }

                if (partialMatches.Count > 0)
                {
                    if (partialMatches.Count == 1)
                    {
                        // якщо знайдено хоча б одне часткове співпадіння, то воно відкривається
                        var foundEvent = partialMatches[0];
                        using (EventForm EditForm = new EventForm(foundEvent))
                        {
                            EditForm.isEditMode = true;
                            if (EditForm.ShowDialog() == DialogResult.OK)
                            {
                                // оновлюється відображення якщо були зміни
                                if (EditForm.nameChanged == true)
                                {
                                    if (foundEvent.EventOnForm != null)
                                    {
                                        var nameLabel = foundEvent.EventOnForm.Controls.OfType<Label>().FirstOrDefault();
                                        if (nameLabel != null)
                                        {
                                            nameLabel.Text = foundEvent.Name;
                                        }
                                    }
                                }
                                if (EditForm.timeChanged == true)
                                {
                                    if (foundEvent.EventOnForm != null)
                                    {
                                        var parentControl = foundEvent.EventOnForm.Parent;
                                        if (parentControl != null)
                                        {
                                            parentControl.Controls.Remove(foundEvent.EventOnForm);
                                            foundEvent.EventOnForm.Dispose();
                                        }
                                    }
                                    AddPanel(foundEvent);
                                }
                            }
                        }
                    }
                }
                else
                {
                    // якщо подія не знайдена
                    MessageBox.Show($"Справу з ім'ям \"{searchName}\" не знайдено.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddEventOnTable(MyEvent event1, FlowLayoutPanel _table)
        {
            int size = 155;

            if (_table == Delay_table)
            {
                size = 260; // розмір панелі для прострочених справ
            }
            Panel eventPanelInTable1 = new Panel
            {
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(size, 46),
                MaximumSize = new Size(size, 46),
                MinimumSize = new Size(size, 46),
                Name = event1.Name
            };
            Label Name_label = new Label
            {
                Text = event1.Name,
                Font = new Font(Font.FontFamily, 10),
                Location = new Point(3, 1)
            };
            Label Descr_label = new Label
            {
                Text = event1.Description,
                Font = new Font(Font.FontFamily, 9),
                ForeColor = Color.Black,
                Location = new Point(4, 24),
                BackColor = Color.Transparent,
                MaximumSize = new Size(130, 13),
                MinimumSize = new Size(130, 13),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            Button btnDelete1 = new Button
            {
                Dock = DockStyle.Right,
                Image = global::weekly_planer.Resource2.delete2,
                BackColor = Color.White,
                Size = new Size(26, 26)
            };

            // підписка на подію Click
            btnDelete1.Click += (sender2, e2) =>
            {
                var parentControl1 = btnDelete1.Parent; // панель на якій лежить кнопка
                parentControl1.Parent.Controls.Remove(parentControl1); // звертаємося до таблиці
                parentControl1.Dispose(); // видаляємо панель з пам'яті
                parentControl1 = null;

                event1.EventOnForm.Parent.Controls.Remove(event1.EventOnForm); // видаляємо панель з таблиці дня
                event1.EventOnForm.Dispose();
                event1.EventOnForm = null; // обнулення посилання на панель
                event1.Delete(event1);
            };

            eventPanelInTable1.Controls.Add(btnDelete1);
            eventPanelInTable1.Controls.Add(Name_label);
            eventPanelInTable1.Controls.Add(Descr_label);

            event1.EventOnForm.BackColor = Color.LightGray;
            _table.Controls.Add(eventPanelInTable1);
        }
        //public event EventHandler SubmitClicked;
        //public event EventHandler EditDblClicked;
        //private void submitButton_Click(object sender, EventArgs e)
        //{
        //    SubmitClicked?.Invoke(this, EventArgs.Empty);
        //}
        //private void eventPanel_DoubleClick(object sender, EventArgs e)
        //{
        //    EditDblClicked?.Invoke(this, EventArgs.Empty);
        //}
        private void set_Time_Click(object sender, EventArgs e)
        {
            //SubmitClicked?.Invoke(sender, e);
            GlobalData.Current_Time1.setTimeDay = int.Parse(set_TimeD.Text);
            GlobalData.Current_Time1.setTimeHour = int.Parse(set_TimeH.Text);
            GlobalData.Current_Time1.setTimeMin = int.Parse(set_TimeM.Text);

            isExpired(GlobalData.Current_Time1.setTimeDay, GlobalData.Current_Time1.setTimeHour, GlobalData.Current_Time1.setTimeMin); // перевірка івентів на просроченість
        }

        public void isExpired(int day, int currentHour, int currentMin)
        {
            foreach (var event2 in GlobalData.AllEvents)
            {
                if (event2.IsOnDelayTable == true)
                {
                    continue;
                }
                else if (event2.Day < day)
                {
                    AddEventOnTable(event2, Delay_table);
                    event2.IsOnDelayTable = true;
                }
                else if (event2.Day == day && event2.endHour < currentHour)
                {
                    AddEventOnTable(event2, Delay_table);
                    event2.IsOnDelayTable = true;
                }
                else if (event2.Day == day && event2.endHour == currentHour && event2.endMin <= currentMin)
                {
                    AddEventOnTable(event2, Delay_table);
                    event2.IsOnDelayTable = true;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Просто сохраняем данные при закрытии
            GlobalData.SaveToFile();
        }
    }
}
