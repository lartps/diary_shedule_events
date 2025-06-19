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


            //SetupTable();

            DayOfWeek today = DateTime.Now.AddDays(DayChange.Value).DayOfWeek;



            //for (int i = 0; i < timeTable.RowCount; i++)
            //{
            //    timeTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // высота строки

            //    Label label = new Label();
            //    label.Dock = DockStyle.Fill;
            //    label.TextAlign = ContentAlignment.MiddleCenter;

            //    int hour = startHour + i;
            //    label.Text = (hour < 10 ? "0" : "") + hour + ":00";

            //    timeTable.Controls.Add(label, 0, i);
            //}


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

        // Добавляем блок дела на таблицу недели
        public void AddPanelToTable(MyEvent e1)
        {

            int hourHeight = 32; // высота одного часа в пикселях
            int dayWidth = 118;  // фиксированая ширина дня
            int duration = e1.Duration(e1);
            int y = 16 + hourHeight * (e1.startHour - 5);
            int height = (duration / 60) * hourHeight + ((duration % 60) / 30) * (hourHeight / 2);

            string nameP = e1.Name + "_panel";
            string nameL = e1.Name + "_label";
            string nameB = e1.Name + "_button";

            var days_tables = new[]
            {
                monday,
                tuesday,
                wednesday,
                thursday,
                friday,
                saturday,
                sunday
            };

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = (int)e1.Day;
            DateTime eventDate = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = eventDate.DayOfWeek;

            int index = (int)dayOfWeek; // Sunday = 0 ... Saturday = 6

            days_tables[index]. = ;

            Panel eventPanel = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(dayWidth, height),
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
                Name = nameP,
                Form1.nameP.Controls.Add(Form1.nameL),
                Form1.nameP.Controls.Add(Form1.nameB),
                resources.ApplyResources(Form1.nameP, nameP)
            };

            Label lbl = new Label
            {
                Text = e1.Name,
                Dock = DockStyle.Top,
                Name = nameL,
                BackColor = Color.Transparent
            };

            Button btnDelete = new Button
            {
                BackColor = Color.Transparent,
                Name = nameB,
                Dock = DockStyle.Right,
                Size = new Size(26, 26),
                Click += new EventHandler(Form1.nameB_Click),
                resources.ApplyResources(Form1.nameB, nameB),
                Image = global::weekly_planer.Resource2.delete2,
                UseVisualStyleBackColor = false
            };

            eventPanel.Controls.Add(lbl);
            eventPanel.Controls.Add(btnDelete);
            days_tables[index].Controls.Add(eventPanel);
        }
        }


        //private void SetupTable()
        //{
        //    var table = new TableLayoutPanel
        //    {
        //        Dock = DockStyle.Fill,
        //        RowCount = 20,
        //        ColumnCount = 1,
        //    };

        //    for (int i = 0; i < 3; i++)
        //    {
        //        table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 20));
        //    }

        //    table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));


        //    this.Controls.Add(table);
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


        }



        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    Timer.Text = DateTime.Now.ToShortTimeString();
        //    //Refresh();
        //}

        private void Add_Event_Btn_Click(object sender, EventArgs e)
        {
            EventForm eventForm1 = new EventForm();
            eventForm1.ShowDialog();
            if (eventForm1.ShowDialog() == DialogResult.OK)
            {
                // add new panel to table



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

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
