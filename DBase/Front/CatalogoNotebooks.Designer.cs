﻿namespace Front
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
            listBox1 = new ListBox();
            btnVolver = new Button();
            btnAddCarrito = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(31, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1076, 504);
            listBox1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1126, 571);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(135, 66);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnAddCarrito
            // 
            btnAddCarrito.Location = new Point(312, 571);
            btnAddCarrito.Name = "btnAddCarrito";
            btnAddCarrito.Size = new Size(135, 66);
            btnAddCarrito.TabIndex = 2;
            btnAddCarrito.Text = "Agregar al carrito";
            btnAddCarrito.UseVisualStyleBackColor = true;
            btnAddCarrito.Click += btnAddCarrito_Click;
            // 
            // CatalogoNotebooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 658);
            Controls.Add(btnAddCarrito);
            Controls.Add(btnVolver);
            Controls.Add(listBox1);
            Name = "CatalogoNotebooks";
            Text = "CatalogoNotebooks";
            Load += CatalogoNotebooks_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnVolver;
        private Button btnAddCarrito;
    }
}