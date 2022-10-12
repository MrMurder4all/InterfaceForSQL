namespace WindowsFormsApp1
{
    partial class Hotels
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
            System.Windows.Forms.Label idHotelLabel;
            System.Windows.Forms.Label idCountryLabel;
            System.Windows.Forms.Label hNameLabel;
            System.Windows.Forms.Label hotelClassLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.turistFirmDataSet = new WindowsFormsApp1.TuristFirmDataSet();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.HotelsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager();
            this.idHotelTextBox = new System.Windows.Forms.TextBox();
            this.hNameTextBox = new System.Windows.Forms.TextBox();
            this.hotelClassTextBox = new System.Windows.Forms.TextBox();
            this.button_last = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.CountryTableAdapter();
            this.button_search = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.idHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idHotelLabel = new System.Windows.Forms.Label();
            idCountryLabel = new System.Windows.Forms.Label();
            hNameLabel = new System.Windows.Forms.Label();
            hotelClassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idHotelLabel
            // 
            idHotelLabel.AutoSize = true;
            idHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idHotelLabel.Location = new System.Drawing.Point(26, 96);
            idHotelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idHotelLabel.Name = "idHotelLabel";
            idHotelLabel.Size = new System.Drawing.Size(177, 16);
            idHotelLabel.TabIndex = 2;
            idHotelLabel.Text = "Идентификатор отеля:";
            // 
            // idCountryLabel
            // 
            idCountryLabel.AutoSize = true;
            idCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idCountryLabel.Location = new System.Drawing.Point(18, 126);
            idCountryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idCountryLabel.Name = "idCountryLabel";
            idCountryLabel.Size = new System.Drawing.Size(187, 16);
            idCountryLabel.TabIndex = 4;
            idCountryLabel.Text = "Идентификатор страны:";
            // 
            // hNameLabel
            // 
            hNameLabel.AutoSize = true;
            hNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            hNameLabel.Location = new System.Drawing.Point(71, 158);
            hNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            hNameLabel.Name = "hNameLabel";
            hNameLabel.Size = new System.Drawing.Size(132, 16);
            hNameLabel.TabIndex = 6;
            hNameLabel.Text = "Название отеля:";
            // 
            // hotelClassLabel
            // 
            hotelClassLabel.AutoSize = true;
            hotelClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            hotelClassLabel.Location = new System.Drawing.Point(102, 186);
            hotelClassLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            hotelClassLabel.Name = "hotelClassLabel";
            hotelClassLabel.Size = new System.Drawing.Size(101, 16);
            hotelClassLabel.TabIndex = 8;
            hotelClassLabel.Text = "Класс отеля:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1019, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отели";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turistFirmDataSet
            // 
            this.turistFirmDataSet.DataSetName = "TuristFirmDataSet";
            this.turistFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.turistFirmDataSet;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.DiscountsTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = this.hotelsTableAdapter;
            this.tableAdapterManager.PackageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // idHotelTextBox
            // 
            this.idHotelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "IdHotel", true));
            this.idHotelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idHotelTextBox.Location = new System.Drawing.Point(213, 93);
            this.idHotelTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.idHotelTextBox.Name = "idHotelTextBox";
            this.idHotelTextBox.Size = new System.Drawing.Size(148, 22);
            this.idHotelTextBox.TabIndex = 3;
            // 
            // hNameTextBox
            // 
            this.hNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "HName", true));
            this.hNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hNameTextBox.Location = new System.Drawing.Point(213, 155);
            this.hNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.hNameTextBox.Name = "hNameTextBox";
            this.hNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.hNameTextBox.TabIndex = 7;
            // 
            // hotelClassTextBox
            // 
            this.hotelClassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "HotelClass", true));
            this.hotelClassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelClassTextBox.Location = new System.Drawing.Point(213, 183);
            this.hotelClassTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.hotelClassTextBox.Name = "hotelClassTextBox";
            this.hotelClassTextBox.Size = new System.Drawing.Size(148, 22);
            this.hotelClassTextBox.TabIndex = 9;
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_last.Location = new System.Drawing.Point(356, 217);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(108, 37);
            this.button_last.TabIndex = 29;
            this.button_last.Text = "Последняя";
            this.button_last.UseVisualStyleBackColor = false;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Location = new System.Drawing.Point(242, 217);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(108, 37);
            this.button_next.TabIndex = 28;
            this.button_next.Text = "Следующая";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prev.Location = new System.Drawing.Point(128, 217);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(108, 37);
            this.button_prev.TabIndex = 27;
            this.button_prev.Text = "Предыдущая";
            this.button_prev.UseVisualStyleBackColor = false;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_first
            // 
            this.button_first.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_first.Location = new System.Drawing.Point(14, 217);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(108, 37);
            this.button_first.TabIndex = 26;
            this.button_first.Text = "Первая";
            this.button_first.UseVisualStyleBackColor = false;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(128, 303);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(222, 37);
            this.button_save.TabIndex = 38;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(242, 260);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(108, 37);
            this.button_delete.TabIndex = 37;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new.Location = new System.Drawing.Point(128, 260);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(108, 37);
            this.button_new.TabIndex = 36;
            this.button_new.Text = "Добавить";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hotelsBindingSource, "IdCountry", true));
            this.comboBox1.DataSource = this.countryBindingSource;
            this.comboBox1.DisplayMember = "IdCountry";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.ValueMember = "IdCountry";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.turistFirmDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(422, 336);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 35);
            this.button_search.TabIndex = 63;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(14, 348);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(296, 20);
            this.label_search.TabIndex = 62;
            this.label_search.Text = "Поиск по идентификатору отеля:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.clientDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(503, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 417);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по фамилии";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(374, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 69;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Сортировка по стране:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 26);
            this.textBox2.TabIndex = 67;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(374, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 66;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Сортировка по классу:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 26);
            this.textBox3.TabIndex = 64;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHotelDataGridViewTextBoxColumn,
            this.idCountryDataGridViewTextBoxColumn,
            this.hNameDataGridViewTextBoxColumn,
            this.hotelClassDataGridViewTextBoxColumn});
            this.clientDataGridView.DataSource = this.hotelsBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 28);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(512, 288);
            this.clientDataGridView.TabIndex = 0;
            // 
            // idHotelDataGridViewTextBoxColumn
            // 
            this.idHotelDataGridViewTextBoxColumn.DataPropertyName = "IdHotel";
            this.idHotelDataGridViewTextBoxColumn.HeaderText = "Id Отеля";
            this.idHotelDataGridViewTextBoxColumn.Name = "idHotelDataGridViewTextBoxColumn";
            // 
            // idCountryDataGridViewTextBoxColumn
            // 
            this.idCountryDataGridViewTextBoxColumn.DataPropertyName = "IdCountry";
            this.idCountryDataGridViewTextBoxColumn.HeaderText = "Id страны";
            this.idCountryDataGridViewTextBoxColumn.Name = "idCountryDataGridViewTextBoxColumn";
            // 
            // hNameDataGridViewTextBoxColumn
            // 
            this.hNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hNameDataGridViewTextBoxColumn.DataPropertyName = "HName";
            this.hNameDataGridViewTextBoxColumn.HeaderText = "Название отеля";
            this.hNameDataGridViewTextBoxColumn.Name = "hNameDataGridViewTextBoxColumn";
            // 
            // hotelClassDataGridViewTextBoxColumn
            // 
            this.hotelClassDataGridViewTextBoxColumn.DataPropertyName = "HotelClass";
            this.hotelClassDataGridViewTextBoxColumn.HeaderText = "Класс отеля";
            this.hotelClassDataGridViewTextBoxColumn.Name = "hotelClassDataGridViewTextBoxColumn";
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1113, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_first);
            this.Controls.Add(hotelClassLabel);
            this.Controls.Add(this.hotelClassTextBox);
            this.Controls.Add(hNameLabel);
            this.Controls.Add(this.hNameTextBox);
            this.Controls.Add(idCountryLabel);
            this.Controls.Add(idHotelLabel);
            this.Controls.Add(this.idHotelTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Hotels";
            this.Text = "Отели";
            this.Load += new System.EventHandler(this.Hotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TuristFirmDataSet turistFirmDataSet;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TuristFirmDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private TuristFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idHotelTextBox;
        private System.Windows.Forms.TextBox hNameTextBox;
        private System.Windows.Forms.TextBox hotelClassTextBox;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private TuristFirmDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelClassDataGridViewTextBoxColumn;
    }
}