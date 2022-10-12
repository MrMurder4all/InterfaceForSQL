namespace WindowsFormsApp1
{
    partial class Package
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
            System.Windows.Forms.Label idPackageLabel;
            System.Windows.Forms.Label idClientLabel;
            System.Windows.Forms.Label idHotelLabel;
            System.Windows.Forms.Label idWorkerLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label idDiscountLabel;
            System.Windows.Forms.Label depDateLabel;
            this.turistFirmDataSet = new WindowsFormsApp1.TuristFirmDataSet();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.PackageTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.depDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_first = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.idPackageTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.ClientTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelsTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.HotelsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.WorkersTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountsTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.DiscountsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.idPackageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            idPackageLabel = new System.Windows.Forms.Label();
            idClientLabel = new System.Windows.Forms.Label();
            idHotelLabel = new System.Windows.Forms.Label();
            idWorkerLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            idDiscountLabel = new System.Windows.Forms.Label();
            depDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idPackageLabel
            // 
            idPackageLabel.AutoSize = true;
            idPackageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idPackageLabel.Location = new System.Drawing.Point(74, 66);
            idPackageLabel.Name = "idPackageLabel";
            idPackageLabel.Size = new System.Drawing.Size(195, 16);
            idPackageLabel.TabIndex = 1;
            idPackageLabel.Text = "Идентификатор путёвки:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idClientLabel.Location = new System.Drawing.Point(74, 94);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(195, 16);
            idClientLabel.TabIndex = 3;
            idClientLabel.Text = "Идентификатор клиента:";
            // 
            // idHotelLabel
            // 
            idHotelLabel.AutoSize = true;
            idHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idHotelLabel.Location = new System.Drawing.Point(92, 122);
            idHotelLabel.Name = "idHotelLabel";
            idHotelLabel.Size = new System.Drawing.Size(177, 16);
            idHotelLabel.TabIndex = 5;
            idHotelLabel.Text = "Идентификатор отеля:";
            // 
            // idWorkerLabel
            // 
            idWorkerLabel.AutoSize = true;
            idWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idWorkerLabel.Location = new System.Drawing.Point(48, 150);
            idWorkerLabel.Name = "idWorkerLabel";
            idWorkerLabel.Size = new System.Drawing.Size(221, 16);
            idWorkerLabel.TabIndex = 7;
            idWorkerLabel.Text = "Идентификатор сотрудника:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            durationLabel.Location = new System.Drawing.Point(107, 178);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(162, 16);
            durationLabel.TabIndex = 9;
            durationLabel.Text = "Продолжительность:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(218, 206);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 16);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Цена:";
            // 
            // idDiscountLabel
            // 
            idDiscountLabel.AutoSize = true;
            idDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idDiscountLabel.Location = new System.Drawing.Point(84, 233);
            idDiscountLabel.Name = "idDiscountLabel";
            idDiscountLabel.Size = new System.Drawing.Size(185, 16);
            idDiscountLabel.TabIndex = 13;
            idDiscountLabel.Text = "Идентификатор скидки:";
            // 
            // depDateLabel
            // 
            depDateLabel.AutoSize = true;
            depDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            depDateLabel.Location = new System.Drawing.Point(121, 262);
            depDateLabel.Name = "depDateLabel";
            depDateLabel.Size = new System.Drawing.Size(148, 16);
            depDateLabel.TabIndex = 15;
            depDateLabel.Text = "Дата отправления:";
            // 
            // turistFirmDataSet
            // 
            this.turistFirmDataSet.DataSetName = "TuristFirmDataSet";
            this.turistFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataMember = "Package";
            this.packageBindingSource.DataSource = this.turistFirmDataSet;
            // 
            // packageTableAdapter
            // 
            this.packageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.DiscountsTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.PackageTableAdapter = this.packageTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(274, 175);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 22);
            this.durationTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(274, 203);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 12;
            // 
            // depDateDateTimePicker
            // 
            this.depDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "DepDate", true));
            this.depDateDateTimePicker.Location = new System.Drawing.Point(274, 258);
            this.depDateDateTimePicker.Name = "depDateDateTimePicker";
            this.depDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.depDateDateTimePicker.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "Путёвки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_first
            // 
            this.button_first.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_first.Location = new System.Drawing.Point(17, 290);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(108, 37);
            this.button_first.TabIndex = 18;
            this.button_first.Text = "Первая";
            this.button_first.UseVisualStyleBackColor = false;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prev.Location = new System.Drawing.Point(131, 290);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(108, 37);
            this.button_prev.TabIndex = 19;
            this.button_prev.Text = "Предыдущая";
            this.button_prev.UseVisualStyleBackColor = false;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next.Location = new System.Drawing.Point(245, 290);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(108, 37);
            this.button_next.TabIndex = 20;
            this.button_next.Text = "Следующая";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_last.Location = new System.Drawing.Point(359, 290);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(108, 37);
            this.button_last.TabIndex = 21;
            this.button_last.Text = "Последняя";
            this.button_last.UseVisualStyleBackColor = false;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(131, 376);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(222, 37);
            this.button_save.TabIndex = 44;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(245, 333);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(108, 37);
            this.button_delete.TabIndex = 43;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new.Location = new System.Drawing.Point(131, 333);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(108, 37);
            this.button_new.TabIndex = 42;
            this.button_new.Text = "Добавить";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // idPackageTextBox
            // 
            this.idPackageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "IdPackage", true));
            this.idPackageTextBox.Location = new System.Drawing.Point(274, 63);
            this.idPackageTextBox.Name = "idPackageTextBox";
            this.idPackageTextBox.Size = new System.Drawing.Size(100, 22);
            this.idPackageTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packageBindingSource, "IdClient", true));
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "IdClient";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "IdClient";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.turistFirmDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packageBindingSource, "IdHotel", true));
            this.comboBox2.DataSource = this.hotelsBindingSource;
            this.comboBox2.DisplayMember = "IdHotel";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(274, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 46;
            this.comboBox2.ValueMember = "IdHotel";
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
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "IdWorker", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packageBindingSource, "IdWorker", true));
            this.comboBox3.DataSource = this.workersBindingSource;
            this.comboBox3.DisplayMember = "idWorker";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(276, 148);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(98, 24);
            this.comboBox3.TabIndex = 47;
            this.comboBox3.ValueMember = "idWorker";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.turistFirmDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packageBindingSource, "IdDiscount", true));
            this.comboBox4.DataSource = this.discountsBindingSource;
            this.comboBox4.DisplayMember = "IdDiscount";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(276, 231);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(98, 24);
            this.comboBox4.TabIndex = 48;
            this.comboBox4.ValueMember = "IdDiscount";
            // 
            // discountsBindingSource
            // 
            this.discountsBindingSource.DataMember = "Discounts";
            this.discountsBindingSource.DataSource = this.turistFirmDataSet;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 49;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(-2, 429);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(312, 20);
            this.label_search.TabIndex = 50;
            this.label_search.Text = "Поиск по идентификатору путёвки:";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(417, 416);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 35);
            this.button_search.TabIndex = 51;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.clientDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(509, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 447);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по фамилии";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(490, 369);
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
            this.label2.Location = new System.Drawing.Point(101, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Сортировка по id Клиента:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 375);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 67;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(490, 328);
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
            this.label3.Location = new System.Drawing.Point(122, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Сортировка по id отеля:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(343, 334);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 64;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPackageDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.idHotelDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idDiscountDataGridViewTextBoxColumn,
            this.depDateDataGridViewTextBoxColumn});
            this.clientDataGridView.DataSource = this.packageBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 28);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(826, 288);
            this.clientDataGridView.TabIndex = 0;
            // 
            // idPackageDataGridViewTextBoxColumn
            // 
            this.idPackageDataGridViewTextBoxColumn.DataPropertyName = "IdPackage";
            this.idPackageDataGridViewTextBoxColumn.HeaderText = "Id Путёвки";
            this.idPackageDataGridViewTextBoxColumn.Name = "idPackageDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "Id Клиента";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            // 
            // idHotelDataGridViewTextBoxColumn
            // 
            this.idHotelDataGridViewTextBoxColumn.DataPropertyName = "IdHotel";
            this.idHotelDataGridViewTextBoxColumn.HeaderText = "Id Отеля";
            this.idHotelDataGridViewTextBoxColumn.Name = "idHotelDataGridViewTextBoxColumn";
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "Id Сотрудника";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Продолжительность";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // idDiscountDataGridViewTextBoxColumn
            // 
            this.idDiscountDataGridViewTextBoxColumn.DataPropertyName = "IdDiscount";
            this.idDiscountDataGridViewTextBoxColumn.HeaderText = "Id Скидки";
            this.idDiscountDataGridViewTextBoxColumn.Name = "idDiscountDataGridViewTextBoxColumn";
            // 
            // depDateDataGridViewTextBoxColumn
            // 
            this.depDateDataGridViewTextBoxColumn.DataPropertyName = "DepDate";
            this.depDateDataGridViewTextBoxColumn.HeaderText = "Дата отпр";
            this.depDateDataGridViewTextBoxColumn.Name = "depDateDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(490, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 72;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Сортировка по id сотрудника:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(343, 412);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 70;
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1359, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_first);
            this.Controls.Add(this.label1);
            this.Controls.Add(depDateLabel);
            this.Controls.Add(this.depDateDateTimePicker);
            this.Controls.Add(idDiscountLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(idWorkerLabel);
            this.Controls.Add(idHotelLabel);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(idPackageLabel);
            this.Controls.Add(this.idPackageTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Package";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.Package_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TuristFirmDataSet turistFirmDataSet;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private TuristFirmDataSetTableAdapters.PackageTableAdapter packageTableAdapter;
        private TuristFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker depDateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.TextBox idPackageTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private TuristFirmDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TuristFirmDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private TuristFirmDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private TuristFirmDataSetTableAdapters.DiscountsTableAdapter discountsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPackageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDateDataGridViewTextBoxColumn;
    }
}