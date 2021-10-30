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

namespace quanlythuvien
{
    public partial class frmtaomoitk : Form
    {
        public frmtaomoitk()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        SqlCommand cmdSelect;
        SqlCommand cmdInsert;
        SqlCommand cmdXoa;
        int i = 0;

        private void Moketnoi()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Open();
        }
        private void LoadListView()
        {
           Moketnoi();
            cmdSelect=new SqlCommand("select *from nhanvien",cn);
            SqlDataReader r = cmdSelect.ExecuteReader();
            listView1.Items.Clear();
            while(r.Read())
            {
                string[] st=new string[5];
                st[0]=r[0].ToString();
                st[1]=r[1].ToString();
                st[2]=r[2].ToString();//khong hien thi mat khau nen khong co r3
                st[3]=r[4].ToString();
                st[4]=r[5].ToString();
                ListViewItem lv = new ListViewItem(st);
                listView1.Items.Add(lv);
            }
            cmdSelect.Dispose();
        }

        private void LoadItem(int i)
        {
            txtmanv.Text = listView1.Items[i].Text;
            txthoten.Text = listView1.Items[i].SubItems[1].Text;
            txtdiachi.Text = listView1.Items[i].SubItems[2].Text;
            txttendangnhap.Text = listView1.Items[i].SubItems[3].Text;
            comboBox1.Text = listView1.Items[i].SubItems[4].Text;
        }
        private void LoadCombox()
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Sinhvien");
            comboBox1.Items.Add("ThuThu");
            comboBox1.Text = "Admin";

        }
        private void XoaTextBox()
        {
            txtmanv.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txttendangnhap.Clear();
            txtmanv.Focus();
        }
        private int KiemTraMa(string ma)
        {
            Moketnoi();
            cmdSelect=new SqlCommand("select count(*)from nhanvien where manhanvien='"+ma.Trim()+"'");
            cmdSelect.Connection = cn;
            return (int)cmdSelect.ExecuteScalar();


        }

        private void frmtaomoitk_Load(object sender, EventArgs e)
        {
            try
            {
                cn= new SqlConnection(@"Data Source=MT0607\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
              cn.Open();
            }
            catch (Exception loi)
            {
                MessageBox.Show("khong the ket noi duoc");
            }
            LoadListView();
            i = 0;
            LoadItem(i);
            LoadCombox();
        }

        private void butdau_Click(object sender, EventArgs e)
        {
            i = 0;
            LoadItem(i);
        }

        private void butlui_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = 0;
            LoadItem(i);
        }

        private void buttien_Click(object sender, EventArgs e)
        {
            i++;
            if (i == listView1.Items.Count)
                i = listView1.Items.Count - 1;
            LoadItem(i);
        }

        private void butcuoi_Click(object sender, EventArgs e)
        {
            i = listView1.Items.Count - 1;
            LoadItem(i);
        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            if (buttaomoi.Text.Equals("Tao Moi"))
            {
                XoaTextBox();
                buttaomoi.Text = "Luu";
            }
            else
                if (KiemTraMa(txtmanv.Text) == 1)
                {
                    MessageBox.Show("ma nay da co");
                    txtmanv.Clear();
                    txtmanv.Focus();
                }
                else
                {
                    string ma = txtmanv.Text;
                    string hoten = txthoten.Text;
                    string diachi = txtdiachi.Text;
                    string tendangnhap = txttendangnhap.Text;
                    string matkhau = "";//khi tao mot tai khoa thi mat khau ban dau la rong
                    string quyenhan = comboBox1.Text;
                    Moketnoi();
                    string sql = "insert into nhanvien values(" + "'" + ma + "','" + hoten + "','" + diachi + "','" + tendangnhap + "','" + matkhau + "','" + quyenhan + "')";
                    cmdInsert = new SqlCommand(sql, cn);
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("da luu thanh cong");
                    LoadListView();
                    buttaomoi.Text = "Tao Moi";
                        cmdInsert.Dispose();

                }
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Moketnoi();
            string sql = "select*from nhanvien where manhanvien='" + txtmanv.Text + "'";
            cmdSelect = new SqlCommand(sql, cn);
            SqlDataReader dr = cmdSelect.ExecuteReader();
            if (dr.Read())
            {
                txtmanv.Text = dr[0].ToString();
                txthoten.Text = dr[1].ToString();
                txtdiachi.Text = dr[2].ToString();
                txttendangnhap.Text = dr[4].ToString();
                comboBox1.Text = dr[5].ToString();
            }
            else
                MessageBox.Show("khong tim thay");
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butxoabo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("chac chan xoa hay khong ?", "thong bao", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Moketnoi();
                string Sql = "delete from nhanvien where manhanvien='" + txtmanv.Text + "'";
                cmdXoa = new SqlCommand(Sql, cn);
                if (cmdXoa.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("xoa thanh cong");
                    LoadListView();
                    LoadItem(0);

                }
                else MessageBox.Show("khong ton tai ma nhan vien" + txtmanv.Text);
                cmdXoa.Dispose();
            }
        }

    }

       
}
