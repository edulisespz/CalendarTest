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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        bool AccesGranted = false;
        public string ReturnUser { get; set; }
        public string ReturnPass { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser_name.Text == "doctor" && textBoxPassWord.Text == "1234")
            {
                AccesGranted = true;
            }
            else if (textBoxUser_name.Text == "enfermera" && textBoxPassWord.Text == "5678")
            {
                AccesGranted = true;
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }

            if(AccesGranted==true)
            {
                this.ReturnUser = textBoxUser_name.Text;
                this.ReturnPass = textBoxPassWord.Text;

                this.DialogResult = DialogResult.OK;
                

                AccesGranted = true;
                this.Close();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AccesGranted == false)
            {
                this.DialogResult = DialogResult.Abort;
            }
            
        }

        
    }
}
