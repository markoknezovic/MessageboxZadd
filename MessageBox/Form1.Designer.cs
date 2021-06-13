namespace MessageBoks
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(345, 99);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(75, 23);
            this.buttonOtvori.TabIndex = 0;
            this.buttonOtvori.Text = "prikazi";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(312, 128);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(135, 79);
            this.textBoxRezultat.TabIndex = 1;
            this.textBoxRezultat.TextChanged += new System.EventHandler(this.txtKutijaZaUpis_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonOtvori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtvori;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

