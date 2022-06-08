
namespace JuhaszIstvan_Mz60
{
    partial class FrmDolgozok
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
            this.checkBoxMindkettoNem = new System.Windows.Forms.CheckBox();
            this.buttonMentDolgozok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMunkabanToltottEv = new System.Windows.Forms.Label();
            this.labelKor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6eveDolgozo = new System.Windows.Forms.Label();
            this.labelOsszeskor = new System.Windows.Forms.Label();
            this.labelLegidosebb = new System.Windows.Forms.Label();
            this.radioButtonFiu = new System.Windows.Forms.RadioButton();
            this.radioButtonLany = new System.Windows.Forms.RadioButton();
            this.comboBoxFiuk = new System.Windows.Forms.ComboBox();
            this.comboBoxLanyok = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxMindkettoNem
            // 
            this.checkBoxMindkettoNem.AutoSize = true;
            this.checkBoxMindkettoNem.Location = new System.Drawing.Point(246, 168);
            this.checkBoxMindkettoNem.Name = "checkBoxMindkettoNem";
            this.checkBoxMindkettoNem.Size = new System.Drawing.Size(96, 17);
            this.checkBoxMindkettoNem.TabIndex = 15;
            this.checkBoxMindkettoNem.Text = "Mindkettő nem";
            this.checkBoxMindkettoNem.UseVisualStyleBackColor = true;
            this.checkBoxMindkettoNem.CheckedChanged += new System.EventHandler(this.checkBoxMindkettoNem_Click);
            this.checkBoxMindkettoNem.CheckStateChanged += new System.EventHandler(this.checkBoxMindkettoNem_Click);
            this.checkBoxMindkettoNem.Click += new System.EventHandler(this.checkBoxMindkettoNem_Click);
            // 
            // buttonMentDolgozok
            // 
            this.buttonMentDolgozok.Location = new System.Drawing.Point(246, 198);
            this.buttonMentDolgozok.Name = "buttonMentDolgozok";
            this.buttonMentDolgozok.Size = new System.Drawing.Size(151, 23);
            this.buttonMentDolgozok.TabIndex = 14;
            this.buttonMentDolgozok.Text = "Ment";
            this.buttonMentDolgozok.UseVisualStyleBackColor = true;
            this.buttonMentDolgozok.Click += new System.EventHandler(this.buttonMentDolgozok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fiúk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lányok";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMunkabanToltottEv);
            this.groupBox2.Controls.Add(this.labelKor);
            this.groupBox2.Location = new System.Drawing.Point(246, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 110);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adatok";
            // 
            // labelMunkabanToltottEv
            // 
            this.labelMunkabanToltottEv.AutoSize = true;
            this.labelMunkabanToltottEv.Location = new System.Drawing.Point(16, 64);
            this.labelMunkabanToltottEv.Name = "labelMunkabanToltottEv";
            this.labelMunkabanToltottEv.Size = new System.Drawing.Size(77, 13);
            this.labelMunkabanToltottEv.TabIndex = 1;
            this.labelMunkabanToltottEv.Text = "mióta dolgozik:";
            // 
            // labelKor
            // 
            this.labelKor.AutoSize = true;
            this.labelKor.Location = new System.Drawing.Point(16, 31);
            this.labelKor.Name = "labelKor";
            this.labelKor.Size = new System.Drawing.Size(25, 13);
            this.labelKor.TabIndex = 0;
            this.labelKor.Text = "kor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6eveDolgozo);
            this.groupBox1.Controls.Add(this.labelOsszeskor);
            this.groupBox1.Controls.Add(this.labelLegidosebb);
            this.groupBox1.Controls.Add(this.radioButtonFiu);
            this.groupBox1.Controls.Add(this.radioButtonLany);
            this.groupBox1.Location = new System.Drawing.Point(11, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 182);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Összesítő";
            // 
            // label6eveDolgozo
            // 
            this.label6eveDolgozo.AutoSize = true;
            this.label6eveDolgozo.Location = new System.Drawing.Point(12, 132);
            this.label6eveDolgozo.Name = "label6eveDolgozo";
            this.label6eveDolgozo.Size = new System.Drawing.Size(77, 13);
            this.label6eveDolgozo.TabIndex = 4;
            this.label6eveDolgozo.Text = "6 éve dolgozó:";
            // 
            // labelOsszeskor
            // 
            this.labelOsszeskor.AutoSize = true;
            this.labelOsszeskor.Location = new System.Drawing.Point(12, 93);
            this.labelOsszeskor.Name = "labelOsszeskor";
            this.labelOsszeskor.Size = new System.Drawing.Size(60, 13);
            this.labelOsszeskor.TabIndex = 3;
            this.labelOsszeskor.Text = "összes kor:";
            // 
            // labelLegidosebb
            // 
            this.labelLegidosebb.AutoSize = true;
            this.labelLegidosebb.Location = new System.Drawing.Point(12, 54);
            this.labelLegidosebb.Name = "labelLegidosebb";
            this.labelLegidosebb.Size = new System.Drawing.Size(61, 13);
            this.labelLegidosebb.TabIndex = 2;
            this.labelLegidosebb.Text = "legidősebb:";
            // 
            // radioButtonFiu
            // 
            this.radioButtonFiu.AutoSize = true;
            this.radioButtonFiu.Location = new System.Drawing.Point(65, 19);
            this.radioButtonFiu.Name = "radioButtonFiu";
            this.radioButtonFiu.Size = new System.Drawing.Size(36, 17);
            this.radioButtonFiu.TabIndex = 1;
            this.radioButtonFiu.Text = "fiú";
            this.radioButtonFiu.UseVisualStyleBackColor = true;
            this.radioButtonFiu.CheckedChanged += new System.EventHandler(this.radioButtonFiu_CheckedChanged);
            this.radioButtonFiu.Click += new System.EventHandler(this.radioButtonFiu_CheckedChanged);
            // 
            // radioButtonLany
            // 
            this.radioButtonLany.AutoSize = true;
            this.radioButtonLany.Location = new System.Drawing.Point(15, 19);
            this.radioButtonLany.Name = "radioButtonLany";
            this.radioButtonLany.Size = new System.Drawing.Size(44, 17);
            this.radioButtonLany.TabIndex = 0;
            this.radioButtonLany.Text = "lány";
            this.radioButtonLany.UseVisualStyleBackColor = true;
            this.radioButtonLany.CheckedChanged += new System.EventHandler(this.radioButtonLany_CheckedChanged);
            this.radioButtonLany.Click += new System.EventHandler(this.radioButtonLany_CheckedChanged);
            // 
            // comboBoxFiuk
            // 
            this.comboBoxFiuk.FormattingEnabled = true;
            this.comboBoxFiuk.Location = new System.Drawing.Point(276, 12);
            this.comboBoxFiuk.Name = "comboBoxFiuk";
            this.comboBoxFiuk.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiuk.TabIndex = 9;
            this.comboBoxFiuk.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiuk_SelectedIndexChanged);
            this.comboBoxFiuk.Click += new System.EventHandler(this.comboBoxFiuk_Click);
            // 
            // comboBoxLanyok
            // 
            this.comboBoxLanyok.FormattingEnabled = true;
            this.comboBoxLanyok.Location = new System.Drawing.Point(58, 12);
            this.comboBoxLanyok.Name = "comboBoxLanyok";
            this.comboBoxLanyok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanyok.TabIndex = 8;
            this.comboBoxLanyok.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanyok_SelectedIndexChanged);
            this.comboBoxLanyok.Click += new System.EventHandler(this.comboBoxLanyok_Click);
            // 
            // FrmDolgozok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 235);
            this.Controls.Add(this.checkBoxMindkettoNem);
            this.Controls.Add(this.buttonMentDolgozok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxFiuk);
            this.Controls.Add(this.comboBoxLanyok);
            this.Name = "FrmDolgozok";
            this.Text = "Dolgozok";
            this.Load += new System.EventHandler(this.DolgozokFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxLanyok;
        private System.Windows.Forms.CheckBox checkBoxMindkettoNem;
        private System.Windows.Forms.Button buttonMentDolgozok;
        private System.Windows.Forms.RadioButton radioButtonFiu;
        private System.Windows.Forms.RadioButton radioButtonLany;
        private System.Windows.Forms.ComboBox comboBoxFiuk;
        private System.Windows.Forms.Label labelMunkabanToltottEv;
        private System.Windows.Forms.Label labelKor;
        private System.Windows.Forms.Label label6eveDolgozo;
        private System.Windows.Forms.Label labelOsszeskor;
        private System.Windows.Forms.Label labelLegidosebb;
    }
}