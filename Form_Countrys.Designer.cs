namespace WindowsFormsApp1
{
    partial class Countrys
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
            System.Windows.Forms.Label idCountryLabel;
            System.Windows.Forms.Label countryNameLabel;
            System.Windows.Forms.Label climateLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.turistFirmDataSet = new WindowsFormsApp1.TuristFirmDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.CountryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager();
            this.idCountryTextBox = new System.Windows.Forms.TextBox();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.button_last = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.idCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.climateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idCountryLabel = new System.Windows.Forms.Label();
            countryNameLabel = new System.Windows.Forms.Label();
            climateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idCountryLabel
            // 
            idCountryLabel.AutoSize = true;
            idCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idCountryLabel.Location = new System.Drawing.Point(15, 77);
            idCountryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idCountryLabel.Name = "idCountryLabel";
            idCountryLabel.Size = new System.Drawing.Size(187, 16);
            idCountryLabel.TabIndex = 2;
            idCountryLabel.Text = "Идентификатор страны:";
            // 
            // countryNameLabel
            // 
            countryNameLabel.AutoSize = true;
            countryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countryNameLabel.Location = new System.Drawing.Point(60, 111);
            countryNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            countryNameLabel.Name = "countryNameLabel";
            countryNameLabel.Size = new System.Drawing.Size(142, 16);
            countryNameLabel.TabIndex = 4;
            countryNameLabel.Text = "Название страны:";
            // 
            // climateLabel
            // 
            climateLabel.AutoSize = true;
            climateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            climateLabel.Location = new System.Drawing.Point(137, 145);
            climateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            climateLabel.Name = "climateLabel";
            climateLabel.Size = new System.Drawing.Size(65, 16);
            climateLabel.TabIndex = 6;
            climateLabel.Text = "Климат:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Страны";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turistFirmDataSet
            // 
            this.turistFirmDataSet.DataSetName = "TuristFirmDataSet";
            this.turistFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = this.countryTableAdapter;
            this.tableAdapterManager.DiscountsTableAdapter = null;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.PackageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TuristFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // idCountryTextBox
            // 
            this.idCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "IdCountry", true));
            this.idCountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCountryTextBox.Location = new System.Drawing.Point(212, 74);
            this.idCountryTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.idCountryTextBox.Name = "idCountryTextBox";
            this.idCountryTextBox.Size = new System.Drawing.Size(180, 22);
            this.idCountryTextBox.TabIndex = 3;
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "CountryName", true));
            this.countryNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryNameTextBox.Location = new System.Drawing.Point(212, 108);
            this.countryNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(180, 22);
            this.countryNameTextBox.TabIndex = 5;
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_last.Location = new System.Drawing.Point(350, 173);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(108, 37);
            this.button_last.TabIndex = 25;
            this.button_last.Text = "Последняя";
            this.button_last.UseVisualStyleBackColor = false;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Location = new System.Drawing.Point(236, 173);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(108, 37);
            this.button_next.TabIndex = 24;
            this.button_next.Text = "Следующая";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prev.Location = new System.Drawing.Point(122, 173);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(108, 37);
            this.button_prev.TabIndex = 23;
            this.button_prev.Text = "Предыдущая";
            this.button_prev.UseVisualStyleBackColor = false;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_first
            // 
            this.button_first.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_first.Location = new System.Drawing.Point(8, 173);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(108, 37);
            this.button_first.TabIndex = 22;
            this.button_first.Text = "Первая";
            this.button_first.UseVisualStyleBackColor = false;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(122, 259);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(222, 37);
            this.button_save.TabIndex = 35;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(236, 216);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(108, 37);
            this.button_delete.TabIndex = 34;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new.Location = new System.Drawing.Point(122, 216);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(108, 37);
            this.button_new.TabIndex = 33;
            this.button_new.Text = "Добавить";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Climate", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(211, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 36;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(434, 296);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 35);
            this.button_search.TabIndex = 57;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(16, 308);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(306, 20);
            this.label_search.TabIndex = 56;
            this.label_search.Text = "Поиск по идентификатору страны:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.clientDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(515, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 373);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по фамилии";
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
            this.label3.Location = new System.Drawing.Point(6, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Сортировка по климату:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 29);
            this.textBox3.TabIndex = 64;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCountryDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn,
            this.climateDataGridViewTextBoxColumn});
            this.clientDataGridView.DataSource = this.countryBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 28);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(512, 288);
            this.clientDataGridView.TabIndex = 0;
            // 
            // idCountryDataGridViewTextBoxColumn
            // 
            this.idCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCountryDataGridViewTextBoxColumn.DataPropertyName = "IdCountry";
            this.idCountryDataGridViewTextBoxColumn.HeaderText = "Id Страны";
            this.idCountryDataGridViewTextBoxColumn.Name = "idCountryDataGridViewTextBoxColumn";
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Название страны";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            // 
            // climateDataGridViewTextBoxColumn
            // 
            this.climateDataGridViewTextBoxColumn.DataPropertyName = "Climate";
            this.climateDataGridViewTextBoxColumn.HeaderText = "Климат";
            this.climateDataGridViewTextBoxColumn.Name = "climateDataGridViewTextBoxColumn";
            // 
            // Countrys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1093, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_first);
            this.Controls.Add(climateLabel);
            this.Controls.Add(countryNameLabel);
            this.Controls.Add(this.countryNameTextBox);
            this.Controls.Add(idCountryLabel);
            this.Controls.Add(this.idCountryTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Countrys";
            this.Text = "Страны";
            this.Load += new System.EventHandler(this.Form_Countrys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turistFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TuristFirmDataSet turistFirmDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private TuristFirmDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private TuristFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idCountryTextBox;
        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.BindingSource countryBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn climateDataGridViewTextBoxColumn;
    }
}