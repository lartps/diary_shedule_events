using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace weekly_planer
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DayChange.Value = DateTime.Now.Day;
            DayChange.Minimum = DayChange.Value;

            hourStartChange.Value = DateTime.Now.Hour;
            hourEndChange.Value = hourStartChange.Value + 1;
            hourStartChange.Minimum = hourStartChange.Value;
            hourEndChange.Minimum = hourStartChange.Value;

            minStartChange.Value = DateTime.Now.Minute;
            minEndChange.Value = minStartChange.Value;
            minStartChange.Minimum = minStartChange.Value;

            if (hourStartChange.Value == hourEndChange.Value && minStartChange.Value + 30 < 60)
            {
                minEndChange.Minimum = minStartChange.Value + 30;
                minEndChange.Value = minEndChange.Minimum;
            } else if (hourStartChange.Value == hourEndChange.Value)
            {
                hourEndChange.Minimum = hourStartChange.Value + 1;
                hourEndChange.Value = hourEndChange.Minimum;
                minEndChange.Minimum = (minStartChange.Value + 30) - 60;
                minEndChange.Value = minEndChange.Minimum;
            }






        }











        private void Form2_Paint(object sender, PaintEventArgs e)
        {

        }

        // нужно разделить создание нового ивента и ред старого чтоб подставлять предыдущ значения
        // бмля тут же еще нужно знать какой ивент ред

        //public List<Program.Event> Events = new(); // list of all created events



        // ok button
        private void event_edit_btn_ok_Click(object sender, EventArgs e)
        {
            string name = NameChange.Text;
            string descr = DescriptionChange.Text;
            string location = loc.Text;
            string det = DetailsChange.Text;

            int day = (int)DayChange.Value;
            int sHour = (int)hourStartChange.Value;
            int sMin = (int)minStartChange.Value;
            int eHour = (int)hourEndChange.Value;
            int eMin = (int)minEndChange.Value;

            try
            {
                Event.MyEvent newEvent = new MyEvent(name, day, sHour, sMin, eHour, eMin, descr, location, det);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
            }
            var[] vars = new string[] { Form1.mon, tue, };






        }


    }
}
