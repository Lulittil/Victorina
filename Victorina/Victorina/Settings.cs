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

namespace Victorina
{
    public partial class Settings : Form
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        public Settings()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;
                                      Initial Catalog = Quiz;
                                      Integrated Security = True;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string com = "Update Users Set birthday=@birth where id=@id";
            SqlCommand command = new SqlCommand(com, conn);
            command.Parameters.Add("@birth", SqlDbType.NVarChar, 50).Value= dateTimePicker1.Text;
            command.Parameters.AddWithValue("id", Convert.ToInt32(DataBank.userid));
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Дата рождения изменена!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" || textBox1.Text != " ")
            {
                string com = "Update Users Set password=@pass where id=@id";
                SqlCommand command = new SqlCommand(com, conn);
                command.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                command.Parameters.AddWithValue("id", Convert.ToInt32(DataBank.userid));
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Пароль изменен!");
            }
            else MessageBox.Show("Неверный формат пароля");
            textBox1.Text = "";
        }

        private void Settings_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
