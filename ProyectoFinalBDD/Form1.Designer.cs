namespace ProyectoFinalBDD
{
    partial class Ventana1
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
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            txtCedula = new TextBox();
            dgvDatos = new DataGridView();
            btnGuardar = new Button();
            btnIngresar = new Button();
            columnaNombre = new DataGridViewTextBoxColumn();
            columnaApellido = new DataGridViewTextBoxColumn();
            columnaCorreo = new DataGridViewTextBoxColumn();
            ColumnaCedula = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 44);
            label1.TabIndex = 0;
            label1.Text = "Renta de DVDs";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(97, 29);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(81, 29);
            label4.TabIndex = 2;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 237);
            label5.Name = "label5";
            label5.Size = new Size(84, 29);
            label5.TabIndex = 2;
            label5.Text = "Cédula";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(570, 37);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(125, 128);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(570, 37);
            txtApellido.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(125, 181);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(570, 37);
            txtCorreo.TabIndex = 3;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(125, 234);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(570, 37);
            txtCedula.TabIndex = 3;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { columnaNombre, columnaApellido, columnaCorreo, ColumnaCedula });
            dgvDatos.Location = new Point(12, 301);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(683, 188);
            dgvDatos.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(746, 321);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 64);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar Datos";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(746, 412);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(193, 77);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar al Sistema";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // columnaNombre
            // 
            columnaNombre.HeaderText = "Nombre";
            columnaNombre.MinimumWidth = 6;
            columnaNombre.Name = "columnaNombre";
            columnaNombre.Width = 125;
            // 
            // columnaApellido
            // 
            columnaApellido.HeaderText = "Apellido";
            columnaApellido.MinimumWidth = 6;
            columnaApellido.Name = "columnaApellido";
            columnaApellido.Width = 125;
            // 
            // columnaCorreo
            // 
            columnaCorreo.HeaderText = "Correo";
            columnaCorreo.MinimumWidth = 6;
            columnaCorreo.Name = "columnaCorreo";
            columnaCorreo.Width = 125;
            // 
            // ColumnaCedula
            // 
            ColumnaCedula.HeaderText = "Cedula";
            ColumnaCedula.MinimumWidth = 6;
            ColumnaCedula.Name = "ColumnaCedula";
            ColumnaCedula.Width = 125;
            // 
            // Ventana1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1014, 595);
            Controls.Add(btnIngresar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvDatos);
            Controls.Add(txtCedula);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft PhagsPa", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Ventana1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RENTA DVDs PROYECTO FINAL";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TextBox txtCedula;
        private DataGridView dgvDatos;
        private Button btnGuardar;
        private Button btnIngresar;
        private DataGridViewTextBoxColumn columnaNombre;
        private DataGridViewTextBoxColumn columnaApellido;
        private DataGridViewTextBoxColumn columnaCorreo;
        private DataGridViewTextBoxColumn ColumnaCedula;
    }
}
