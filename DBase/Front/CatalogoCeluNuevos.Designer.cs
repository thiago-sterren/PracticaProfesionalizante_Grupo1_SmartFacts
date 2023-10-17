namespace Front
{
    partial class CatalogoCeluNuevos
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
            listBox1 = new ListBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(90, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(870, 404);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(399, 529);
            button1.Name = "button1";
            button1.Size = new Size(137, 89);
            button1.TabIndex = 1;
            button1.Text = "Agregar al carrito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1197, 33);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CatalogoCeluNuevos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 729);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "CatalogoCeluNuevos";
            Text = "CatalogoCeluNuevos";
            Load += CatalogoCeluNuevos_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button3;
    }
}