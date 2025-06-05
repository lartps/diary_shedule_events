using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

        }

        // нужно разделить создание нового ивента и ред старого чтоб подставлять предыдущ значения

        //public List<Program.Event> Events = new(); // list of all created events


        // unrequired text change

        private void NameChange_TextChanged(object sender, EventArgs e)
        {


            // бмля тут же еще нужно знать какой ивент ред
        }
        private void DescriptionChange_TextChanged(object sender, EventArgs e)
        {
            //Program.Event1.Description = DescriptionChange.Text;
        }

        private void loc_TextChanged(object sender, EventArgs e)
        {
            string input = loc.Text;

        }

        private void DetailsChange_TextChanged(object sender, EventArgs e)
        {
            string input = DetailsChange.Text;
        }

        // change time

        // ok button
        private void event_edit_btn_ok_Click(object sender, EventArgs e)
        {
            // TableLayoutPanel tableLayout = new TableLayoutPanel();

        }

        private void justText_Click(object sender, EventArgs e)
        {

        }
    }
}
