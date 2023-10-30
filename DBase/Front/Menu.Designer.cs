namespace Front
{
    partial class Menu
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(445, 295);
            button1.Name = "button1";
            button1.Size = new Size(168, 70);
            button1.TabIndex = 0;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 55);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 1;
            label1.Text = "Inicio de sesión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 137);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 4;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 192);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 5;
            label5.Text = "Contraseña:";
            // 
            // button2
            // 
            button2.Location = new Point(881, 257);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 6;
            button2.Text = "Click aquí";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(835, 212);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 9;
            label2.Text = "¿Aún no tienes una cuenta?";
            // 
            // button3
            // 
            button3.Location = new Point(906, 519);
            button3.Name = "button3";
            button3.Size = new Size(187, 67);
            button3.TabIndex = 10;
            button3.Text = "Acceso en modo administrador";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 606);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
    }
}