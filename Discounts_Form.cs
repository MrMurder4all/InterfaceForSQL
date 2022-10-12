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
    public partial class Discounts : Form
    {
        public Discounts()
        {
            InitializeComponent();
        }

        private void discountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);

        }

        private void Discounts_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Discounts". При необходимости она может быть перемещена или удалена.
            this.discountsTableAdapter.Fill(this.turistFirmDataSet.Discounts);

        }



        private void button_first_Click(object sender, EventArgs e)
        {
            this.discountsBindingSource.MoveFirst();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.discountsBindingSource.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.discountsBindingSource.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            this.discountsBindingSource.MoveLast();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            this.discountsBindingSource.AddNew();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.discountsBindingSource.RemoveCurrent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.discountsBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.discountsBindingSource.MoveFirst();
            String buffer = "buffer";
            while (idDiscountTextBox.Text != buffer)
            {
                if (idDiscountTextBox.Text == textBox1.Text)
                {
                    break;
                }
                buffer = idDiscountTextBox.Text;
                this.discountsBindingSource.MoveNext();
            }
        }
    }
}
