namespace pryFerreyraSP2
{
    partial class frmSP2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSP2));
            gbCabania = new GroupBox();
            txtDias = new NumericUpDown();
            lblTipo = new Label();
            lblPersonas = new Label();
            lblDias = new Label();
            cmbPersonas = new ComboBox();
            cmbTipo = new ComboBox();
            gbAdicionales = new GroupBox();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            gbPago = new GroupBox();
            lblTarjeta = new Label();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            cmbTarjeta = new ComboBox();
            gbReservas = new GroupBox();
            txtTelefono = new MaskedTextBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dgvDatos = new DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colPersonas = new DataGridViewTextBoxColumn();
            colDias = new DataGridViewTextBoxColumn();
            gbCabania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDias).BeginInit();
            gbAdicionales.SuspendLayout();
            gbPago.SuspendLayout();
            gbReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // gbCabania
            // 
            gbCabania.BackColor = Color.White;
            gbCabania.Controls.Add(txtDias);
            gbCabania.Controls.Add(lblTipo);
            gbCabania.Controls.Add(lblPersonas);
            gbCabania.Controls.Add(lblDias);
            gbCabania.Controls.Add(cmbPersonas);
            gbCabania.Controls.Add(cmbTipo);
            gbCabania.Location = new Point(12, 12);
            gbCabania.Name = "gbCabania";
            gbCabania.Size = new Size(534, 84);
            gbCabania.TabIndex = 0;
            gbCabania.TabStop = false;
            gbCabania.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(404, 28);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(120, 23);
            txtDias.TabIndex = 18;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(24, 32);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 16;
            lblTipo.Text = "Tipo";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(186, 32);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 15;
            lblPersonas.Text = "Personas";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(369, 32);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 14;
            lblDias.Text = "Días";
            // 
            // cmbPersonas
            // 
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(245, 28);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(98, 23);
            cmbPersonas.TabIndex = 13;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(61, 28);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(98, 23);
            cmbTipo.TabIndex = 9;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // gbAdicionales
            // 
            gbAdicionales.BackColor = Color.White;
            gbAdicionales.Controls.Add(chkTelevisor);
            gbAdicionales.Controls.Add(chkHeladera);
            gbAdicionales.Controls.Add(chkCocina);
            gbAdicionales.Location = new Point(12, 102);
            gbAdicionales.Name = "gbAdicionales";
            gbAdicionales.Size = new Size(194, 147);
            gbAdicionales.TabIndex = 1;
            gbAdicionales.TabStop = false;
            gbAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(15, 92);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(71, 19);
            chkTelevisor.TabIndex = 6;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(15, 65);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 7;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(15, 38);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 8;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // gbPago
            // 
            gbPago.BackColor = Color.White;
            gbPago.Controls.Add(lblTarjeta);
            gbPago.Controls.Add(optTarjeta);
            gbPago.Controls.Add(optEfectivo);
            gbPago.Controls.Add(cmbTarjeta);
            gbPago.Location = new Point(212, 102);
            gbPago.Name = "gbPago";
            gbPago.Size = new Size(334, 147);
            gbPago.TabIndex = 2;
            gbPago.TabStop = false;
            gbPago.Text = "Formas de Pago";
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(163, 86);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(41, 15);
            lblTarjeta.TabIndex = 17;
            lblTarjeta.Text = "Tarjeta";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(24, 67);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(59, 19);
            optTarjeta.TabIndex = 4;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(24, 40);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 5;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Location = new Point(163, 104);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(143, 23);
            cmbTarjeta.TabIndex = 10;
            // 
            // gbReservas
            // 
            gbReservas.BackColor = Color.White;
            gbReservas.Controls.Add(txtTelefono);
            gbReservas.Controls.Add(lblTelefono);
            gbReservas.Controls.Add(lblNombre);
            gbReservas.Controls.Add(txtNombre);
            gbReservas.Location = new Point(12, 269);
            gbReservas.Name = "gbReservas";
            gbReservas.Size = new Size(534, 147);
            gbReservas.TabIndex = 2;
            gbReservas.TabStop = false;
            gbReservas.Text = "Titular de la Reserva";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(76, 92);
            txtTelefono.Mask = "(999)000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(441, 23);
            txtTelefono.TabIndex = 20;
            txtTelefono.MaskInputRejected += txtTelefono_MaskInputRejected;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(18, 95);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 19;
            lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(437, 23);
            txtNombre.TabIndex = 13;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(471, 422);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 25);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(381, 422);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 25);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colTipo, colPersonas, colDias });
            dgvDatos.Location = new Point(563, 11);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(337, 405);
            dgvDatos.TabIndex = 5;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colPersonas
            // 
            colPersonas.HeaderText = "Personas";
            colPersonas.Name = "colPersonas";
            colPersonas.ReadOnly = true;
            // 
            // colDias
            // 
            colDias.HeaderText = "Dias";
            colDias.Name = "colDias";
            colDias.ReadOnly = true;
            // 
            // frmSP2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(922, 470);
            Controls.Add(dgvDatos);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(gbReservas);
            Controls.Add(gbPago);
            Controls.Add(gbAdicionales);
            Controls.Add(gbCabania);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSP2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas de Cabañas";
            Load += frmSP2_Load;
            gbCabania.ResumeLayout(false);
            gbCabania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDias).EndInit();
            gbAdicionales.ResumeLayout(false);
            gbAdicionales.PerformLayout();
            gbPago.ResumeLayout(false);
            gbPago.PerformLayout();
            gbReservas.ResumeLayout(false);
            gbReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCabania;
        private GroupBox gbAdicionales;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private ComboBox cmbTipo;
        private GroupBox gbPago;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private ComboBox cmbTarjeta;
        private GroupBox gbReservas;
        private TextBox txtNombre;
        private Button btnAceptar;
        private ComboBox cmbPersonas;
        private Label lblTipo;
        private Label lblPersonas;
        private Label lblDias;
        private Label lblTarjeta;
        private Label lblTelefono;
        private Label lblNombre;
        private Button btnCancelar;
        private MaskedTextBox txtTelefono;
        private NumericUpDown txtDias;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colPersonas;
        private DataGridViewTextBoxColumn colDias;
    }
}
