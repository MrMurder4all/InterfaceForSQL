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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.turistFirmDataSet.Client);

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_first_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveFirst();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveLast();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.AddNew();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.RemoveCurrent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.clientBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveFirst();
            String buffer = "buffer";
            while (idClientTextBox.Text != buffer)
            {
                if (idClientTextBox.Text == textBox1.Text)
                {
                    break;
                }
                buffer = idClientTextBox.Text;
                this.clientBindingSource.MoveNext();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveFirst();
            String buffer = "buffer";
            while (maskedTextBox1.Text != buffer)
            {
                if (maskedTextBox1.Text == textBox2.Text)
                {
                    break;
                }
                buffer = maskedTextBox1.Text;
                this.clientBindingSource.MoveNext();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientBindingSource.Filter = "LName='" + textBox3.Text + "'";
        }
    }
}
