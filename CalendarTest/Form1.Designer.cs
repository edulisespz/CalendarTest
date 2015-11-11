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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerAddDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddNombre = new System.Windows.Forms.TextBox();
            this.buttonAddCitaOK = new System.Windows.Forms.Button();
            this.panelAddCita.SuspendLayout();
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
            this.panelAddCita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddCita.Controls.Add(this.buttonAddCitaOK);
            this.panelAddCita.Controls.Add(this.textBoxAddNombre);
            this.panelAddCita.Controls.Add(this.dateTimePickerAddDate);
            this.panelAddCita.Controls.Add(this.label3);
            this.panelAddCita.Controls.Add(this.label2);
            this.panelAddCita.Location = new System.Drawing.Point(227, 51);
            this.panelAddCita.Name = "panelAddCita";
            this.panelAddCita.Size = new System.Drawing.Size(241, 355);
            this.panelAddCita.TabIndex = 7;
            this.panelAddCita.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // dateTimePickerAddDate
            // 
            this.dateTimePickerAddDate.Location = new System.Drawing.Point(25, 109);
            this.dateTimePickerAddDate.Name = "dateTimePickerAddDate";
            this.dateTimePickerAddDate.Size = new System.Drawing.Size(193, 20);
            this.dateTimePickerAddDate.TabIndex = 2;
            // 
            // textBoxAddNombre
            // 
            this.textBoxAddNombre.Location = new System.Drawing.Point(25, 57);
            this.textBoxAddNombre.Name = "textBoxAddNombre";
            this.textBoxAddNombre.Size = new System.Drawing.Size(154, 20);
            this.textBoxAddNombre.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 457);
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
    }
}

