using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Victorina
{
    public partial class RegistrForm : Form
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        public RegistrForm()
        {
            
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;
                                      Initial Catalog = Quiz;
                                      Integrated Security = True;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            
            try
            {
                const string comand = "Select * from Users WHERE login=@login AND password = @password";
                SqlCommand check = new SqlCommand(comand, conn);
                check.Parameters.AddWithValue("@login", EnterLog.Text);
                check.Parameters.AddWithValue("@password", EnterPass.Text);
                conn.Open();

                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }


            }

            finally
            {
                conn.Close();
            }

            if (!success)
            {

                SqlCommand comm = new SqlCommand("insert into users (login, password,birthday,privacy) " + "values (@login,@password,@birthday,@privacy)", conn);
                comm.Parameters.Add("@login", SqlDbType.NVarChar, 50).Value = EnterLog.Text;
                comm.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = EnterPass.Text;
                comm.Parameters.Add("@birthday",SqlDbType.NVarChar,50).Value =dateTimePicker1.Text;
                comm.Parameters.Add("@privacy", SqlDbType.NVarChar, 50).Value = "user";
                conn.Open();
                comm.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Вы зарегистрированы!");
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
