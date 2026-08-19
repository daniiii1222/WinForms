namespace Practico2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LModificar = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            panel1 = new Panel();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            button1 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido:";
            label1.Click += label1_Click;
            // 
            // TDni
            // 
            TDni.AutoSize = true;
            TDni.Location = new Point(23, 106);
            TDni.Name = "TDni";
            TDni.Size = new Size(38, 20);
            TDni.TabIndex = 1;
            TDni.Text = "DNI:";
            TDni.Click += TDni_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(23, 168);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(69, 20);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido:";
            LApellido.Click += label3_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(23, 226);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(67, 20);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre:";
            LNombre.Click += label4_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(165, 49);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(73, 20);
            LModificar.TabIndex = 4;
            LModificar.Text = "modificar";
            LModificar.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.Image = (Image)resources.GetObject("TGuardar.Image");
            TGuardar.ImageAlign = ContentAlignment.MiddleRight;
            TGuardar.Location = new Point(51, 540);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(142, 64);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleLeft;
            TGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Image = (Image)resources.GetObject("TEliminar.Image");
            TEliminar.Location = new Point(218, 540);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(129, 64);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(61, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 453);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(157, 427);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(105, 24);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "Mastercard";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(157, 397);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(58, 24);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Visa";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(157, 367);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Naranja";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 347);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 12;
            label3.Text = "Tarjeta de credito:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 293);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Telefono";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 286);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(481, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 210);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Location = new Point(670, 292);
            RBVaron.MaximumSize = new Size(95, 95);
            RBVaron.Name = "RBVaron";
            RBVaron.Padding = new Padding(1);
            RBVaron.Size = new Size(70, 26);
            RBVaron.TabIndex = 17;
            RBVaron.Text = "Varon";
            RBVaron.TextAlign = ContentAlignment.BottomCenter;
            RBVaron.TextImageRelation = TextImageRelation.ImageAboveText;
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.BackColor = SystemColors.Control;
            RBMujer.Checked = true;
            RBMujer.Location = new Point(515, 291);
            RBMujer.MaximumSize = new Size(95, 95);
            RBMujer.Name = "RBMujer";
            RBMujer.Padding = new Padding(1);
            RBMujer.Size = new Size(70, 26);
            RBMujer.TabIndex = 18;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.TextAlign = ContentAlignment.BottomCenter;
            RBMujer.TextImageRelation = TextImageRelation.ImageAboveText;
            RBMujer.UseVisualStyleBackColor = false;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(564, 540);
            button1.Name = "button1";
            button1.Size = new Size(122, 64);
            button1.TabIndex = 19;
            button1.Text = "Salir";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(359, 9);
            label4.Name = "label4";
            label4.Size = new Size(200, 39);
            label4.TabIndex = 20;
            label4.Text = "Nuevo Cliente";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            label4.Click += label4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 625);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(TGuardar);
            Controls.Add(TEliminar);
            Name = "Form1";
            Text = "Pequeño Sistema";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TDni;
        private Label LApellido;
        private Label LNombre;
        private Label LModificar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button TGuardar;
        private Button TEliminar;
        private Panel panel1;
        private Label label2;
        private TextBox textBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        public RadioButton RBMujer;
        private Button button1;
        private Label label4;
    }
}
