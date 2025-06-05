using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weekly_planer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Timer.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchBox.Text = "Пошук";
            searchBox.ForeColor = Color.Gray;

            searchBox.Enter += searchBox_Enter;
            searchBox.Leave += searchBox_Leave;
            ////this.Add_Event_Btn.Click += new System.EventHandler(this.Add_Event_Btn_Click);

            for (int i = 2; i < 8; i++) {
                //foreach (var j in )
                if (DateTime.Now.Day == i)
                {
                    monday.BackColor = Color.PaleGoldenrod;
                }
            }

            //int startHour = 5;
            //int endHour = 24; // До 00:00

            //timeTable.ColumnCount = 1;
            //timeTable.RowCount = endHour - startHour;

            //timeTable.RowStyles.Clear();

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

            // List<Event1> list = new(); // для сохранения данных по всем делам а потом эту инфу тупо тока сохранять и каждый раз отрисовывать при новом запуске проги
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                // save
                this.Close(); // Закрыть форму
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //g.DrawImage(, 0, 0);

        }



        



        //private void searchBox_Enter(object sender, EventArgs e)
        //{
        //    if (searchBox_TextChanged.Text == "Пошук")
        //    {
        //        searchBox.Text = "";
        //        searchBox.ForeColor = Color.Black;
        //    }
        //}

        //private void searchBox_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(searchBox.Text))
        //    {
        //        searchBox.Text = "Пошук";
        //        searchBox.ForeColor = Color.Gray;
        //    }
        //}

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToShortTimeString();
            //Refresh();
        }

        private void Add_Event_Btn_Click(object sender, EventArgs e)
        {
            EventForm eventForm1 = new EventForm();
            eventForm1.ShowDialog();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                // save
                this.Close();
            }
        }

        public void timeTable_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {

        }

        private void searchBox_Leave(object sender, EventArgs e)
        {

        }

        //public partial class EventBlockControl : UserControl
        //{
        //    public string EventTitle { get; set; }
        //    public DateTime StartTime { get; set; }
        //    public DateTime EndTime { get; set; }

        //    public event Action<EventBlockControl> OnBlockClicked;

        //    public EventBlockControl(string title, DateTime start, DateTime end)
        //    {
        //        EventTitle = title;
        //        StartTime = start;
        //        EndTime = end;

        //        //lblTitle.Text = EventTitle;

        //        //btnDelete.Click += (s, e) => OnDeleteClicked?.Invoke(this);
        //        //this.Click += (s, e) => OnBlockClicked?.Invoke(this);

        //        // Forward clicks from child controls to parent
        //        foreach (Control ctrl in this.Controls)
        //            ctrl.Click += (s, e) => OnBlockClicked?.Invoke(this);
        //    }

        //    public void ResizeBasedOnDuration(int pixelsPerHour)
        //    {
        //        var duration = EndTime - StartTime;
        //        int height = (int)(duration.TotalHours * pixelsPerHour);
        //        this.Height = height;

                
        //    }
        //}

        


        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void overlaps_flowLayoutPanel_Scroll(object sender, ScrollEventArgs e)
        {
            //overlaps_flowLayoutPanel.Controls.Add(e);
        }
    }
}
