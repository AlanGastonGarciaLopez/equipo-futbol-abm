namespace UI
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNumero = new TextBox();
            chkHabilitado = new CheckBox();
            btnAlta = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            dgvJugadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 98);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 167);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Numero";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(139, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(209, 31);
            txtApellido.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(139, 164);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(209, 31);
            txtNumero.TabIndex = 5;
            // 
            // chkHabilitado
            // 
            chkHabilitado.AutoSize = true;
            chkHabilitado.Location = new Point(29, 245);
            chkHabilitado.Name = "chkHabilitado";
            chkHabilitado.Size = new Size(120, 29);
            chkHabilitado.TabIndex = 6;
            chkHabilitado.Text = "Habilitado";
            chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(139, 308);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(112, 34);
            btnAlta.TabIndex = 7;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(139, 373);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(139, 440);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(112, 34);
            btnBaja.TabIndex = 9;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(441, 32);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 62;
            dgvJugadores.Size = new Size(435, 442);
            dgvJugadores.TabIndex = 10;
            dgvJugadores.CellClick += dgvJugadores_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 523);
            Controls.Add(dgvJugadores);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(chkHabilitado);
            Controls.Add(txtNumero);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNumero;
        private CheckBox chkHabilitado;
        private Button btnAlta;
        private Button btnModificar;
        private Button btnBaja;
        private DataGridView dgvJugadores;
    }
}
