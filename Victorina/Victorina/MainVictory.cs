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
    public partial class MainVictory : Form
    {
        public MainVictory()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geography g = new Geography();
            g.ShowDialog();
        }

        private void MainVictory_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Biology bio = new Biology();
            bio.ShowDialog();
        }

        private void тОП20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TOP_20 top = new TOP_20();
            top.ShowDialog();
        }

        private void результатыПрошлыхВикторинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResBefore res = new ResBefore();
            res.ShowDialog();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
        }

        private void MainVictory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            
        }
    }
}
