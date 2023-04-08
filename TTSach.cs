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
    public partial class TTSach : Form
    {
        public TTSach()
        {
            InitializeComponent();
        }
        private void ShowDGVTTSach()
        {
            QLNS db = new QLNS();
            var l = db.saches.Select(p => new {p.masach, p.tensach,p.namxb, p.nxb.tennxb, p.theloai.tentheloai, p.tacgia.tentacgia, p.soluong, p.ghichu });
            dataGridView1.DataSource = l.ToList();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ShowDGVTTSach();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            QLNS db = new QLNS();
            sach s = new sach();
            s.masach = Convert.ToInt32(txt_masach.Text);
            s.tensach = txt_tensach.Text;
            s.namxb = Convert.ToInt32(txt_namXB.Text);
            s.manxb = Convert.ToInt32(txt_IDNXB.Text);
            s.matheloai = Convert.ToInt32(txt_IDTheLoai.Text);
            s.matacgia = Convert.ToInt32(txt_IDTacGia.Text);
            s.soluong = Convert.ToInt32(txt_SoLuong.Text);
            s.ghichu = txt_GhiChu.Text;
            var l = db.saches.Add(s);
            db.SaveChanges();
            ShowDGVTTSach();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            QLNS db = new QLNS();
            var l = db.tacgias.Select(p => p);
            dataGridView1.DataSource = l.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLSach form = new QLSach();
            form.Show();
            this.Hide();
        }

        
    }
}
