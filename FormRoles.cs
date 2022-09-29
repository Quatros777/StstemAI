using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursproject
{
    public partial class FormRoles : System.Windows.Forms.Form
    {
        public FormRoles()
        {
            InitializeComponent();
        }
        FormMssTech fmt1;
        private void button1_Click(object sender, EventArgs e)
        {
            fmt1 = new FormMssTech();
            fmt1.Show();
        }

        FormMssTech fmt2;
        private void button2_Click(object sender, EventArgs e)
        {
            fmt2 = new FormMssTech();
            fmt2.Show();
        }

        FormFlight_member ff_m;
        private void button4_Click(object sender, EventArgs e)
        {
            ff_m = new FormFlight_member();
            ff_m.Show();
        }
        Form4 ff4;
        private void button3_Click(object sender, EventArgs e)
        {
            ff4 = new Form4();
            ff4.Show();
        }
        Form2 ff2;
        private void button5_Click(object sender, EventArgs e)
        {
            ff2 = new Form2();
            ff2.Show();
        }
        Form4 fwas4;
        private void button6_Click(object sender, EventArgs e)
        {
            fwas4 = new Form4();
            fwas4.Show();
        }
    }
}
