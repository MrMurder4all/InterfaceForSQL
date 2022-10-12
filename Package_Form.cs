using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }

        private void packageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);

        }

        private void packageBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.packageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);
        }

        private void Package_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Discounts". При необходимости она может быть перемещена или удалена.
            this.discountsTableAdapter.Fill(this.turistFirmDataSet.Discounts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.turistFirmDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.turistFirmDataSet.Hotels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.turistFirmDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Package". При необходимости она может быть перемещена или удалена.
            this.packageTableAdapter.Fill(this.turistFirmDataSet.Package);

        }

        private void button_first_Click(object sender, EventArgs e)
        {
            this.packageBindingSource.MoveFirst();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.packageBindingSource.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.packageBindingSource.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            this.packageBindingSource.MoveLast();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            this.packageBindingSource.AddNew();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.packageBindingSource.RemoveCurrent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.packageBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.packageBindingSource.MoveFirst();
            String buffer = "buffer";
            while (idPackageTextBox.Text != buffer)
            {
                if (idPackageTextBox.Text == textBox1.Text)
                {
                    break;
                }
                buffer = idPackageTextBox.Text;
                this.packageBindingSource.MoveNext();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            packageBindingSource.Filter = "IdHotel='" + textBox3.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            packageBindingSource.Filter = "IdClient='" + textBox2.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            packageBindingSource.Filter = "IdWorker='" + textBox4.Text + "'";
        }
    }
}
