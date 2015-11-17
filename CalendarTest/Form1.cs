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


            panelAddCita.Location = new Point(227, 51);
            panelDelCita.Location = new Point(227, 51);



            ///test delete later
            ///
            Cita test =new Cita();
            test.fechaCita=DateTime.Today.Date;
            test.nombre="aaa";
            listCitas.Add(test);

            test = new Cita();
            test.fechaCita = DateTime.Today.Date;
            test.nombre = "bbb";
            listCitas.Add(test);

            test = new Cita();
            test.fechaCita = DateTime.Today.Date;
            test.nombre = "ccc";
            listCitas.Add(test);

            test = new Cita();
            test.fechaCita = DateTime.Today.Date.AddDays(1);
            test.nombre = "ddd";
            listCitas.Add(test);
            ///
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           

            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            bool _encontrado = false;

            textBox1.Text = "";

            foreach (Cita elemento in listCitas)
            {
                if (elemento.fechaCita == selectedDate)
                {
                    _encontrado = true;
                    textBox1.Text =string.Concat(textBox1.Text,
                        elemento.nombre + " " + elemento.fechaCita.ToString() + Environment.NewLine);
                }
            }

            if (_encontrado == false)
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

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            textBoxDelNom.Text = "";
            panelDelCita.Visible = true;
        }


        private void buttonDelCitaOK_Click(object sender, EventArgs e)
        {
            DellListCitas();
        }

        private void DellListCitas()
        {

            Cita auxcita = listCitas.FirstOrDefault(
                O => O.nombre == textBoxDelNom.Text && O.fechaCita == dateTimePickerDelDate.Value.Date
                    );


            if (auxcita != null)
            {
                listCitas.Remove(auxcita);
            }
            else
            {
                MessageBox.Show("No se encuentra");
            }

            panelDelCita.Visible = false;
        }



        private void buttonModifica_Click(object sender, EventArgs e)
        {
            textBoxDelNom.Text = "";
            panelDelCita.Visible = true;

            buttonDelCitaOK.Visible = false;
            buttonUpdate.Visible = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonDelCitaOK.Visible = true;
            buttonUpdate.Visible = false;

            DellListCitas();

            textBoxAddNombre.Text = "";
            panelAddCita.Visible = true;
        }
        

        

        
    }
}
