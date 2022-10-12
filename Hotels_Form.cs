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
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void hotelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);

        }

        private void hotelsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);

        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.turistFirmDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.turistFirmDataSet.Hotels);

        }

        private void button_first_Click(object sender, EventArgs e)
        {
            this.hotelsBindingSource.MoveFirst();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.hotelsBindingSource.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.hotelsBindingSource.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            this.hotelsBindingSource.MoveLast();

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            this.hotelsBindingSource.AddNew();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.hotelsBindingSource.RemoveCurrent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.hotelsBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);
        }


        private void button_search_Click(object sender, EventArgs e)
        {
            this.hotelsBindingSource.MoveFirst();
            String buffer = "buffer";
            while (idHotelTextBox.Text != buffer)
            {
                if (idHotelTextBox.Text == textBox1.Text)
                {
                    break;
                }
                buffer = idHotelTextBox.Text;
                this.hotelsBindingSource.MoveNext();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.Filter = "HotelClass='" + textBox3.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.Filter = "IdCountry='" + textBox3.Text + "'";
        }
    }
}
