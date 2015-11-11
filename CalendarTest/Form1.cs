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

        List<Cita> listCitas = new List<Cita>();

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

            this.label1.Text = "Welcome "+ Username;

            if (Username == "enfermera")
            {
                buttonElimina.Enabled = false;
                buttonModifica.Enabled = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           

            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            Cita selecDateCita = listCitas.FirstOrDefault(Obj => Obj.fechaCita == selectedDate);

            if (selecDateCita != null)
            {
                textBox1.Text = selecDateCita.nombre + " " + selecDateCita.fechaCita.ToString();
            }
            else
            {
                textBox1.Text = "no hay citas registradas";
            }
            
            
        }

        private void buttonAgrega_Click(object sender, EventArgs e)
        {
            
            textBoxAddNombre.Text = "";
            panelAddCita.Visible = true;

        }


        private void buttonAddCitaOK_Click(object sender, EventArgs e)
        {
            AddListCitas();
        }


        private void AddListCitas()
        {
            Cita auxcita = new Cita();

            auxcita.nombre= textBoxAddNombre.Text;
            auxcita.fechaCita = dateTimePickerAddDate.Value.Date;

            listCitas.Add(auxcita);

            panelAddCita.Visible = false;
        }

        

        

        

        
    }
}
