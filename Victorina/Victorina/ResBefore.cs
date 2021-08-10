using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victorina
{
    public partial class ResBefore : Form
    {
        public ResBefore()
        {
            InitializeComponent();
        }

        private void ResBefore_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quizDataSet1.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.quizDataSet1.Results,Convert.ToInt32(DataBank.userid));

        }
    }
}
