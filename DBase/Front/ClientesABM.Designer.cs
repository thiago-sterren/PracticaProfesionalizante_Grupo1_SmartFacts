namespace Front
{
    partial class ClientesABM
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 246);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 17;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 193);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 16;
            label3.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 143);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 15;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 96);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 14;
            label1.Text = "Nombre:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(153, 240);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(150, 31);
            txtContrasenia.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(153, 187);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 137);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(246, 451);
            button1.Name = "button1";
            button1.Size = new Size(133, 47);
            button1.TabIndex = 18;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(444, 451);
            button2.Name = "button2";
            button2.Size = new Size(133, 47);
            button2.TabIndex = 19;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(637, 451);
            button3.Name = "button3";
            button3.Size = new Size(133, 47);
            button3.TabIndex = 20;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(916, 500);
            button4.Name = "button4";
            button4.Size = new Size(133, 47);
            button4.TabIndex = 21;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(362, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(687, 354);
            listBox1.TabIndex = 22;
            // 
            // ClientesABM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 582);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "ClientesABM";
            Text = "ClientesABM";
            Load += ClientesABM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
    }
}