namespace appHotel.Vistas
{
    partial class formReservas
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
            btn_modificar = new Button();
            btn_volver = new Button();
            btn_cancelarReserva = new Button();
            btn_cargarReserva = new Button();
            label1 = new Label();
            pnl_titulo = new Panel();
            flp_reservas = new FlowLayoutPanel();
            pnl_botones.SuspendLayout();
            pnl_titulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_botones
            // 
            pnl_botones.Controls.Add(btn_modificar);
            pnl_botones.Controls.Add(btn_volver);
            pnl_botones.Controls.Add(btn_cancelarReserva);
            pnl_botones.Controls.Add(btn_cargarReserva);
            pnl_botones.Location = new Point(0, 2);
            pnl_botones.Name = "pnl_botones";
            pnl_botones.Size = new Size(130, 450);
            pnl_botones.TabIndex = 2;
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
            // btn_cancelarReserva
            // 
            btn_cancelarReserva.BackColor = Color.FromArgb(37, 37, 39);
            btn_cancelarReserva.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_cancelarReserva.FlatStyle = FlatStyle.Flat;
            btn_cancelarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_cancelarReserva.ForeColor = SystemColors.ButtonHighlight;
            btn_cancelarReserva.Location = new Point(0, 153);
            btn_cancelarReserva.Name = "btn_cancelarReserva";
            btn_cancelarReserva.Size = new Size(130, 55);
            btn_cancelarReserva.TabIndex = 10;
            btn_cancelarReserva.Text = "Cancelar reserva";
            btn_cancelarReserva.UseVisualStyleBackColor = false;
            // 
            // btn_cargarReserva
            // 
            btn_cargarReserva.BackColor = Color.FromArgb(37, 37, 39);
            btn_cargarReserva.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btn_cargarReserva.FlatStyle = FlatStyle.Flat;
            btn_cargarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_cargarReserva.ForeColor = SystemColors.ButtonHighlight;
            btn_cargarReserva.Location = new Point(0, 74);
            btn_cargarReserva.Name = "btn_cargarReserva";
            btn_cargarReserva.Size = new Size(130, 55);
            btn_cargarReserva.TabIndex = 9;
            btn_cargarReserva.Text = "Cargar reserva";
            btn_cargarReserva.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(271, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 0;
            label1.Text = "Reservas";
            // 
            // pnl_titulo
            // 
            pnl_titulo.Controls.Add(label1);
            pnl_titulo.Location = new Point(130, 2);
            pnl_titulo.Name = "pnl_titulo";
            pnl_titulo.Size = new Size(673, 66);
            pnl_titulo.TabIndex = 4;
            // 
            // flp_reservas
            // 
            flp_reservas.Location = new Point(131, 71);
            flp_reservas.Name = "flp_reservas";
            flp_reservas.Size = new Size(667, 377);
            flp_reservas.TabIndex = 5;
            // 
            // formReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 39);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(flp_reservas);
            Controls.Add(pnl_titulo);
            Controls.Add(pnl_botones);
            Name = "formReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas";
            pnl_botones.ResumeLayout(false);
            pnl_titulo.ResumeLayout(false);
            pnl_titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_botones;
        private Button btn_modificar;
        private Button btn_volver;
        private Button btn_cancelarReserva;
        private Button btn_cargarReserva;
        private Label label1;
        private Panel pnl_titulo;
        private FlowLayoutPanel flp_reservas;
    }
}