namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_clients = new System.Windows.Forms.Button();
            this.button_workers = new System.Windows.Forms.Button();
            this.button_hotels = new System.Windows.Forms.Button();
            this.button_countrys = new System.Windows.Forms.Button();
            this.button_discounts = new System.Windows.Forms.Button();
            this.button_package = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных \"Туристическая фирма\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_clients
            // 
            this.button_clients.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clients.Location = new System.Drawing.Point(303, 105);
            this.button_clients.Name = "button_clients";
            this.button_clients.Size = new System.Drawing.Size(188, 37);
            this.button_clients.TabIndex = 1;
            this.button_clients.Text = "Таблица \"Клиенты\"";
            this.button_clients.UseVisualStyleBackColor = false;
            this.button_clients.Click += new System.EventHandler(this.button_clients_Click);
            // 
            // button_workers
            // 
            this.button_workers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_workers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_workers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_workers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_workers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_workers.Location = new System.Drawing.Point(303, 234);
            this.button_workers.Name = "button_workers";
            this.button_workers.Size = new System.Drawing.Size(188, 37);
            this.button_workers.TabIndex = 2;
            this.button_workers.Text = "Таблица \"Сотрудники\"";
            this.button_workers.UseVisualStyleBackColor = false;
            this.button_workers.Click += new System.EventHandler(this.button_workers_Click);
            // 
            // button_hotels
            // 
            this.button_hotels.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_hotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hotels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_hotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hotels.Location = new System.Drawing.Point(303, 191);
            this.button_hotels.Name = "button_hotels";
            this.button_hotels.Size = new System.Drawing.Size(189, 37);
            this.button_hotels.TabIndex = 3;
            this.button_hotels.Text = "Таблица \"Отели\"";
            this.button_hotels.UseVisualStyleBackColor = false;
            this.button_hotels.Click += new System.EventHandler(this.button_hotels_Click);
            // 
            // button_countrys
            // 
            this.button_countrys.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_countrys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_countrys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_countrys.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_countrys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_countrys.Location = new System.Drawing.Point(303, 148);
            this.button_countrys.Name = "button_countrys";
            this.button_countrys.Size = new System.Drawing.Size(189, 37);
            this.button_countrys.TabIndex = 4;
            this.button_countrys.Text = "Таблица \"Страны\"";
            this.button_countrys.UseVisualStyleBackColor = false;
            this.button_countrys.Click += new System.EventHandler(this.button_countrys_Click);
            // 
            // button_discounts
            // 
            this.button_discounts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_discounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_discounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_discounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_discounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_discounts.Location = new System.Drawing.Point(303, 277);
            this.button_discounts.Name = "button_discounts";
            this.button_discounts.Size = new System.Drawing.Size(188, 37);
            this.button_discounts.TabIndex = 5;
            this.button_discounts.Text = "Таблица \"Скидки\"";
            this.button_discounts.UseVisualStyleBackColor = false;
            this.button_discounts.Click += new System.EventHandler(this.button_discounts_Click);
            // 
            // button_package
            // 
            this.button_package.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_package.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_package.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_package.Location = new System.Drawing.Point(304, 320);
            this.button_package.Name = "button_package";
            this.button_package.Size = new System.Drawing.Size(188, 37);
            this.button_package.TabIndex = 6;
            this.button_package.Text = "Таблица \"Путевки\"";
            this.button_package.UseVisualStyleBackColor = false;
            this.button_package.Click += new System.EventHandler(this.button_package_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_package);
            this.Controls.Add(this.button_discounts);
            this.Controls.Add(this.button_countrys);
            this.Controls.Add(this.button_hotels);
            this.Controls.Add(this.button_workers);
            this.Controls.Add(this.button_clients);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "\\";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clients;
        private System.Windows.Forms.Button button_workers;
        private System.Windows.Forms.Button button_hotels;
        private System.Windows.Forms.Button button_countrys;
        private System.Windows.Forms.Button button_discounts;
        private System.Windows.Forms.Button button_package;
    }
}

