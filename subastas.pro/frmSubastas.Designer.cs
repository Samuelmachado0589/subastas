namespace subastas.pro
{
    partial class frmSubastas
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
            button1 = new Button();
            ltbSubasta = new ListBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtDocumentos = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FA = new Label();
            dgvRegistros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Subastas = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label11 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            Subastas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(65, 358);
            button1.Name = "button1";
            button1.Size = new Size(186, 58);
            button1.TabIndex = 2;
            button1.Text = "Registrar Oferta";
            button1.UseVisualStyleBackColor = true;
            // 
            // ltbSubasta
            // 
            ltbSubasta.FormattingEnabled = true;
            ltbSubasta.ItemHeight = 15;
            ltbSubasta.Location = new Point(26, 206);
            ltbSubasta.Name = "ltbSubasta";
            ltbSubasta.Size = new Size(280, 79);
            ltbSubasta.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dgvRegistros);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDocumentos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 485);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // button2
            // 
            button2.Location = new Point(196, 412);
            button2.Name = "button2";
            button2.Size = new Size(150, 49);
            button2.TabIndex = 32;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(9, 412);
            button3.Name = "button3";
            button3.Size = new Size(150, 49);
            button3.TabIndex = 31;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(151, 318);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(163, 23);
            txtTelefono.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 358);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 29;
            label5.Text = "Email:";
            // 
            // txtDocumentos
            // 
            txtDocumentos.Location = new Point(151, 280);
            txtDocumentos.Name = "txtDocumentos";
            txtDocumentos.Size = new Size(163, 23);
            txtDocumentos.TabIndex = 28;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(151, 239);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(163, 23);
            txtApellido.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 363);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 193);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 234);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 24;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 275);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 23;
            label3.Text = "Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 316);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 22;
            label2.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 193);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 21;
            label1.Text = "Nombre:";
            // 
            // FA
            // 
            FA.AutoSize = true;
            FA.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FA.Location = new Point(558, 9);
            FA.Name = "FA";
            FA.Size = new Size(121, 32);
            FA.TabIndex = 20;
            FA.Text = "SUBASTAS";
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvRegistros.Location = new Point(6, 34);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.Size = new Size(358, 140);
            dgvRegistros.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Documento";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefono";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            // 
            // Subastas
            // 
            Subastas.Controls.Add(pictureBox1);
            Subastas.Controls.Add(button4);
            Subastas.Controls.Add(textBox1);
            Subastas.Controls.Add(label11);
            Subastas.Controls.Add(label8);
            Subastas.Controls.Add(comboBox2);
            Subastas.Controls.Add(comboBox1);
            Subastas.Controls.Add(dataGridView1);
            Subastas.Controls.Add(label6);
            Subastas.Controls.Add(label7);
            Subastas.Controls.Add(label9);
            Subastas.Controls.Add(textBox2);
            Subastas.Controls.Add(label10);
            Subastas.Controls.Add(textBox3);
            Subastas.Controls.Add(ltbSubasta);
            Subastas.Controls.Add(button1);
            Subastas.Location = new Point(415, 53);
            Subastas.Name = "Subastas";
            Subastas.Size = new Size(784, 485);
            Subastas.TabIndex = 21;
            Subastas.TabStop = false;
            Subastas.Text = "Subastas";
            Subastas.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 34);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 31;
            label6.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 301);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 32;
            label7.Text = "Oferta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 114);
            label9.Name = "label9";
            label9.Size = new Size(118, 25);
            label9.TabIndex = 33;
            label9.Text = "Condicciones:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 119);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 38);
            textBox2.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 73);
            label10.Name = "label10";
            label10.Size = new Size(93, 25);
            label10.TabIndex = 34;
            label10.Text = "duraccion:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.Location = new Point(332, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(431, 182);
            dataGridView1.TabIndex = 41;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 42;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(143, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(119, 178);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 44;
            label8.Text = "Cliente:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Producto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre Cliente";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Apellido Cliente";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Oferta";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Duraccion";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(343, 283);
            label11.Name = "label11";
            label11.Size = new Size(86, 25);
            label11.TabIndex = 45;
            label11.Text = "Ganador:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(451, 283);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 38);
            textBox1.TabIndex = 46;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(470, 226);
            button4.Name = "button4";
            button4.Size = new Size(186, 47);
            button4.TabIndex = 47;
            button4.Text = "Finalizar Subasta";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_05_05_084025;
            pictureBox1.Location = new Point(520, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // frmSubastas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 563);
            Controls.Add(Subastas);
            Controls.Add(FA);
            Controls.Add(groupBox1);
            Name = "frmSubastas";
            Text = "frmSubastas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            Subastas.ResumeLayout(false);
            Subastas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox ltbSubasta;
        private GroupBox groupBox1;
        private Button button2;
        private DataGridView dgvRegistros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button3;
        private Label label1;
        private TextBox txtTelefono;
        private Label label2;
        private Label label5;
        private Label label3;
        private TextBox txtDocumentos;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private Label FA;
        private GroupBox Subastas;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox3;
        private Label label8;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TextBox textBox1;
        private Label label11;
        private Button button4;
        private PictureBox pictureBox1;
    }
}