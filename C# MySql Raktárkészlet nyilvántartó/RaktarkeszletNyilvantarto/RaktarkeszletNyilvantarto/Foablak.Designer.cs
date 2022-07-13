
namespace RaktarkeszletNyilvantarto
{
    partial class Foablak
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
            this.adatbazisraktarDataSet = new RaktarkeszletNyilvantarto.adatbazisraktarDataSet();
            this.adatbazisraktarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTulajdonos = new System.Windows.Forms.ComboBox();
            this.comboBoxGyarto = new System.Windows.Forms.ComboBox();
            this.buttonfelvitel = new System.Windows.Forms.Button();
            this.comboBoxEszkozallapotaFelvitel = new System.Windows.Forms.ComboBox();
            this.comboBoxEszkoztipusaFelvitel = new System.Windows.Forms.ComboBox();
            this.textBoxModelszam = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxOperaciosrendszerfelvitel = new System.Windows.Forms.ComboBox();
            this.comboBoxGpuFelvitel = new System.Windows.Forms.ComboBox();
            this.comboBoxHddFelvitel = new System.Windows.Forms.ComboBox();
            this.comboBoxRamFelvitel = new System.Windows.Forms.ComboBox();
            this.comboBoxCpuFelvitel = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxMac = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxComputerneve = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerKiadasiidopont = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGarancialejaratiido = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSeriaszam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLeirasjegyzet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEszkozneve = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelsortema = new System.Windows.Forms.Label();
            this.textBoxTorles = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOsszesito2 = new System.Windows.Forms.DataGridView();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTermekhozzaadasa = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisraktarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisraktarDataSetBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsszesito2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adatbazisraktarDataSet
            // 
            this.adatbazisraktarDataSet.DataSetName = "adatbazisraktarDataSet";
            this.adatbazisraktarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adatbazisraktarDataSetBindingSource
            // 
            this.adatbazisraktarDataSetBindingSource.DataSource = this.adatbazisraktarDataSet;
            this.adatbazisraktarDataSetBindingSource.Position = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage8.Location = new System.Drawing.Point(4, 32);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1188, 768);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Kijelentkezés";
            this.tabPage8.Enter += new System.EventHandler(this.tabPage8_Enter);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1188, 768);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eszköz felvitele";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.comboBoxTulajdonos);
            this.groupBox1.Controls.Add(this.comboBoxGyarto);
            this.groupBox1.Controls.Add(this.buttonfelvitel);
            this.groupBox1.Controls.Add(this.comboBoxEszkozallapotaFelvitel);
            this.groupBox1.Controls.Add(this.comboBoxEszkoztipusaFelvitel);
            this.groupBox1.Controls.Add(this.textBoxModelszam);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePickerKiadasiidopont);
            this.groupBox1.Controls.Add(this.dateTimePickerGarancialejaratiido);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxSeriaszam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxLeirasjegyzet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBoxEszkozneve);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(53, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 747);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxTulajdonos
            // 
            this.comboBoxTulajdonos.FormattingEnabled = true;
            this.comboBoxTulajdonos.Items.AddRange(new object[] {
            "István",
            "Péter",
            "Eszter",
            "Nóra",
            "Tamás",
            "Csaba",
            "Gábor",
            "Anikó"});
            this.comboBoxTulajdonos.Location = new System.Drawing.Point(102, 240);
            this.comboBoxTulajdonos.Name = "comboBoxTulajdonos";
            this.comboBoxTulajdonos.Size = new System.Drawing.Size(170, 21);
            this.comboBoxTulajdonos.TabIndex = 43;
            this.comboBoxTulajdonos.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxGyarto
            // 
            this.comboBoxGyarto.FormattingEnabled = true;
            this.comboBoxGyarto.Items.AddRange(new object[] {
            "Dell",
            "HP",
            "Lenovo",
            "Asus",
            "Apple",
            "Huawei",
            "Samsung",
            "Egyéb"});
            this.comboBoxGyarto.Location = new System.Drawing.Point(102, 147);
            this.comboBoxGyarto.Name = "comboBoxGyarto";
            this.comboBoxGyarto.Size = new System.Drawing.Size(116, 21);
            this.comboBoxGyarto.TabIndex = 43;
            this.comboBoxGyarto.SelectedIndexChanged += new System.EventHandler(this.comboBoxGyarto_SelectedIndexChanged);
            // 
            // buttonfelvitel
            // 
            this.buttonfelvitel.Location = new System.Drawing.Point(104, 653);
            this.buttonfelvitel.Name = "buttonfelvitel";
            this.buttonfelvitel.Size = new System.Drawing.Size(651, 47);
            this.buttonfelvitel.TabIndex = 38;
            this.buttonfelvitel.Text = "Eszköz felvitele:";
            this.buttonfelvitel.UseVisualStyleBackColor = true;
            this.buttonfelvitel.Click += new System.EventHandler(this.buttonfelvitel_Click);
            // 
            // comboBoxEszkozallapotaFelvitel
            // 
            this.comboBoxEszkozallapotaFelvitel.FormattingEnabled = true;
            this.comboBoxEszkozallapotaFelvitel.Items.AddRange(new object[] {
            "Raktáron",
            "Üzembe helyezve",
            "Törött",
            "Forgalomból kivont",
            "Adományba",
            "Elektronikus Hulladék",
            "Elveszett",
            "Tervezett",
            "Közös használatú",
            "Javítás alatt",
            "Eladva",
            "Ellopták",
            "Teszt eszköz"});
            this.comboBoxEszkozallapotaFelvitel.Location = new System.Drawing.Point(102, 117);
            this.comboBoxEszkozallapotaFelvitel.Name = "comboBoxEszkozallapotaFelvitel";
            this.comboBoxEszkozallapotaFelvitel.Size = new System.Drawing.Size(116, 21);
            this.comboBoxEszkozallapotaFelvitel.TabIndex = 37;
            this.comboBoxEszkozallapotaFelvitel.SelectedIndexChanged += new System.EventHandler(this.comboBoxEszkozallapotaFelvitel_SelectedIndexChanged);
            // 
            // comboBoxEszkoztipusaFelvitel
            // 
            this.comboBoxEszkoztipusaFelvitel.FormattingEnabled = true;
            this.comboBoxEszkoztipusaFelvitel.Items.AddRange(new object[] {
            "Asztali Számítógép",
            "Laptop",
            "Dokkoló",
            "Monitor",
            "Egér / Billentyűzet",
            "Fejhallgató",
            "Telefon",
            "Tablet",
            "Hálózati eszköz"});
            this.comboBoxEszkoztipusaFelvitel.Location = new System.Drawing.Point(102, 84);
            this.comboBoxEszkoztipusaFelvitel.Name = "comboBoxEszkoztipusaFelvitel";
            this.comboBoxEszkoztipusaFelvitel.Size = new System.Drawing.Size(116, 21);
            this.comboBoxEszkoztipusaFelvitel.TabIndex = 36;
            this.comboBoxEszkoztipusaFelvitel.SelectedIndexChanged += new System.EventHandler(this.comboBoxEszkoztipusaFelvitel_SelectedIndexChanged);
            // 
            // textBoxModelszam
            // 
            this.textBoxModelszam.Location = new System.Drawing.Point(102, 307);
            this.textBoxModelszam.Name = "textBoxModelszam";
            this.textBoxModelszam.Size = new System.Drawing.Size(651, 20);
            this.textBoxModelszam.TabIndex = 29;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(30, 307);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(66, 13);
            this.label30.TabIndex = 28;
            this.label30.Text = "Model szám:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxOperaciosrendszerfelvitel);
            this.groupBox3.Controls.Add(this.comboBoxGpuFelvitel);
            this.groupBox3.Controls.Add(this.comboBoxHddFelvitel);
            this.groupBox3.Controls.Add(this.comboBoxRamFelvitel);
            this.groupBox3.Controls.Add(this.comboBoxCpuFelvitel);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBoxMac);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBoxComputerneve);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(104, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 223);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Számítógép, mobil eszköz esetén:";
            // 
            // comboBoxOperaciosrendszerfelvitel
            // 
            this.comboBoxOperaciosrendszerfelvitel.FormattingEnabled = true;
            this.comboBoxOperaciosrendszerfelvitel.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 8",
            "Linux",
            "Mac",
            "Android",
            "Ios",
            "Egyéb"});
            this.comboBoxOperaciosrendszerfelvitel.Location = new System.Drawing.Point(205, 34);
            this.comboBoxOperaciosrendszerfelvitel.Name = "comboBoxOperaciosrendszerfelvitel";
            this.comboBoxOperaciosrendszerfelvitel.Size = new System.Drawing.Size(170, 21);
            this.comboBoxOperaciosrendszerfelvitel.TabIndex = 42;
            this.comboBoxOperaciosrendszerfelvitel.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperaciosrendszerfelvitel_SelectedIndexChanged);
            // 
            // comboBoxGpuFelvitel
            // 
            this.comboBoxGpuFelvitel.FormattingEnabled = true;
            this.comboBoxGpuFelvitel.Items.AddRange(new object[] {
            "integrált",
            "dedikált"});
            this.comboBoxGpuFelvitel.Location = new System.Drawing.Point(205, 188);
            this.comboBoxGpuFelvitel.Name = "comboBoxGpuFelvitel";
            this.comboBoxGpuFelvitel.Size = new System.Drawing.Size(170, 21);
            this.comboBoxGpuFelvitel.TabIndex = 41;
            this.comboBoxGpuFelvitel.SelectedIndexChanged += new System.EventHandler(this.comboBoxGpuFelvitel_SelectedIndexChanged);
            // 
            // comboBoxHddFelvitel
            // 
            this.comboBoxHddFelvitel.FormattingEnabled = true;
            this.comboBoxHddFelvitel.Items.AddRange(new object[] {
            "120",
            "240",
            "500",
            "1000"});
            this.comboBoxHddFelvitel.Location = new System.Drawing.Point(205, 137);
            this.comboBoxHddFelvitel.Name = "comboBoxHddFelvitel";
            this.comboBoxHddFelvitel.Size = new System.Drawing.Size(170, 21);
            this.comboBoxHddFelvitel.TabIndex = 40;
            this.comboBoxHddFelvitel.SelectedIndexChanged += new System.EventHandler(this.comboBoxHddFelvitel_SelectedIndexChanged);
            // 
            // comboBoxRamFelvitel
            // 
            this.comboBoxRamFelvitel.FormattingEnabled = true;
            this.comboBoxRamFelvitel.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.comboBoxRamFelvitel.Location = new System.Drawing.Point(205, 111);
            this.comboBoxRamFelvitel.Name = "comboBoxRamFelvitel";
            this.comboBoxRamFelvitel.Size = new System.Drawing.Size(170, 21);
            this.comboBoxRamFelvitel.TabIndex = 39;
            this.comboBoxRamFelvitel.SelectedIndexChanged += new System.EventHandler(this.comboBoxRamFelvitel_SelectedIndexChanged);
            // 
            // comboBoxCpuFelvitel
            // 
            this.comboBoxCpuFelvitel.FormattingEnabled = true;
            this.comboBoxCpuFelvitel.Items.AddRange(new object[] {
            "Xeon",
            "i9",
            "i7",
            "i5",
            "i3",
            "Apple",
            "Ryzen 3",
            "Ryzen 5",
            "Ryzen 7",
            "Ryzen 9",
            "Egyéb"});
            this.comboBoxCpuFelvitel.Location = new System.Drawing.Point(205, 85);
            this.comboBoxCpuFelvitel.Name = "comboBoxCpuFelvitel";
            this.comboBoxCpuFelvitel.Size = new System.Drawing.Size(170, 21);
            this.comboBoxCpuFelvitel.TabIndex = 38;
            this.comboBoxCpuFelvitel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCpuFelvitel_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(166, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "GPU:";
            // 
            // textBoxMac
            // 
            this.textBoxMac.Location = new System.Drawing.Point(205, 163);
            this.textBoxMac.Name = "textBoxMac";
            this.textBoxMac.Size = new System.Drawing.Size(170, 20);
            this.textBoxMac.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(166, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "MAC:";
            // 
            // textBoxComputerneve
            // 
            this.textBoxComputerneve.Location = new System.Drawing.Point(205, 60);
            this.textBoxComputerneve.Name = "textBoxComputerneve";
            this.textBoxComputerneve.Size = new System.Drawing.Size(170, 20);
            this.textBoxComputerneve.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(79, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Computer name(FQDN):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "HDD:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "RAM:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "CPU:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Operációs Rendszer típusa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "Egyéb Paramétek:\r\n           (opcionális)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kiadási időpont:";
            // 
            // dateTimePickerKiadasiidopont
            // 
            this.dateTimePickerKiadasiidopont.Checked = false;
            this.dateTimePickerKiadasiidopont.Location = new System.Drawing.Point(102, 371);
            this.dateTimePickerKiadasiidopont.Name = "dateTimePickerKiadasiidopont";
            this.dateTimePickerKiadasiidopont.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKiadasiidopont.TabIndex = 17;
            this.dateTimePickerKiadasiidopont.ValueChanged += new System.EventHandler(this.dateTimePickerKiadasiidopont_ValueChanged);
            // 
            // dateTimePickerGarancialejaratiido
            // 
            this.dateTimePickerGarancialejaratiido.Location = new System.Drawing.Point(553, 372);
            this.dateTimePickerGarancialejaratiido.Name = "dateTimePickerGarancialejaratiido";
            this.dateTimePickerGarancialejaratiido.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGarancialejaratiido.TabIndex = 16;
            this.dateTimePickerGarancialejaratiido.ValueChanged += new System.EventHandler(this.dateTimePickerGarancialejaratiido_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Garancia lejárati idő:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "*Tulajdonos:";
            // 
            // textBoxSeriaszam
            // 
            this.textBoxSeriaszam.Location = new System.Drawing.Point(102, 275);
            this.textBoxSeriaszam.Name = "textBoxSeriaszam";
            this.textBoxSeriaszam.Size = new System.Drawing.Size(651, 20);
            this.textBoxSeriaszam.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Széria szám:";
            // 
            // textBoxLeirasjegyzet
            // 
            this.textBoxLeirasjegyzet.Location = new System.Drawing.Point(102, 182);
            this.textBoxLeirasjegyzet.Multiline = true;
            this.textBoxLeirasjegyzet.Name = "textBoxLeirasjegyzet";
            this.textBoxLeirasjegyzet.Size = new System.Drawing.Size(651, 49);
            this.textBoxLeirasjegyzet.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Leírás, jegyzet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gyártó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Állapot:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(60, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "*Név:";
            // 
            // textBoxEszkozneve
            // 
            this.textBoxEszkozneve.Location = new System.Drawing.Point(102, 52);
            this.textBoxEszkozneve.Name = "textBoxEszkozneve";
            this.textBoxEszkozneve.Size = new System.Drawing.Size(651, 20);
            this.textBoxEszkozneve.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(56, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Típus:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.labelsortema);
            this.tabPage3.Controls.Add(this.textBoxTorles);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.buttonTorles);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.buttonTermekhozzaadasa);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1188, 768);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eszközök";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Eszköz Indexe:";
            // 
            // labelsortema
            // 
            this.labelsortema.AutoSize = true;
            this.labelsortema.Location = new System.Drawing.Point(676, 13);
            this.labelsortema.Name = "labelsortema";
            this.labelsortema.Size = new System.Drawing.Size(10, 13);
            this.labelsortema.TabIndex = 44;
            this.labelsortema.Text = ".";
            // 
            // textBoxTorles
            // 
            this.textBoxTorles.Location = new System.Drawing.Point(430, 5);
            this.textBoxTorles.Name = "textBoxTorles";
            this.textBoxTorles.Size = new System.Drawing.Size(31, 20);
            this.textBoxTorles.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dataGridViewOsszesito2);
            this.groupBox2.Location = new System.Drawing.Point(24, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1158, 699);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewOsszesito2
            // 
            this.dataGridViewOsszesito2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOsszesito2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOsszesito2.Location = new System.Drawing.Point(19, 19);
            this.dataGridViewOsszesito2.Name = "dataGridViewOsszesito2";
            this.dataGridViewOsszesito2.Size = new System.Drawing.Size(1119, 657);
            this.dataGridViewOsszesito2.TabIndex = 41;
            this.dataGridViewOsszesito2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOsszesito2_CellContentClick);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(467, 5);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(140, 20);
            this.buttonTorles.TabIndex = 31;
            this.buttonTorles.Text = "Törlése";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Operátori műveletek:";
            // 
            // buttonTermekhozzaadasa
            // 
            this.buttonTermekhozzaadasa.Location = new System.Drawing.Point(175, 6);
            this.buttonTermekhozzaadasa.Name = "buttonTermekhozzaadasa";
            this.buttonTermekhozzaadasa.Size = new System.Drawing.Size(140, 20);
            this.buttonTermekhozzaadasa.TabIndex = 30;
            this.buttonTermekhozzaadasa.Text = "Eszköz hozzáadása";
            this.buttonTermekhozzaadasa.UseVisualStyleBackColor = true;
            this.buttonTermekhozzaadasa.Click += new System.EventHandler(this.buttonTermekhozzaadasa_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(100, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 804);
            this.tabControl1.TabIndex = 1;
            // 
            // Foablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 827);
            this.Controls.Add(this.tabControl1);
            this.Name = "Foablak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Foablak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisraktarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisraktarDataSetBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsszesito2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private adatbazisraktarDataSet adatbazisraktarDataSet;
        private System.Windows.Forms.BindingSource adatbazisraktarDataSetBindingSource;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTulajdonos;
        private System.Windows.Forms.ComboBox comboBoxGyarto;
        private System.Windows.Forms.Button buttonfelvitel;
        private System.Windows.Forms.ComboBox comboBoxEszkozallapotaFelvitel;
        private System.Windows.Forms.ComboBox comboBoxEszkoztipusaFelvitel;
        public System.Windows.Forms.TextBox textBoxModelszam;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxOperaciosrendszerfelvitel;
        private System.Windows.Forms.ComboBox comboBoxGpuFelvitel;
        private System.Windows.Forms.ComboBox comboBoxHddFelvitel;
        private System.Windows.Forms.ComboBox comboBoxRamFelvitel;
        private System.Windows.Forms.ComboBox comboBoxCpuFelvitel;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox textBoxMac;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox textBoxComputerneve;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dateTimePickerKiadasiidopont;
        public System.Windows.Forms.DateTimePicker dateTimePickerGarancialejaratiido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxSeriaszam;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxLeirasjegyzet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox textBoxEszkozneve;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxTorles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewOsszesito2;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTermekhozzaadasa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label labelsortema;
        private System.Windows.Forms.Label label1;
    }
}