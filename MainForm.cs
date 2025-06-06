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
            //Timer.Text = DateTime.Now.ToShortTimeString();
            //timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (var j in ) {
            //    if (DateTime.Now.Day == j)
            //    {
            //        j.BackColor = Color.PaleGoldenrod;
            //    }
            //}
            //SetupTable();


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
                this.Close();
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

    }
}
