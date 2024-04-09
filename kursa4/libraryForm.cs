using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using SD = System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursa4
{
    public partial class libraryForm : Form
    {
        public libraryForm()
        {
            InitializeComponent();
        }


        public MySqlConnection mycon;
        public MySqlConnection mycom;
        public string connect = "Server=localhost;Database=kursa4;Uid=root;pwd=12345;charset=utf8;";

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string script = input.Text;
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                dataBase.DataSource = table;


                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Connection lost!");
            }
        }

        private void connectDB_Click(object sender, EventArgs e)
        {
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("Database connected");
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Connection lost!");
            }
        }

        private void reportAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "SELECT * FROM books ORDER BY author;";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                dataBase.DataSource = table;


                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Connection lost!");
            }

        }

        private void reportDate_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "SELECT * FROM books ORDER BY year_b ASC;";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                dataBase.DataSource = table;


                mycon.Close();
            }
            catch
            {
                MessageBox.Show("Connection lost!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
