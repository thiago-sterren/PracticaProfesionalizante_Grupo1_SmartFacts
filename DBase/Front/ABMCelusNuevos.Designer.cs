namespace Front
{
    partial class ABMCelusNuevos
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
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            txtModStock = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(178, 492);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(397, 492);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(609, 492);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1117, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1117, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1117, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1117, 211);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1117, 271);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1047, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 10;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1030, 99);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 11;
            label2.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1047, 155);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 13;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(962, 214);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 14;
            label5.Text = "Almacenamiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1030, 271);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 15;
            label6.Text = "Garantía:";
            label6.Click += label6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1155, 549);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 16;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(735, 578);
            button5.Name = "button5";
            button5.Size = new Size(112, 73);
            button5.TabIndex = 17;
            button5.Text = "Cambiar stock";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtModStock
            // 
            txtModStock.Location = new Point(546, 599);
            txtModStock.Name = "txtModStock";
            txtModStock.Size = new Size(150, 31);
            txtModStock.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(873, 396);
            dataGridView1.TabIndex = 19;
            // 
            // ABMCelusNuevos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 663);
            Controls.Add(dataGridView1);
            Controls.Add(txtModStock);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ABMCelusNuevos";
            Text = "ABMCelusNuevos";
            Load += ABMCelusNuevos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private TextBox txtModStock;
        private DataGridView dataGridView1;
    }
}