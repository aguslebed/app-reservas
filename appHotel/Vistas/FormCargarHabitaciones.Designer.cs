namespace appHotel.Vistas
{
    partial class FormCargarHabitaciones
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
            txt_numeroHabitacion = new TextBox();
            lbl_numHabitacion = new Label();
            label1 = new Label();
            cb_aire = new CheckBox();
            label2 = new Label();
            btn_guardar = new Button();
            btn_volver = new Button();
            label3 = new Label();
            num_cantPersonas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_cantPersonas).BeginInit();
            SuspendLayout();
            // 
            // txt_numeroHabitacion
            // 
            txt_numeroHabitacion.BackColor = Color.FromArgb(50, 50, 50);
            txt_numeroHabitacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_numeroHabitacion.ForeColor = Color.White;
            txt_numeroHabitacion.Location = new Point(202, 87);
            txt_numeroHabitacion.Name = "txt_numeroHabitacion";
            txt_numeroHabitacion.Size = new Size(84, 29);
            txt_numeroHabitacion.TabIndex = 0;
            txt_numeroHabitacion.KeyPress += txt_numeroHabitacion_KeyPress;
            // 
            // lbl_numHabitacion
            // 
            lbl_numHabitacion.AutoSize = true;
            lbl_numHabitacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numHabitacion.ForeColor = Color.White;
            lbl_numHabitacion.Location = new Point(31, 90);
            lbl_numHabitacion.Name = "lbl_numHabitacion";
            lbl_numHabitacion.Size = new Size(165, 21);
            lbl_numHabitacion.TabIndex = 1;
            lbl_numHabitacion.Text = "Numero de habitacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 163);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 2;
            label1.Text = "Cantidad de personas";
            // 
            // cb_aire
            // 
            cb_aire.AutoSize = true;
            cb_aire.Font = new Font("Segoe UI", 12F);
            cb_aire.ForeColor = Color.White;
            cb_aire.Location = new Point(202, 239);
            cb_aire.Name = "cb_aire";
            cb_aire.Size = new Size(15, 14);
            cb_aire.TabIndex = 5;
            cb_aire.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 232);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 6;
            label2.Text = "Aire acondicionado";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(37, 37, 39);
            btn_guardar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_guardar.ForeColor = SystemColors.ButtonHighlight;
            btn_guardar.Location = new Point(251, 311);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(103, 49);
            btn_guardar.TabIndex = 7;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(37, 37, 39);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_volver.ForeColor = SystemColors.ButtonHighlight;
            btn_volver.Location = new Point(31, 311);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(103, 49);
            btn_volver.TabIndex = 8;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 18);
            label3.Name = "label3";
            label3.Size = new Size(230, 30);
            label3.TabIndex = 9;
            label3.Text = "Cargar una habitacion";
            // 
            // num_cantPersonas
            // 
            num_cantPersonas.BackColor = Color.FromArgb(50, 50, 50);
            num_cantPersonas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_cantPersonas.ForeColor = Color.White;
            num_cantPersonas.Location = new Point(202, 161);
            num_cantPersonas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_cantPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_cantPersonas.Name = "num_cantPersonas";
            num_cantPersonas.Size = new Size(45, 29);
            num_cantPersonas.TabIndex = 10;
            num_cantPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormCargarHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 39);
            ClientSize = new Size(381, 369);
            ControlBox = false;
            Controls.Add(num_cantPersonas);
            Controls.Add(label3);
            Controls.Add(btn_volver);
            Controls.Add(btn_guardar);
            Controls.Add(label2);
            Controls.Add(cb_aire);
            Controls.Add(label1);
            Controls.Add(lbl_numHabitacion);
            Controls.Add(txt_numeroHabitacion);
            Name = "FormCargarHabitaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCargarHabitaciones";
            Load += FormCargarHabitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)num_cantPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_numeroHabitacion;
        private Label lbl_numHabitacion;
        private Label label1;
        private CheckBox cb_aire;
        private Label label2;
        private Button btn_guardar;
        private Button btn_volver;
        private Label label3;
        private NumericUpDown num_cantPersonas;
    }
}