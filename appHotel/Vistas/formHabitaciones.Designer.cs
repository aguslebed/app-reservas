namespace appHotel.Vistas
{
    partial class formHabitaciones
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
            btn_cargarHabitacion = new Button();
            pnl_botones = new Panel();
            btn_volver = new Button();
            btn_darDeBaja = new Button();
            pnl_tabla = new Panel();
            dgv_habitaciones = new DataGridView();
            pnl_titulo = new Panel();
            label1 = new Label();
            btn_modificar = new Button();
            pnl_botones.SuspendLayout();
            pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_habitaciones).BeginInit();
            pnl_titulo.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cargarHabitacion
            // 
            btn_cargarHabitacion.BackColor = Color.FromArgb(37, 37, 39);
            btn_cargarHabitacion.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_cargarHabitacion.FlatStyle = FlatStyle.Flat;
            btn_cargarHabitacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_cargarHabitacion.ForeColor = SystemColors.ButtonHighlight;
            btn_cargarHabitacion.Location = new Point(0, 74);
            btn_cargarHabitacion.Name = "btn_cargarHabitacion";
            btn_cargarHabitacion.Size = new Size(130, 55);
            btn_cargarHabitacion.TabIndex = 9;
            btn_cargarHabitacion.Text = "Cargar habitacion";
            btn_cargarHabitacion.UseVisualStyleBackColor = false;
            btn_cargarHabitacion.Click += btn_cargarHabitacion_Click;
            // 
            // pnl_botones
            // 
            pnl_botones.Controls.Add(btn_modificar);
            pnl_botones.Controls.Add(btn_volver);
            pnl_botones.Controls.Add(btn_darDeBaja);
            pnl_botones.Controls.Add(btn_cargarHabitacion);
            pnl_botones.Location = new Point(1, 0);
            pnl_botones.Name = "pnl_botones";
            pnl_botones.Size = new Size(130, 450);
            pnl_botones.TabIndex = 1;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(37, 37, 39);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_volver.ForeColor = SystemColors.ButtonHighlight;
            btn_volver.Location = new Point(0, 392);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(130, 55);
            btn_volver.TabIndex = 11;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_darDeBaja
            // 
            btn_darDeBaja.BackColor = Color.FromArgb(37, 37, 39);
            btn_darDeBaja.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_darDeBaja.FlatStyle = FlatStyle.Flat;
            btn_darDeBaja.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_darDeBaja.ForeColor = SystemColors.ButtonHighlight;
            btn_darDeBaja.Location = new Point(0, 153);
            btn_darDeBaja.Name = "btn_darDeBaja";
            btn_darDeBaja.Size = new Size(130, 55);
            btn_darDeBaja.TabIndex = 10;
            btn_darDeBaja.Text = "Dar de baja";
            btn_darDeBaja.UseVisualStyleBackColor = false;
            btn_darDeBaja.Click += btn_darDeBaja_Click;
            // 
            // pnl_tabla
            // 
            pnl_tabla.Controls.Add(dgv_habitaciones);
            pnl_tabla.Location = new Point(134, 74);
            pnl_tabla.Name = "pnl_tabla";
            pnl_tabla.Size = new Size(667, 373);
            pnl_tabla.TabIndex = 4;
            // 
            // dgv_habitaciones
            // 
            dgv_habitaciones.AllowUserToAddRows = false;
            dgv_habitaciones.AllowUserToDeleteRows = false;
            dgv_habitaciones.AllowUserToResizeRows = false;
            dgv_habitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_habitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_habitaciones.Dock = DockStyle.Fill;
            dgv_habitaciones.Location = new Point(0, 0);
            dgv_habitaciones.MultiSelect = false;
            dgv_habitaciones.Name = "dgv_habitaciones";
            dgv_habitaciones.ReadOnly = true;
            dgv_habitaciones.RowHeadersVisible = false;
            dgv_habitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_habitaciones.Size = new Size(667, 373);
            dgv_habitaciones.TabIndex = 0;
            dgv_habitaciones.VisibleChanged += dgv_habitaciones_VisibleChanged;
            // 
            // pnl_titulo
            // 
            pnl_titulo.Controls.Add(label1);
            pnl_titulo.Location = new Point(134, 0);
            pnl_titulo.Name = "pnl_titulo";
            pnl_titulo.Size = new Size(667, 66);
            pnl_titulo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(271, 15);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 0;
            label1.Text = "Habitaciones";
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(37, 37, 39);
            btn_modificar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_modificar.ForeColor = SystemColors.ButtonHighlight;
            btn_modificar.Location = new Point(0, 234);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(130, 55);
            btn_modificar.TabIndex = 12;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // formHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 39);
            ClientSize = new Size(813, 451);
            ControlBox = false;
            Controls.Add(pnl_tabla);
            Controls.Add(pnl_botones);
            Controls.Add(pnl_titulo);
            Name = "formHabitaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formHabitaciones";
            Load += formHabitaciones_Load;
            pnl_botones.ResumeLayout(false);
            pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_habitaciones).EndInit();
            pnl_titulo.ResumeLayout(false);
            pnl_titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cargarHabitacion;
        private Panel pnl_botones;
        private Button btn_volver;
        private Button btn_darDeBaja;
        private Panel pnl_tabla;
        private DataGridView dgv_habitaciones;
        private Panel pnl_titulo;
        private Label label1;
        private Button btn_modificar;
    }
}