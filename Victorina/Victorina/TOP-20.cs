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
    public partial class TOP_20 : Form
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        public TOP_20()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;
                                      Initial Catalog = Quiz;
                                      Integrated Security = True;";
        }

        private void TOP_20_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quizDataSet3.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter2.Fill(this.quizDataSet3.Results);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quizDataSet2.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter1.Fill(this.quizDataSet2.Results);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quizDataSet.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.quizDataSet.Results);

        }
        
    }
}
