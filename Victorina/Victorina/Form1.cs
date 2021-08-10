using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Victorina
{

    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);

            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;
                                      Initial Catalog = Quiz;
                                      Integrated Security = True;";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            if (textBoxLogin.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Недопустимое значение полей");
            }
            else
            {
                bool success = false;
                try
                {
                    const string comand = "Select * from Users WHERE login=@login AND password = @password";
                    SqlCommand check = new SqlCommand(comand, conn);
                    check.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    check.Parameters.AddWithValue("@password", textBoxPass.Text);
                    conn.Open();
                    SqlDataReader reader = check.ExecuteReader();
                    while (reader.Read())
                    {
                        DataBank.userid =Convert.ToInt32( reader.GetValue(0));
                    }
 
                    reader.Close();
                    using (var dataReader = check.ExecuteReader())
                    {
                        success = dataReader.Read();
                    }

                }

                finally
                {
                    conn.Close();
                }
                if (success)
                {
                    MainVictory form2 = new MainVictory();
                    Hide();
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                
            }
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            RegistrForm f = new RegistrForm();
            this.Hide();
            f.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonEnter_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonEnter.PerformClick();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxLogin.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBoxPass.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Base\Quiz.mdf;
                                      Initial Catalog = Quiz;
                                      Integrated Security = True;";
            conn.Open();
            conn.Close();
        }
    }
}
