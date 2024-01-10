namespace appHotel.Vistas
{
    partial class formEmpleados
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
            pnl_botones = new Panel();
            btn_volver = new Button();
            btn_darDeBaja = new Button();
            btn_cargarEmpleado = new Button();
            pnl_titulo = new Panel();
            label1 = new Label();
            pnl_tabla = new Panel();
            dgv_empleados = new DataGridView();
            btn_modificar = new Button();
            pnl_botones.SuspendLayout();
            pnl_titulo.SuspendLayout();
            pnl_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_empleados).BeginInit();
            SuspendLayout();
            // 
            // pnl_botones
            // 
            pnl_botones.Controls.Add(btn_modificar);
            pnl_botones.Controls.Add(btn_volver);
            pnl_botones.Controls.Add(btn_darDeBaja);
            pnl_botones.Controls.Add(btn_cargarEmpleado);
            pnl_botones.Location = new Point(0, 0);
            pnl_botones.Name = "pnl_botones";
            pnl_botones.Size = new Size(130, 457);
            pnl_botones.TabIndex = 0;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(37, 37, 39);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_volver.ForeColor = SystemColors.ButtonHighlight;
            btn_volver.Location = new Point(0, 402);
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
            btn_darDeBaja.Location = new Point(0, 163);
            btn_darDeBaja.Name = "btn_darDeBaja";
            btn_darDeBaja.Size = new Size(130, 55);
            btn_darDeBaja.TabIndex = 10;
            btn_darDeBaja.Text = "Dar de baja";
            btn_darDeBaja.UseVisualStyleBackColor = false;
            btn_darDeBaja.Click += btn_darDeBaja_Click;
            // 
            // btn_cargarEmpleado
            // 
            btn_cargarEmpleado.BackColor = Color.FromArgb(37, 37, 39);
            btn_cargarEmpleado.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_cargarEmpleado.FlatStyle = FlatStyle.Flat;
            btn_cargarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_cargarEmpleado.ForeColor = SystemColors.ButtonHighlight;
            btn_cargarEmpleado.Location = new Point(0, 84);
            btn_cargarEmpleado.Name = "btn_cargarEmpleado";
            btn_cargarEmpleado.Size = new Size(130, 55);
            btn_cargarEmpleado.TabIndex = 9;
            btn_cargarEmpleado.Text = "Cargar empleado";
            btn_cargarEmpleado.UseVisualStyleBackColor = false;
            btn_cargarEmpleado.Click += btn_cargarEmpleado_Click;
            // 
            // pnl_titulo
            // 
            pnl_titulo.Controls.Add(label1);
            pnl_titulo.Location = new Point(136, 12);
            pnl_titulo.Name = "pnl_titulo";
            pnl_titulo.Size = new Size(667, 66);
            pnl_titulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(271, 15);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // pnl_tabla
            // 
            pnl_tabla.Controls.Add(dgv_empleados);
            pnl_tabla.Location = new Point(136, 84);
            pnl_tabla.Name = "pnl_tabla";
            pnl_tabla.Size = new Size(667, 373);
            pnl_tabla.TabIndex = 2;
            // 
            // dgv_empleados
            // 
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.AllowUserToDeleteRows = false;
            dgv_empleados.AllowUserToResizeRows = false;
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_empleados.Dock = DockStyle.Fill;
            dgv_empleados.Location = new Point(0, 0);
            dgv_empleados.MultiSelect = false;
            dgv_empleados.Name = "dgv_empleados";
            dgv_empleados.ReadOnly = true;
            dgv_empleados.RowHeadersVisible = false;
            dgv_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_empleados.Size = new Size(667, 373);
            dgv_empleados.TabIndex = 0;
            dgv_empleados.VisibleChanged += dgv_empleados_VisibleChanged;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(37, 37, 39);
            btn_modificar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_modificar.ForeColor = SystemColors.ButtonHighlight;
            btn_modificar.Location = new Point(0, 240);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(130, 55);
            btn_modificar.TabIndex = 12;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // formEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 39);
            ClientSize = new Size(900, 507);
            ControlBox = false;
            Controls.Add(pnl_tabla);
            Controls.Add(pnl_botones);
            Controls.Add(pnl_titulo);
            Name = "formEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += formEmpleados_Load;
            pnl_botones.ResumeLayout(false);
            pnl_titulo.ResumeLayout(false);
            pnl_titulo.PerformLayout();
            pnl_tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_empleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_botones;
        private Button btn_darDeBaja;
        private Button btn_cargarEmpleado;
        private Panel pnl_titulo;
        private Panel pnl_tabla;
        private DataGridView dgv_empleados;
        private Button btn_volver;
        private Label label1;
        private Button btn_modificar;
    }
}