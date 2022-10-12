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
    public partial class Countrys : Form
    {
        public Countrys()
        {
            InitializeComponent();
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);

        }

        private void Form_Countrys_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.turistFirmDataSet.Country);

        }

        private void button_first_Click(object sender, EventArgs e)
        {
            this.countryBindingSource.MoveFirst();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.countryBindingSource.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.countryBindingSource.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            this.countryBindingSource.MoveLast();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            this.countryBindingSource.AddNew();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.countryBindingSource.RemoveCurrent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.countryBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.countryBindingSource.MoveFirst();
            String buffer = "buffer";
            while (idCountryTextBox.Text != buffer)
            {
                if (idCountryTextBox.Text == textBox1.Text)
                {
                    break;
                }
                buffer = idCountryTextBox.Text;
                this.countryBindingSource.MoveNext();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countryBindingSource.Filter = "Climate='" + textBox3.Text + "'";
        }
    }
}
