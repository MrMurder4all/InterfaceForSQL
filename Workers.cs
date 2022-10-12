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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);

        }

        private void Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistFirmDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.turistFirmDataSet.Workers);

        }

        private void button_first_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveFirst();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MovePrevious();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveNext();
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveLast();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.AddNew();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.RemoveCurrent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.workersBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.turistFirmDataSet);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveFirst();
            String buffer = "buffer";
            while (idWorkerTextBox.Text != buffer)
            {
                if (idWorkerTextBox.Text == textBox1.Text)
                {
                    break;
                }
                buffer = idWorkerTextBox.Text;
                this.workersBindingSource.MoveNext();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveFirst();
            String buffer = "buffer";
            while (maskedTextBox1.Text != buffer)
            {
                if (maskedTextBox1.Text == textBox2.Text)
                {
                    break;
                }
                buffer = maskedTextBox1.Text;
                this.workersBindingSource.MoveNext();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workersBindingSource.Filter = "WLName='" + textBox3.Text + "'";       
        }

    }
}

