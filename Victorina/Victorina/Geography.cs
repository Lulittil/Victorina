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
    public partial class Geography : Form
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        int i = 0;
        int z = 0;
        int res = 0;
        public Geography()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;
                                      Initial Catalog = Quiz;
                                      Integrated Security = True;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VictAnsw();
            Geography geo = new Geography();
            Geography_Load( sender,  e);
            textBox1.Text = "";
        }

        public void VictAnsw()
        {
            string com = "Select Answer FROM Geo";
            List<string> Answ = new List<string>();

            conn.Open();
            comm = new SqlCommand(com, conn);


            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            { 
                Answ.Add(Convert.ToString(reader.GetValue(0)));
            }
            reader.Close();
            conn.Close();

            try
            {
                if (Answ[z] == textBox1.Text)
                {
                    res += 1;
                }

            }
            catch
            {
                MessageBox.Show($"Ваш результат: {res}");
                string commm = $"INSERT INTO Results(Thing,Result,UserId) VALUES ('Geography',@Result,@UserId)";
                SqlCommand conm = new SqlCommand(commm, conn);
                conm.Parameters.AddWithValue("@UserId",DataBank.userid);
                conm.Parameters.AddWithValue("@Result",res);
                conn.Open();
                conm.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            finally
            {
                z += 1;
            }
            
        }

        private void Geography_Load(object sender, EventArgs e)
        {
            string com = "Select Question,Answer FROM Geo";
            List<string> Quest = new List<string>();
                conn.Open();
                comm = new SqlCommand(com, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Quest.Add(Convert.ToString(reader.GetValue(0)));
                }
                reader.Close();
            conn.Close();
            
            try
            {
                richTextBox1.Text = Quest[i];
            }
            catch
            {

            }
            finally
            {
                i += 1;
            }
            
        }
        
    }
}
