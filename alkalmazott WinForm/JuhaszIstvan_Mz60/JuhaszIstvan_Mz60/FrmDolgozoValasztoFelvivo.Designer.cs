
namespace JuhaszIstvan_Mz60
{
    partial class MunkahelyFrm
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
            this.buttonDolgozoFelvitel = new System.Windows.Forms.Button();
            this.textBoxUjNev = new System.Windows.Forms.TextBox();
            this.textBoxUjKor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUjfiu = new System.Windows.Forms.RadioButton();
            this.radioButtonUjlany = new System.Windows.Forms.RadioButton();
            this.textBoxMunkabantoltottEv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDolgozokFormra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDolgozoFelvitel
            // 
            this.buttonDolgozoFelvitel.Location = new System.Drawing.Point(134, 197);
            this.buttonDolgozoFelvitel.Name = "buttonDolgozoFelvitel";
            this.buttonDolgozoFelvitel.Size = new System.Drawing.Size(148, 36);
            this.buttonDolgozoFelvitel.TabIndex = 0;
            this.buttonDolgozoFelvitel.Text = "Dolgozó felvitele\r\n      (Mentés)";
            this.buttonDolgozoFelvitel.UseVisualStyleBackColor = true;
            this.buttonDolgozoFelvitel.Click += new System.EventHandler(this.buttonDolgozoFelvitel_Click);
            // 
            // textBoxUjNev
            // 
            this.textBoxUjNev.Location = new System.Drawing.Point(149, 41);
            this.textBoxUjNev.Name = "textBoxUjNev";
            this.textBoxUjNev.Size = new System.Drawing.Size(133, 20);
            this.textBoxUjNev.TabIndex = 1;
            // 
            // textBoxUjKor
            // 
            this.textBoxUjKor.Location = new System.Drawing.Point(149, 77);
            this.textBoxUjKor.Name = "textBoxUjKor";
            this.textBoxUjKor.Size = new System.Drawing.Size(133, 20);
            this.textBoxUjKor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Neme:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Munkában töltött év:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUjfiu);
            this.groupBox1.Controls.Add(this.radioButtonUjlany);
            this.groupBox1.Controls.Add(this.textBoxMunkabantoltottEv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxUjKor);
            this.groupBox1.Controls.Add(this.textBoxUjNev);
            this.groupBox1.Controls.Add(this.buttonDolgozoFelvitel);
            this.groupBox1.Location = new System.Drawing.Point(52, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 298);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új dolgozó felvitele:";
            // 
            // radioButtonUjfiu
            // 
            this.radioButtonUjfiu.AutoSize = true;
            this.radioButtonUjfiu.Location = new System.Drawing.Point(199, 113);
            this.radioButtonUjfiu.Name = "radioButtonUjfiu";
            this.radioButtonUjfiu.Size = new System.Drawing.Size(36, 17);
            this.radioButtonUjfiu.TabIndex = 15;
            this.radioButtonUjfiu.TabStop = true;
            this.radioButtonUjfiu.Text = "fiú";
            this.radioButtonUjfiu.UseVisualStyleBackColor = true;
            // 
            // radioButtonUjlany
            // 
            this.radioButtonUjlany.AutoSize = true;
            this.radioButtonUjlany.Location = new System.Drawing.Point(149, 113);
            this.radioButtonUjlany.Name = "radioButtonUjlany";
            this.radioButtonUjlany.Size = new System.Drawing.Size(44, 17);
            this.radioButtonUjlany.TabIndex = 14;
            this.radioButtonUjlany.TabStop = true;
            this.radioButtonUjlany.Text = "lány";
            this.radioButtonUjlany.UseVisualStyleBackColor = true;
            // 
            // textBoxMunkabantoltottEv
            // 
            this.textBoxMunkabantoltottEv.Location = new System.Drawing.Point(149, 149);
            this.textBoxMunkabantoltottEv.Name = "textBoxMunkabantoltottEv";
            this.textBoxMunkabantoltottEv.Size = new System.Drawing.Size(133, 20);
            this.textBoxMunkabantoltottEv.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ugrás a dolgozói adatok menühöz:";
            // 
            // buttonDolgozokFormra
            // 
            this.buttonDolgozokFormra.Location = new System.Drawing.Point(73, 58);
            this.buttonDolgozokFormra.Name = "buttonDolgozokFormra";
            this.buttonDolgozokFormra.Size = new System.Drawing.Size(362, 34);
            this.buttonDolgozokFormra.TabIndex = 12;
            this.buttonDolgozokFormra.Text = "Dolgozók összesítő ablak megnyitása";
            this.buttonDolgozokFormra.UseVisualStyleBackColor = true;
            this.buttonDolgozokFormra.Click += new System.EventHandler(this.buttonDolgozokFormra_Click);
            // 
            // MunkahelyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 430);
            this.Controls.Add(this.buttonDolgozokFormra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "MunkahelyFrm";
            this.Text = "Kezdőablak";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDolgozoFelvitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDolgozokFormra;
        private System.Windows.Forms.RadioButton radioButtonUjfiu;
        private System.Windows.Forms.RadioButton radioButtonUjlany;
        private System.Windows.Forms.TextBox textBoxUjNev;
        private System.Windows.Forms.TextBox textBoxUjKor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMunkabantoltottEv;
    }
}

