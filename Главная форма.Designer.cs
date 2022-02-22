namespace Модель_системы_полётов
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InstrumentPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkM = new System.Windows.Forms.CheckBox();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.checkP = new System.Windows.Forms.CheckBox();
            this.colorVisible3 = new System.Windows.Forms.Button();
            this.colorVisible2 = new System.Windows.Forms.Button();
            this.colorVisible1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.startRaise = new System.Windows.Forms.Button();
            this.BazaAirplaneRaise = new System.Windows.Forms.Button();
            this.closePanel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formAirplane = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DelAirplane = new System.Windows.Forms.Button();
            this.there = new System.Windows.Forms.ComboBox();
            this.where = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cargo_air = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.departureTime = new System.Windows.Forms.DateTimePicker();
            this.arrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontSize = new System.Windows.Forms.Button();
            this.colorCity = new System.Windows.Forms.Button();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.Deserializable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Serializable = new System.Windows.Forms.Button();
            this.OpenAirportBaza = new System.Windows.Forms.Button();
            this.DelAirport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectType = new System.Windows.Forms.ComboBox();
            this.AddAirport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CityAirport = new System.Windows.Forms.TextBox();
            this.Подсказка = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.showPanel = new System.Windows.Forms.Button();
            this.InstrumentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstrumentPanel
            // 
            this.InstrumentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstrumentPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InstrumentPanel.Controls.Add(this.panel3);
            this.InstrumentPanel.Controls.Add(this.closePanel);
            this.InstrumentPanel.Controls.Add(this.panel2);
            this.InstrumentPanel.Controls.Add(this.label5);
            this.InstrumentPanel.Controls.Add(this.label1);
            this.InstrumentPanel.Controls.Add(this.panel1);
            this.InstrumentPanel.Location = new System.Drawing.Point(1025, 0);
            this.InstrumentPanel.MaximumSize = new System.Drawing.Size(234, 0);
            this.InstrumentPanel.MinimumSize = new System.Drawing.Size(234, 861);
            this.InstrumentPanel.Name = "InstrumentPanel";
            this.InstrumentPanel.Size = new System.Drawing.Size(234, 861);
            this.InstrumentPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.checkM);
            this.panel3.Controls.Add(this.checkC);
            this.panel3.Controls.Add(this.checkP);
            this.panel3.Controls.Add(this.colorVisible3);
            this.panel3.Controls.Add(this.colorVisible2);
            this.panel3.Controls.Add(this.colorVisible1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.startRaise);
            this.panel3.Controls.Add(this.BazaAirplaneRaise);
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 167);
            this.panel3.TabIndex = 17;
            // 
            // checkM
            // 
            this.checkM.Location = new System.Drawing.Point(13, 125);
            this.checkM.Name = "checkM";
            this.checkM.Size = new System.Drawing.Size(82, 23);
            this.checkM.TabIndex = 28;
            this.checkM.Text = "Военные";
            this.checkM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkM.UseVisualStyleBackColor = true;
            this.checkM.CheckedChanged += new System.EventHandler(this.checkM_CheckedChanged);
            // 
            // checkC
            // 
            this.checkC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkC.Location = new System.Drawing.Point(13, 100);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(87, 23);
            this.checkC.TabIndex = 27;
            this.checkC.Text = "Грузовые";
            this.checkC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkC.UseVisualStyleBackColor = true;
            this.checkC.CheckedChanged += new System.EventHandler(this.checkC_CheckedChanged);
            // 
            // checkP
            // 
            this.checkP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkP.Location = new System.Drawing.Point(13, 75);
            this.checkP.Name = "checkP";
            this.checkP.Size = new System.Drawing.Size(115, 23);
            this.checkP.TabIndex = 2;
            this.checkP.Text = "Пассажирские";
            this.checkP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkP.UseVisualStyleBackColor = true;
            this.checkP.CheckedChanged += new System.EventHandler(this.checkP_CheckedChanged);
            // 
            // colorVisible3
            // 
            this.colorVisible3.Location = new System.Drawing.Point(128, 125);
            this.colorVisible3.Name = "colorVisible3";
            this.colorVisible3.Size = new System.Drawing.Size(93, 23);
            this.colorVisible3.TabIndex = 26;
            this.colorVisible3.Text = "Цвет";
            this.colorVisible3.UseVisualStyleBackColor = true;
            this.colorVisible3.Click += new System.EventHandler(this.colorVisible3_Click);
            // 
            // colorVisible2
            // 
            this.colorVisible2.Location = new System.Drawing.Point(128, 100);
            this.colorVisible2.Name = "colorVisible2";
            this.colorVisible2.Size = new System.Drawing.Size(93, 23);
            this.colorVisible2.TabIndex = 25;
            this.colorVisible2.Text = "Цвет";
            this.colorVisible2.UseVisualStyleBackColor = true;
            this.colorVisible2.Click += new System.EventHandler(this.colorVisible2_Click);
            // 
            // colorVisible1
            // 
            this.colorVisible1.Location = new System.Drawing.Point(128, 75);
            this.colorVisible1.Name = "colorVisible1";
            this.colorVisible1.Size = new System.Drawing.Size(93, 23);
            this.colorVisible1.TabIndex = 20;
            this.colorVisible1.Text = "Цвет";
            this.colorVisible1.UseVisualStyleBackColor = true;
            this.colorVisible1.Click += new System.EventHandler(this.colorVisible_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Показать траекторию полётов";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startRaise
            // 
            this.startRaise.BackColor = System.Drawing.Color.DarkOrange;
            this.startRaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startRaise.Location = new System.Drawing.Point(9, 12);
            this.startRaise.Name = "startRaise";
            this.startRaise.Size = new System.Drawing.Size(100, 23);
            this.startRaise.TabIndex = 15;
            this.startRaise.Text = "Запустить";
            this.Подсказка.SetToolTip(this.startRaise, "Заполните данные о каждом рейсе (по порядку) и нажмите сюда\r\n");
            this.startRaise.UseVisualStyleBackColor = false;
            this.startRaise.Click += new System.EventHandler(this.startRaise_Click);
            // 
            // BazaAirplaneRaise
            // 
            this.BazaAirplaneRaise.Location = new System.Drawing.Point(123, 12);
            this.BazaAirplaneRaise.Name = "BazaAirplaneRaise";
            this.BazaAirplaneRaise.Size = new System.Drawing.Size(100, 23);
            this.BazaAirplaneRaise.TabIndex = 14;
            this.BazaAirplaneRaise.Text = "База самолётов";
            this.Подсказка.SetToolTip(this.BazaAirplaneRaise, "Кликните для открытия базы рейсов со всеми их характеристиками");
            this.BazaAirplaneRaise.UseVisualStyleBackColor = true;
            this.BazaAirplaneRaise.Click += new System.EventHandler(this.BazaAirplaneRaise_Click);
            // 
            // closePanel
            // 
            this.closePanel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closePanel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closePanel.Location = new System.Drawing.Point(0, 0);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(20, 20);
            this.closePanel.TabIndex = 2;
            this.closePanel.Text = "-";
            this.closePanel.UseVisualStyleBackColor = true;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.formAirplane);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DelAirplane);
            this.panel2.Controls.Add(this.there);
            this.panel2.Controls.Add(this.where);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Controls.Add(this.combo);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.cargo_air);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.speed);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.departureTime);
            this.panel2.Controls.Add(this.arrivalTime);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 211);
            this.panel2.TabIndex = 8;
            // 
            // formAirplane
            // 
            this.formAirplane.FormattingEnabled = true;
            this.formAirplane.Items.AddRange(new object[] {
            "Рисунок №1",
            "Рисунок №2",
            "Рисунок №3"});
            this.formAirplane.Location = new System.Drawing.Point(100, 40);
            this.formAirplane.Name = "formAirplane";
            this.formAirplane.Size = new System.Drawing.Size(121, 21);
            this.formAirplane.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Вид самолёта:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelAirplane
            // 
            this.DelAirplane.Location = new System.Drawing.Point(123, 181);
            this.DelAirplane.Name = "DelAirplane";
            this.DelAirplane.Size = new System.Drawing.Size(100, 23);
            this.DelAirplane.TabIndex = 23;
            this.DelAirplane.Text = "Удалить";
            this.Подсказка.SetToolTip(this.DelAirplane, "Для отмены рейса дважды кликните по нужному самолёту\r\n");
            this.DelAirplane.UseVisualStyleBackColor = true;
            this.DelAirplane.Click += new System.EventHandler(this.DelAirplane_Click);
            // 
            // there
            // 
            this.there.FormattingEnabled = true;
            this.there.Location = new System.Drawing.Point(165, 69);
            this.there.Name = "there";
            this.there.Size = new System.Drawing.Size(56, 21);
            this.there.TabIndex = 3;
            // 
            // where
            // 
            this.where.FormattingEnabled = true;
            this.where.Location = new System.Drawing.Point(64, 69);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(56, 21);
            this.where.TabIndex = 2;
            this.where.Tag = "";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(9, 181);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 23);
            this.Save.TabIndex = 22;
            this.Save.Text = "Сохранить";
            this.Подсказка.SetToolTip(this.Save, "Нажмите для сохранения и записи нового рейса");
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save1_Click);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "Пассажирский",
            "Грузовой",
            "Военный"});
            this.combo.Location = new System.Drawing.Point(100, 11);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(121, 21);
            this.combo.TabIndex = 1;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Gold;
            this.label36.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(9, 11);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(85, 21);
            this.label36.TabIndex = 20;
            this.label36.Text = "Тип самолёта:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cargo_air
            // 
            this.cargo_air.Location = new System.Drawing.Point(191, 153);
            this.cargo_air.Multiline = true;
            this.cargo_air.Name = "cargo_air";
            this.cargo_air.Size = new System.Drawing.Size(30, 21);
            this.cargo_air.TabIndex = 7;
            this.cargo_air.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gold;
            this.label10.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Откуда:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Gold;
            this.label27.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(107, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 21);
            this.label27.TabIndex = 18;
            this.label27.Text = "Вместимость:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Куда:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(72, 153);
            this.speed.Multiline = true;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(30, 21);
            this.speed.TabIndex = 6;
            this.speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gold;
            this.label12.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Вылет:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Gold;
            this.label26.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(9, 153);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 21);
            this.label26.TabIndex = 16;
            this.label26.Text = "Скорость:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departureTime
            // 
            this.departureTime.Location = new System.Drawing.Point(61, 97);
            this.departureTime.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.departureTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(160, 20);
            this.departureTime.TabIndex = 4;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(61, 125);
            this.arrivalTime.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.arrivalTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(160, 20);
            this.arrivalTime.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gold;
            this.label13.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Прилёт:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Конструктор рейсов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Конструктор аэропортов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.fontSize);
            this.panel1.Controls.Add(this.colorCity);
            this.panel1.Controls.Add(this.Capacity);
            this.panel1.Controls.Add(this.Deserializable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Serializable);
            this.panel1.Controls.Add(this.OpenAirportBaza);
            this.panel1.Controls.Add(this.DelAirport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SelectType);
            this.panel1.Controls.Add(this.AddAirport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CityAirport);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.MaximumSize = new System.Drawing.Size(234, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 150);
            this.panel1.TabIndex = 6;
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(123, 120);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(100, 23);
            this.fontSize.TabIndex = 15;
            this.fontSize.Text = "Размер шрифта";
            this.fontSize.UseVisualStyleBackColor = true;
            this.fontSize.Click += new System.EventHandler(this.fontSize_Click);
            // 
            // colorCity
            // 
            this.colorCity.Location = new System.Drawing.Point(9, 120);
            this.colorCity.Name = "colorCity";
            this.colorCity.Size = new System.Drawing.Size(100, 23);
            this.colorCity.TabIndex = 14;
            this.colorCity.Text = "Цвет города";
            this.colorCity.UseVisualStyleBackColor = true;
            this.colorCity.Click += new System.EventHandler(this.colorCity_Click);
            // 
            // Capacity
            // 
            this.Capacity.Location = new System.Drawing.Point(54, 40);
            this.Capacity.Multiline = true;
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(31, 21);
            this.Capacity.TabIndex = 13;
            this.Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Deserializable
            // 
            this.Deserializable.Location = new System.Drawing.Point(123, 95);
            this.Deserializable.Name = "Deserializable";
            this.Deserializable.Size = new System.Drawing.Size(100, 23);
            this.Deserializable.TabIndex = 0;
            this.Deserializable.Text = "Загрузить";
            this.Подсказка.SetToolTip(this.Deserializable, "Нажмите чтобы воспроизвести объекты");
            this.Deserializable.UseVisualStyleBackColor = true;
            this.Deserializable.Click += new System.EventHandler(this.Deserializable_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Гараж:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Serializable
            // 
            this.Serializable.Location = new System.Drawing.Point(9, 95);
            this.Serializable.Name = "Serializable";
            this.Serializable.Size = new System.Drawing.Size(100, 23);
            this.Serializable.TabIndex = 9;
            this.Serializable.Text = "Сохранить";
            this.Подсказка.SetToolTip(this.Serializable, "Нажмите чтобы сохранить объекты");
            this.Serializable.UseVisualStyleBackColor = true;
            this.Serializable.Click += new System.EventHandler(this.Serializable_Click);
            // 
            // OpenAirportBaza
            // 
            this.OpenAirportBaza.Location = new System.Drawing.Point(9, 70);
            this.OpenAirportBaza.Name = "OpenAirportBaza";
            this.OpenAirportBaza.Size = new System.Drawing.Size(214, 23);
            this.OpenAirportBaza.TabIndex = 11;
            this.OpenAirportBaza.Text = "Открыть базу аэропортов";
            this.Подсказка.SetToolTip(this.OpenAirportBaza, "Кликните для открытия базы аэропортов со всеми их характеристиками");
            this.OpenAirportBaza.UseVisualStyleBackColor = true;
            this.OpenAirportBaza.Click += new System.EventHandler(this.OpenAirportBaza_Click_1);
            // 
            // DelAirport
            // 
            this.DelAirport.Location = new System.Drawing.Point(161, 40);
            this.DelAirport.Name = "DelAirport";
            this.DelAirport.Size = new System.Drawing.Size(66, 23);
            this.DelAirport.TabIndex = 9;
            this.DelAirport.Text = "Удалить";
            this.Подсказка.SetToolTip(this.DelAirport, "Для удаления аэропорта дважды кликните по нему ");
            this.DelAirport.UseVisualStyleBackColor = true;
            this.DelAirport.Click += new System.EventHandler(this.DelAirport_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(110, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectType
            // 
            this.SelectType.FormattingEnabled = true;
            this.SelectType.Items.AddRange(new object[] {
            "Пассажирский",
            "Грузовой",
            "Военный"});
            this.SelectType.Location = new System.Drawing.Point(147, 6);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(80, 21);
            this.SelectType.TabIndex = 7;
            // 
            // AddAirport
            // 
            this.AddAirport.Location = new System.Drawing.Point(88, 40);
            this.AddAirport.Name = "AddAirport";
            this.AddAirport.Size = new System.Drawing.Size(66, 23);
            this.AddAirport.TabIndex = 6;
            this.AddAirport.Text = "Добавить";
            this.Подсказка.SetToolTip(this.AddAirport, "Для создания аэропорта нажмите на эту кнопку, \r\nзатем кликните мышкой в нужное ме" +
        "сто на карте.\r\n");
            this.AddAirport.UseVisualStyleBackColor = true;
            this.AddAirport.Click += new System.EventHandler(this.AddAirport_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Город:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CityAirport
            // 
            this.CityAirport.Location = new System.Drawing.Point(54, 6);
            this.CityAirport.Multiline = true;
            this.CityAirport.Name = "CityAirport";
            this.CityAirport.Size = new System.Drawing.Size(50, 21);
            this.CityAirport.TabIndex = 3;
            this.CityAirport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // showPanel
            // 
            this.showPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showPanel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showPanel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPanel.Location = new System.Drawing.Point(1005, 0);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(20, 20);
            this.showPanel.TabIndex = 0;
            this.showPanel.Text = "+";
            this.showPanel.UseVisualStyleBackColor = true;
            this.showPanel.Click += new System.EventHandler(this.showPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Модель_системы_полётов.Properties.Resources.world;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 749);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.InstrumentPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Симулятор авиарейсов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.InstrumentPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel InstrumentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CityAirport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddAirport;
        private System.Windows.Forms.ToolTip Подсказка;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectType;
        private System.Windows.Forms.Button DelAirport;
        private System.Windows.Forms.Button OpenAirportBaza;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker arrivalTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker departureTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BazaAirplaneRaise;
        private System.Windows.Forms.Button startRaise;
        private System.Windows.Forms.TextBox cargo_air;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox there;
        private System.Windows.Forms.ComboBox where;
        private System.Windows.Forms.Button Serializable;
        private System.Windows.Forms.Button Deserializable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button colorVisible1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button DelAirplane;
        private System.Windows.Forms.ComboBox formAirplane;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button colorVisible3;
        private System.Windows.Forms.Button colorVisible2;
        private System.Windows.Forms.CheckBox checkM;
        private System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.CheckBox checkP;
        private System.Windows.Forms.Button fontSize;
        private System.Windows.Forms.Button colorCity;
        private System.Windows.Forms.Button closePanel;
        private System.Windows.Forms.Button showPanel;
    }
}

