namespace appHotel.Vistas
{
    partial class formCargarEmpleados
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
            lbl_numHabitacion = new Label();
            txt_nombre = new TextBox();
            label1 = new Label();
            txt_apellido = new TextBox();
            label2 = new Label();
            txt_dni = new TextBox();
            label3 = new Label();
            txt_area = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btn_volver = new Button();
            btn_guardar = new Button();
            dtp_horaEntrada = new DateTimePicker();
            dtp_horaSalida = new DateTimePicker();
            SuspendLayout();
            // 
            // lbl_numHabitacion
            // 
            lbl_numHabitacion.AutoSize = true;
            lbl_numHabitacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numHabitacion.ForeColor = Color.White;
            lbl_numHabitacion.Location = new Point(36, 45);
            lbl_numHabitacion.Name = "lbl_numHabitacion";
            lbl_numHabitacion.Size = new Size(68, 21);
            lbl_numHabitacion.TabIndex = 3;
            lbl_numHabitacion.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(50, 50, 50);
            txt_nombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.ForeColor = Color.White;
            txt_nombre.Location = new Point(207, 42);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(84, 29);
            txt_nombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 80);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 5;
            label1.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FromArgb(50, 50, 50);
            txt_apellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_apellido.ForeColor = Color.White;
            txt_apellido.Location = new Point(207, 77);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(84, 29);
            txt_apellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 115);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 7;
            label2.Text = "DNI";
            // 
            // txt_dni
            // 
            txt_dni.BackColor = Color.FromArgb(50, 50, 50);
            txt_dni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_dni.ForeColor = Color.White;
            txt_dni.Location = new Point(207, 112);
            txt_dni.MaxLength = 9;
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(84, 29);
            txt_dni.TabIndex = 6;
            txt_dni.KeyPress += txt_dni_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 150);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 9;
            label3.Text = "Area";
            // 
            // txt_area
            // 
            txt_area.BackColor = Color.FromArgb(50, 50, 50);
            txt_area.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_area.ForeColor = Color.White;
            txt_area.Location = new Point(207, 147);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(84, 29);
            txt_area.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 185);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 11;
            label4.Text = "Hora de entrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 220);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 13;
            label5.Text = "Hora de salida";
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(37, 37, 39);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_volver.ForeColor = SystemColors.ButtonHighlight;
            btn_volver.Location = new Point(22, 308);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(103, 49);
            btn_volver.TabIndex = 15;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(37, 37, 39);
            btn_guardar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_guardar.ForeColor = SystemColors.ButtonHighlight;
            btn_guardar.Location = new Point(242, 308);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(103, 49);
            btn_guardar.TabIndex = 14;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // dtp_horaEntrada
            // 
            dtp_horaEntrada.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_horaEntrada.Format = DateTimePickerFormat.Custom;
            dtp_horaEntrada.Location = new Point(207, 185);
            dtp_horaEntrada.Name = "dtp_horaEntrada";
            dtp_horaEntrada.Size = new Size(84, 23);
            dtp_horaEntrada.TabIndex = 16;
            // 
            // dtp_horaSalida
            // 
            dtp_horaSalida.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_horaSalida.Format = DateTimePickerFormat.Custom;
            dtp_horaSalida.Location = new Point(207, 220);
            dtp_horaSalida.Name = "dtp_horaSalida";
            dtp_horaSalida.Size = new Size(84, 23);
            dtp_horaSalida.TabIndex = 17;
            // 
            // formCargarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 39);
            ClientSize = new Size(357, 365);
            Controls.Add(dtp_horaSalida);
            Controls.Add(dtp_horaEntrada);
            Controls.Add(btn_volver);
            Controls.Add(btn_guardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_area);
            Controls.Add(label2);
            Controls.Add(txt_dni);
            Controls.Add(label1);
            Controls.Add(txt_apellido);
            Controls.Add(lbl_numHabitacion);
            Controls.Add(txt_nombre);
            Name = "formCargarEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCargarEmpleados";
            Load += formCargarEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_numHabitacion;
        private TextBox txt_nombre;
        private Label label1;
        private TextBox txt_apellido;
        private Label label2;
        private TextBox txt_dni;
        private Label label3;
        private TextBox txt_area;
        private Label label4;
        private Label label5;
        private Button btn_volver;
        private Button btn_guardar;
        private DateTimePicker dtp_horaEntrada;
        private DateTimePicker dtp_horaSalida;
    }
}