using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace weekly_planer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GlobalData data = new GlobalData();
            GlobalData.Current_Time1.setTimeHour = int.Parse(set_TimeH.Text);
            GlobalData.Current_Time1.setTimeMin = int.Parse(set_TimeM.Text);

            //foreach (var event1 in GlobalData.AllEvents)
            //{
            //    if (event1.IsOnOverlapsTable == true)
            //    {
            //        continue;
            //    }
            //    else if (event1.Day < GlobalData.Current_Time1.setTimeDay)
            //    {
            //        AddEventOnTable(event1, Delay_table);
            //    }
            //    else if (event1.Day == GlobalData.Current_Time1.setTimeDay && event1.endHour < GlobalData.Current_Time1.setTimeHour)
            //    {
            //        AddEventOnTable(event1, Delay_table);

            //    }
            //    else if (event1.Day == GlobalData.Current_Time1.setTimeDay && event1.endHour == GlobalData.Current_Time1.setTimeHour && event1.endMin <= GlobalData.Current_Time1.setTimeMin)
            //    {
            //        AddEventOnTable(event1, Delay_table);
            //    }
            //}
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                // save
                this.Close();
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // додається блок справи на таблицю неділі
        private void AddPanelToTable(MyEvent Event)
        {
            int hourHeight = 32; // висота однієї години в пікселях
            int dayWidth = 118;  // фиксована ширина дня
            int duration = Event.DurationOfEvent(Event);
            int y = 16 + hourHeight * (Event.startHour - 4) + ((Event.startMin + 1) / 30) * (hourHeight / 2);
            int height = (duration / 60) * hourHeight + (((duration + 1) % 60) / 30) * (hourHeight / 2);

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
            int day = (int)Event.Day;
            DateTime eventDate = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = eventDate.DayOfWeek;

            int index = (int)dayOfWeek; // Sunday = 0 ... Saturday = 6

            Panel eventPanel = new Panel
            {
                Location = new Point(3, y),
                Size = new Size(dayWidth, height),
                BackColor = Color.FromArgb(128, Color.CornflowerBlue),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label Name_label = new Label
            {
                Text = Event.Name,
                Dock = DockStyle.Top,
                Font = new Font(Font, FontStyle.Bold)
            };

            Button btnDelete = new Button
            {
                Dock = DockStyle.Right,
                Size = new Size(26, 26),
                Image = global::weekly_planer.Resource2.delete2,
                UseVisualStyleBackColor = false,
            };

            // підписка на подію Click за допомогою лямбда-виразу
            btnDelete.Click += (sender, e) =>
            {
                Event.Delete(Event);
                Event = null; // обнулення посилання

                // видаляється панель, на якій лежить кнопка
                var parentControl = btnDelete.Parent;
                if (parentControl != null)
                {
                    parentControl.Parent.Controls.Remove(parentControl);
                    parentControl.Dispose();
                    parentControl = null;
                }
            };

            eventPanel.Controls.Add(Name_label);
            eventPanel.Controls.Add(btnDelete);
            days_tables[index].Controls.Add(eventPanel);
            Event.EventOnForm = eventPanel;
        }
        private void Add_Event_Btn_Click(object sender, EventArgs e)
        {
            using (EventForm eventForm1 = new EventForm())
            {
                if (eventForm1.ShowDialog() == DialogResult.OK && eventForm1.newEvent != null)
                {
                    AddPanelToTable(eventForm1.newEvent);
                }
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                // save
                this.Close();
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            var searchName = findBtn.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Щоб знайти справу введіть її повне точне ім'я і натисніть \"Пошук\"");
                return;
            }

            // Тут нужно реализовать поиск по имени в листе дел


        }

        private void AddEventOnTable(MyEvent event1, FlowLayoutPanel _table)
        {
            Panel eventPanelInTable1 = new Panel
            {
                BackColor = Color.FromArgb(128, Color.LightGray),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(260, 46),
                MaximumSize = new Size(260, 46),
                MinimumSize = new Size(260, 46)
            };
            Label Name_label = new Label
            {
                Text = event1.Name,
                Font = new Font(Font, FontStyle.Bold),
                Location = new Point(3, 1)
            };
            Button btnDelete1 = new Button
            {
                Dock = DockStyle.Right,
                Image = global::weekly_planer.Resource2.delete2,
                UseVisualStyleBackColor = false,
                Size = new Size(26, 26)
            };
            Label Descr_label = new Label
            {
                Text = event1.Description,
                Location = new Point(4, 24)
            };

            // підписка на подію Click
            btnDelete1.Click += (sender2, e2) =>
            {
                event1.Delete(event1);

                var parentControl1 = btnDelete1.Parent;
                if (parentControl1 != null)
                {
                    parentControl1.Parent.Controls.Remove(parentControl1);
                    parentControl1.Dispose();
                    parentControl1 = null;
                }
            };

            eventPanelInTable1.Controls.Add(Name_label);
            eventPanelInTable1.Controls.Add(btnDelete1);
            eventPanelInTable1.Controls.Add(Descr_label);

            _table.Controls.Add(eventPanelInTable1);
            event1.EventOnForm.BackColor = Color.FromArgb(128, Color.LightGray);
        }

        private void set_Time_Click(object sender, EventArgs e)
        {
            GlobalData.Current_Time1.setTimeHour = int.Parse(set_TimeH.Text);
            GlobalData.Current_Time1.setTimeMin = int.Parse(set_TimeM.Text);
            GlobalData.Current_Time1.setTimeDay = int.Parse(set_TimeD.Text);
            foreach (var event2 in GlobalData.AllEvents)
            {
                if (event2.IsOnOverlapsTable == true)
                {
                    continue;
                }
                else if (event2.Day < GlobalData.Current_Time1.setTimeDay)
                {
                    AddEventOnTable(event2, Delay_table);
                }
                else if (event2.Day == GlobalData.Current_Time1.setTimeDay && event2.endHour < GlobalData.Current_Time1.setTimeHour)
                {
                    AddEventOnTable(event2, Delay_table);
                    
                }
                else if (event2.Day == GlobalData.Current_Time1.setTimeDay && event2.endHour == GlobalData.Current_Time1.setTimeHour && event2.endMin <= GlobalData.Current_Time1.setTimeMin)
                {
                    AddEventOnTable(event2, Delay_table);
                }
            }
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    var result = MessageBox.Show("Ви хочете зберегти зміни?", "", MessageBoxButtons.YesNoCancel);
        //    switch (result)
        //    {
        //        case DialogResult.Yes:
        //            JobExchange jobExchangeInstance = new JobExchange();
        //            jobExchangeInstance.SerializeData("data.txt");
        //            break;
        //        case DialogResult.No:
        //            File.WriteAllText("data.txt", _originalData);
        //            break;
        //        case DialogResult.Cancel:
        //            e.Cancel = true;
        //            break;
        //    }
        //}







        
    }
}
