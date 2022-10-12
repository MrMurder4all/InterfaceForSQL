using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private Clients clients;
        private Countrys countrys;
        private Hotels hotels;
        private Workers workers;
        private Discounts discounts;
        private Package package;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            String connect = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TuristFirm.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection myConnection = new SqlConnection(connect);
            try
            {
                myConnection.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к базе данных");
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_clients_Click(object sender, EventArgs e)
        {
            clients = new Clients();
            clients.Visible = true;
        }

        private void button_countrys_Click(object sender, EventArgs e)
        {
            countrys = new Countrys();
            countrys.Visible = true;
        }

        private void button_hotels_Click(object sender, EventArgs e)
        {
            hotels = new Hotels();
            hotels.Visible = true;
        }

        private void button_workers_Click(object sender, EventArgs e)
        {
            workers = new Workers();
            workers.Visible = true;
        }

        private void button_discounts_Click(object sender, EventArgs e)
        {
            discounts = new Discounts();
            discounts.Visible = true;
        }

        private void button_package_Click(object sender, EventArgs e)
        {
            package = new Package();
            package.Visible = true;
        }
    }
}
