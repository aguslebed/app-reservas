namespace appHotel.Vistas
{
    partial class formMenu
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
            panel1 = new Panel();
            button3 = new Button();
            btn_reservas = new Button();
            btn_empleados = new Button();
            btn_habitaciones = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_reservas);
            panel1.Controls.Add(btn_empleados);
            panel1.Controls.Add(btn_habitaciones);
            panel1.Location = new Point(18, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 305);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(37, 37, 39);
            button3.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(580, 13);
            button3.Name = "button3";
            button3.Size = new Size(173, 111);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // btn_reservas
            // 
            btn_reservas.BackColor = Color.FromArgb(37, 37, 39);
            btn_reservas.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_reservas.FlatStyle = FlatStyle.Flat;
            btn_reservas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_reservas.ForeColor = SystemColors.ButtonHighlight;
            btn_reservas.Location = new Point(392, 13);
            btn_reservas.Name = "btn_reservas";
            btn_reservas.Size = new Size(173, 111);
            btn_reservas.TabIndex = 2;
            btn_reservas.Text = "Reservas";
            btn_reservas.UseVisualStyleBackColor = false;
            btn_reservas.Click += btn_reservas_Click;
            // 
            // btn_empleados
            // 
            btn_empleados.BackColor = Color.FromArgb(37, 37, 39);
            btn_empleados.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_empleados.FlatStyle = FlatStyle.Flat;
            btn_empleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_empleados.ForeColor = SystemColors.ButtonHighlight;
            btn_empleados.Location = new Point(201, 13);
            btn_empleados.Name = "btn_empleados";
            btn_empleados.Size = new Size(173, 111);
            btn_empleados.TabIndex = 1;
            btn_empleados.Text = "Empleados";
            btn_empleados.UseVisualStyleBackColor = false;
            btn_empleados.Click += btn_empleados_Click;
            // 
            // btn_habitaciones
            // 
            btn_habitaciones.BackColor = Color.FromArgb(37, 37, 39);
            btn_habitaciones.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_habitaciones.FlatStyle = FlatStyle.Flat;
            btn_habitaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_habitaciones.ForeColor = SystemColors.ButtonHighlight;
            btn_habitaciones.Location = new Point(10, 13);
            btn_habitaciones.Name = "btn_habitaciones";
            btn_habitaciones.Size = new Size(173, 111);
            btn_habitaciones.TabIndex = 0;
            btn_habitaciones.Text = "Habitaciones";
            btn_habitaciones.UseVisualStyleBackColor = false;
            btn_habitaciones.Click += btn_habitaciones_Click;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "formMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu principal";
            Load += formMenu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Button btn_reservas;
        private Button btn_empleados;
        private Button btn_habitaciones;
    }
}