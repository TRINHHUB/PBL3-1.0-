using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_1._0_
{
    public partial class QLSach : Form
    {
        public QLSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTSach form = new TTSach();
            form.Show();
            this.Hide();
        }
    }
}
