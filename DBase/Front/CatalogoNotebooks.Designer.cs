namespace Front
{
    partial class CatalogoNotebooks
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
            button3 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(1148, 37);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(350, 533);
            button1.Name = "button1";
            button1.Size = new Size(137, 89);
            button1.TabIndex = 5;
            button1.Text = "Agregar al carrito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(41, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(870, 404);
            listBox1.TabIndex = 4;
            // 
            // CatalogoNotebooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 658);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "CatalogoNotebooks";
            Text = "CatalogoNotebooks";
            Load += CatalogoNotebooks_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private ListBox listBox1;
    }
}