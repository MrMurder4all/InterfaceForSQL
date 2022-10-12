namespace WindowsFormsApp1
{
    partial class Workers
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
            System.Windows.Forms.Label idWorkerLabel;
            System.Windows.Forms.Label wNameLabel;
            System.Windows.Forms.Label wLNameLabel;
            System.Windows.Forms.Label wPhoneLabel;
            this.turistFirmDataSet = new WindowsFormsApp1.TuristFirmDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager();
            this.idWorkerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wNameTextBox = new System.Windows.Forms.TextBox();
            this.wLNameTextBox = new System.Windows.Forms.TextBox();
            this.button_last = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idWorkerLabel = new System.Windows.Forms.Label();
            wNameLabel = new System.Windows.Forms.Label();
            wLNameLabel = new System.Windows.Forms.Label();
            wPhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idWorkerLabel
            // 
            idWorkerLabel.AutoSize = true;
            idWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idWorkerLabel.Location = new System.Drawing.Point(12, 80);
            idWorkerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idWorkerLabel.Name = "idWorkerLabel";
            idWorkerLabel.Size = new System.Drawing.Size(221, 16);
            idWorkerLabel.TabIndex = 1;
            idWorkerLabel.Text = "Идентификатор сотрудника:";
            // 
            // wNameLabel
            // 
            wNameLabel.AutoSize = true;
            wNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            wNameLabel.Location = new System.Drawing.Point(102, 109);
            wNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            wNameLabel.Name = "wNameLabel";
            wNameLabel.Size = new System.Drawing.Size(131, 16);
            wNameLabel.TabIndex = 4;
            wNameLabel.Text = "Имя сотрудника:";
            // 
            // wLNameLabel
            // 
            wLNameLabel.AutoSize = true;
            wLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            wLNameLabel.Location = new System.Drawing.Point(65, 144);
            wLNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            wLNameLabel.Name = "wLNameLabel";
            wLNameLabel.Size = new System.Drawing.Size(168, 16);
            wLNameLabel.TabIndex = 6;
            wLNameLabel.Text = "Фамилия сотрудника:";
            // 
            // wPhoneLabel
            // 
            wPhoneLabel.AutoSize = true;
            wPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            wPhoneLabel.Location = new System.Drawing.Point(96, 176);
            wPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            wPhoneLabel.Name = "wPhoneLabel";
            wPhoneLabel.Size = new System.Drawing.Size(137, 16);
            wPhoneLabel.TabIndex = 8;
            wPhoneLabel.Text = "Номер телефона:";
            // 
            // turistFirmDataSet
            // 
            this.turistFirmDataSet.DataSetName = "TuristFirmDataSet";
            this.turistFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.DiscountsTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.PackageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // idWorkerTextBox
            // 
            this.idWorkerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "idWorker", true));
            this.idWorkerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idWorkerTextBox.Location = new System.Drawing.Point(241, 77);
            this.idWorkerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idWorkerTextBox.Name = "idWorkerTextBox";
            this.idWorkerTextBox.Size = new System.Drawing.Size(148, 22);
            this.idWorkerTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сотрудники";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wNameTextBox
            // 
            this.wNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WName", true));
            this.wNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wNameTextBox.Location = new System.Drawing.Point(241, 109);
            this.wNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wNameTextBox.Name = "wNameTextBox";
            this.wNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.wNameTextBox.TabIndex = 5;
            // 
            // wLNameTextBox
            // 
            this.wLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WLName", true));
            this.wLNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wLNameTextBox.Location = new System.Drawing.Point(241, 141);
            this.wLNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wLNameTextBox.Name = "wLNameTextBox";
            this.wLNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.wLNameTextBox.TabIndex = 7;
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_last.Location = new System.Drawing.Point(355, 203);
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
            this.button_next.Location = new System.Drawing.Point(241, 203);
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
            this.button_prev.Location = new System.Drawing.Point(127, 203);
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
            this.button_first.Location = new System.Drawing.Point(13, 203);
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
            this.button_save.Location = new System.Drawing.Point(127, 289);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(222, 37);
            this.button_save.TabIndex = 41;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(241, 246);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(108, 37);
            this.button_delete.TabIndex = 40;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new.Location = new System.Drawing.Point(127, 246);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(108, 37);
            this.button_new.TabIndex = 39;
            this.button_new.Text = "Добавить";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WPhone", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(241, 176);
            this.maskedTextBox1.Mask = "9990000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBox1.TabIndex = 42;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(461, 315);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 35);
            this.button_search.TabIndex = 66;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(6, 329);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(343, 20);
            this.label_search.TabIndex = 65;
            this.label_search.Text = "Поиск по идентификатору сотрудника:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(461, 359);
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
            this.label2.Location = new System.Drawing.Point(102, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Поиск по номеру телефона:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.clientDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(542, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 373);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по фамилии";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(350, 322);
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
            this.label3.Location = new System.Drawing.Point(23, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Поиск по фамилии:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 26);
            this.textBox3.TabIndex = 64;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWorkerDataGridViewTextBoxColumn,
            this.wNameDataGridViewTextBoxColumn,
            this.wLNameDataGridViewTextBoxColumn,
            this.wPhoneDataGridViewTextBoxColumn});
            this.clientDataGridView.DataSource = this.workersBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 28);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(484, 288);
            this.clientDataGridView.TabIndex = 0;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "id Сотрудника";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.Width = 141;
            // 
            // wNameDataGridViewTextBoxColumn
            // 
            this.wNameDataGridViewTextBoxColumn.DataPropertyName = "WName";
            this.wNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.wNameDataGridViewTextBoxColumn.Name = "wNameDataGridViewTextBoxColumn";
            // 
            // wLNameDataGridViewTextBoxColumn
            // 
            this.wLNameDataGridViewTextBoxColumn.DataPropertyName = "WLName";
            this.wLNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.wLNameDataGridViewTextBoxColumn.Name = "wLNameDataGridViewTextBoxColumn";
            // 
            // wPhoneDataGridViewTextBoxColumn
            // 
            this.wPhoneDataGridViewTextBoxColumn.DataPropertyName = "WPhone";
            this.wPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.wPhoneDataGridViewTextBoxColumn.Name = "wPhoneDataGridViewTextBoxColumn";
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1243, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_first);
            this.Controls.Add(wPhoneLabel);
            this.Controls.Add(wLNameLabel);
            this.Controls.Add(this.wLNameTextBox);
            this.Controls.Add(wNameLabel);
            this.Controls.Add(this.wNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(idWorkerLabel);
            this.Controls.Add(this.idWorkerTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Workers";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TuristFirmDataSet turistFirmDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private TuristFirmDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private TuristFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idWorkerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wNameTextBox;
        private System.Windows.Forms.TextBox wLNameTextBox;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wPhoneDataGridViewTextBoxColumn;
    }
}