using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_1._0_
{
    public partial class TTDocGia : Form
    {
        public TTDocGia()
        {
            InitializeComponent();
        }

        private void showdgvTTDG()
        {
            QLNS db = new QLNS();
            docgia s = new docgia();
            //if (s.gioitinh == true)
            //{
            //    dgv_TTdocgia.CurrentRow.Cells["gioitinh"].Value = "Nam";
            //}
            //else
            //{
            //    dgv_TTdocgia.CurrentRow.Cells["gioitinh"].Value = "Nữ";
            //}
            dgv_TTdocgia.DataSource = db.docgias.Select(p => new { p.madocgia, p.hoten, p.ngaysinh, p.diachi, p.gioitinh, p.sdt }).ToList();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            showdgvTTDG();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            QLNS db = new QLNS();
            docgia s = new docgia();

            s.madocgia = Convert.ToInt32(txt_madocgia.Text);
            s.hoten = txt_Hotendocgia.Text;
            s.ngaysinh = dateTimePicker1.Value;
            s.gioitinh = radioButton1.Checked;
            s.diachi = txt_diachi.Text;
            s.sdt = txt_sdt.Text;

            var l = db.docgias.Add(s);
            db.SaveChanges();
            showdgvTTDG();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_TTdocgia.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgv_TTdocgia.SelectedRows)
                {
                    using (QLNS db = new QLNS())
                    {
                        int m = Convert.ToInt32(i.Cells[0].Value.ToString());
                        docgia s = db.docgias.Find(m); //Khoa chinh
                        db.docgias.Remove(s);
                        db.SaveChanges();
                        showdgvTTDG();
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_TTdocgia.SelectedRows.Count == 1)
            {
                using (QLNS db = new QLNS())
                {
                    int m = Convert.ToInt32(dgv_TTdocgia.CurrentRow.Cells["madocgia"].Value.ToString());
                    docgia s = db.docgias.Find(m);
                    s.hoten = txt_Hotendocgia.Text;
                    s.ngaysinh = dateTimePicker1.Value;
                    s.diachi = txt_diachi.Text;
                    s.gioitinh = radioButton1.Checked;
                    s.sdt = txt_sdt.Text;
                    db.SaveChanges();
                    showdgvTTDG();
                }
            }
        }

      

        private void dgv_TTdocgia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_TTdocgia.CurrentRow.Index;
            txt_madocgia.Text = dgv_TTdocgia.Rows[i].Cells[0].Value.ToString();
            txt_madocgia.ReadOnly = true;
            txt_Hotendocgia.Text = dgv_TTdocgia.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Text = dgv_TTdocgia.Rows[i].Cells[2].Value.ToString();
            txt_diachi.Text = dgv_TTdocgia.Rows[i].Cells[3].Value.ToString();
            //radioButton1.Text = dgv_TTdocgia.Rows[i].Cells[4].Value.ToString();
            if (dgv_TTdocgia.Rows[i].Cells[4].Value.ToString() == "True")
            {
                radioButton1.Text = "Nam";
                radioButton1.Checked = true;
            }
            if (dgv_TTdocgia.Rows[i].Cells[4].Value.ToString() == "False")
            {
                radioButton2.Text = "Nữ";
                radioButton2.Checked = true;
            }
            txt_sdt.Text = dgv_TTdocgia.Rows[i].Cells[5].Value.ToString();
        }
    }
}
