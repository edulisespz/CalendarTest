using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarTest
{
    public partial class Form1 : Form
    {
        private string Username="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // the login part
            using (FormLogin formLogin = new FormLogin())
            {
                var result = formLogin.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Username = formLogin.ReturnUser;
                }
                else if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }

            this.label1.Text = Username;

            if (Username == "enfermera")
            {
                buttonElimina.Enabled = false;
                buttonModifica.Enabled = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToString();
        }


        

        

        
    }
}
