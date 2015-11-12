namespace CalendarTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDetalle = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonAgrega = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddCita = new System.Windows.Forms.Panel();
            this.buttonAddCitaOK = new System.Windows.Forms.Button();
            this.textBoxAddNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerAddDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDelDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDelNom = new System.Windows.Forms.TextBox();
            this.buttonDelCitaOK = new System.Windows.Forms.Button();
            this.panelDelCita = new System.Windows.Forms.Panel();
            this.panelAddCita.SuspendLayout();
            this.panelDelCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(480, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(480, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 194);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Citas para hoy:\r\n-\r\n-\r\n-";
            // 
            // buttonDetalle
            // 
            this.buttonDetalle.Location = new System.Drawing.Point(32, 372);
            this.buttonDetalle.Name = "buttonDetalle";
            this.buttonDetalle.Size = new System.Drawing.Size(169, 58);
            this.buttonDetalle.TabIndex = 2;
            this.buttonDetalle.Text = "button detalle";
            this.buttonDetalle.UseVisualStyleBackColor = true;
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(32, 290);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(169, 58);
            this.buttonElimina.TabIndex = 3;
            this.buttonElimina.Text = "button eliminar";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(32, 212);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(169, 58);
            this.buttonModifica.TabIndex = 4;
            this.buttonModifica.Text = "button modificar";
            this.buttonModifica.UseVisualStyleBackColor = true;
            // 
            // buttonAgrega
            // 
            this.buttonAgrega.Location = new System.Drawing.Point(32, 136);
            this.buttonAgrega.Name = "buttonAgrega";
            this.buttonAgrega.Size = new System.Drawing.Size(169, 58);
            this.buttonAgrega.TabIndex = 5;
            this.buttonAgrega.Text = "button agregar";
            this.buttonAgrega.UseVisualStyleBackColor = true;
            this.buttonAgrega.Click += new System.EventHandler(this.buttonAgrega_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // panelAddCita
            // 
            this.panelAddCita.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAddCita.Controls.Add(this.buttonAddCitaOK);
            this.panelAddCita.Controls.Add(this.textBoxAddNombre);
            this.panelAddCita.Controls.Add(this.dateTimePickerAddDate);
            this.panelAddCita.Controls.Add(this.label3);
            this.panelAddCita.Controls.Add(this.label2);
            this.panelAddCita.Location = new System.Drawing.Point(122, 335);
            this.panelAddCita.Name = "panelAddCita";
            this.panelAddCita.Size = new System.Drawing.Size(241, 355);
            this.panelAddCita.TabIndex = 7;
            this.panelAddCita.Visible = false;
            // 
            // buttonAddCitaOK
            // 
            this.buttonAddCitaOK.Location = new System.Drawing.Point(56, 208);
            this.buttonAddCitaOK.Name = "buttonAddCitaOK";
            this.buttonAddCitaOK.Size = new System.Drawing.Size(123, 25);
            this.buttonAddCitaOK.TabIndex = 4;
            this.buttonAddCitaOK.Text = "button1";
            this.buttonAddCitaOK.UseVisualStyleBackColor = true;
            this.buttonAddCitaOK.Click += new System.EventHandler(this.buttonAddCitaOK_Click);
            // 
            // textBoxAddNombre
            // 
            this.textBoxAddNombre.Location = new System.Drawing.Point(25, 57);
            this.textBoxAddNombre.Name = "textBoxAddNombre";
            this.textBoxAddNombre.Size = new System.Drawing.Size(154, 20);
            this.textBoxAddNombre.TabIndex = 3;
            // 
            // dateTimePickerAddDate
            // 
            this.dateTimePickerAddDate.Location = new System.Drawing.Point(25, 109);
            this.dateTimePickerAddDate.Name = "dateTimePickerAddDate";
            this.dateTimePickerAddDate.Size = new System.Drawing.Size(193, 20);
            this.dateTimePickerAddDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // dateTimePickerDelDate
            // 
            this.dateTimePickerDelDate.Location = new System.Drawing.Point(25, 109);
            this.dateTimePickerDelDate.Name = "dateTimePickerDelDate";
            this.dateTimePickerDelDate.Size = new System.Drawing.Size(193, 20);
            this.dateTimePickerDelDate.TabIndex = 2;
            // 
            // textBoxDelNom
            // 
            this.textBoxDelNom.Location = new System.Drawing.Point(25, 57);
            this.textBoxDelNom.Name = "textBoxDelNom";
            this.textBoxDelNom.Size = new System.Drawing.Size(154, 20);
            this.textBoxDelNom.TabIndex = 3;
            // 
            // buttonDelCitaOK
            // 
            this.buttonDelCitaOK.Location = new System.Drawing.Point(56, 208);
            this.buttonDelCitaOK.Name = "buttonDelCitaOK";
            this.buttonDelCitaOK.Size = new System.Drawing.Size(123, 25);
            this.buttonDelCitaOK.TabIndex = 4;
            this.buttonDelCitaOK.Text = "button1";
            this.buttonDelCitaOK.UseVisualStyleBackColor = true;
            this.buttonDelCitaOK.Click += new System.EventHandler(this.buttonDelCitaOK_Click);
            // 
            // panelDelCita
            // 
            this.panelDelCita.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDelCita.Controls.Add(this.buttonDelCitaOK);
            this.panelDelCita.Controls.Add(this.textBoxDelNom);
            this.panelDelCita.Controls.Add(this.dateTimePickerDelDate);
            this.panelDelCita.Controls.Add(this.label4);
            this.panelDelCita.Controls.Add(this.label5);
            this.panelDelCita.Location = new System.Drawing.Point(464, 335);
            this.panelDelCita.Name = "panelDelCita";
            this.panelDelCita.Size = new System.Drawing.Size(241, 355);
            this.panelDelCita.TabIndex = 8;
            this.panelDelCita.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 457);
            this.Controls.Add(this.panelDelCita);
            this.Controls.Add(this.panelAddCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgrega);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonDetalle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAddCita.ResumeLayout(false);
            this.panelAddCita.PerformLayout();
            this.panelDelCita.ResumeLayout(false);
            this.panelDelCita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonDetalle;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Button buttonAgrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAddCita;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddNombre;
        private System.Windows.Forms.Button buttonAddCitaOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelDate;
        private System.Windows.Forms.TextBox textBoxDelNom;
        private System.Windows.Forms.Button buttonDelCitaOK;
        private System.Windows.Forms.Panel panelDelCita;
    }
}

