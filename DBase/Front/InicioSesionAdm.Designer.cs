namespace Front
{
    partial class InicioSesionAdm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(731, 403);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(397, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 14;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 188);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 12;
            label5.Text = "Contraseña:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 133);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 11;
            label4.Text = "Usuario:";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 54);
            label1.Name = "label1";
            label1.Size = new Size(301, 25);
            label1.TabIndex = 10;
            label1.Text = "Inicio de sesión como administrador";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(388, 291);
            button2.Name = "button2";
            button2.Size = new Size(168, 70);
            button2.TabIndex = 9;
            button2.Text = "Iniciar sesión";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // InicioSesionAdm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 512);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "InicioSesionAdm";
            Text = "InicioSesionAdm";
            Load += InicioSesionAdm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button button2;
    }
}