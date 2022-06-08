
namespace RaktarkeszletNyilvantarto
{
    partial class Bejelentkezes
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
            this.buttonBelepes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxjelsz = new System.Windows.Forms.TextBox();
            this.textBoxFhn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBelepes
            // 
            this.buttonBelepes.Location = new System.Drawing.Point(132, 128);
            this.buttonBelepes.Name = "buttonBelepes";
            this.buttonBelepes.Size = new System.Drawing.Size(105, 23);
            this.buttonBelepes.TabIndex = 0;
            this.buttonBelepes.Text = "Belépés";
            this.buttonBelepes.UseVisualStyleBackColor = true;
            this.buttonBelepes.Click += new System.EventHandler(this.buttonBelepes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBelepes);
            this.groupBox1.Controls.Add(this.textBoxjelsz);
            this.groupBox1.Controls.Add(this.textBoxFhn);
            this.groupBox1.Location = new System.Drawing.Point(148, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév:";
            // 
            // textBoxjelsz
            // 
            this.textBoxjelsz.Location = new System.Drawing.Point(119, 90);
            this.textBoxjelsz.Name = "textBoxjelsz";
            this.textBoxjelsz.PasswordChar = '*';
            this.textBoxjelsz.Size = new System.Drawing.Size(118, 20);
            this.textBoxjelsz.TabIndex = 1;
            // 
            // textBoxFhn
            // 
            this.textBoxFhn.Location = new System.Drawing.Point(119, 38);
            this.textBoxFhn.Name = "textBoxFhn";
            this.textBoxFhn.Size = new System.Drawing.Size(118, 20);
            this.textBoxFhn.TabIndex = 0;
            // 
            // Bejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::RaktarkeszletNyilvantarto.Properties.Resources._202;
            this.ClientSize = new System.Drawing.Size(624, 681);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBelepes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxjelsz;
        public System.Windows.Forms.TextBox textBoxFhn;
    }
}

