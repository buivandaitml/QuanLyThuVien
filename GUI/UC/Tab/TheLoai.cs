using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.BUSLayer;

namespace GUI.UC.Tab
{
    public partial class TheLoai : UserControl
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void disableInput()
        {
            txttentl.Enabled = false;
            txtmatl.Enabled = false;
        }
        private void enableInput()
        {
            txttentl.Enabled = true;
            txtmatl.Enabled = true;
        }

        private void clearInput()
        {
            txtmatl.Clear();
            txttentl.Clear();
        }

        private void loadDataToDgv()
        {
            dgvTheLoai.DataSource = BUS.xuat_TL();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            loadDataToDgv();
            disableInput();
            btnSua.Enabled = false;
        }

        private void loadToText()
        {
            txtmatl.Text = dgvTheLoai.CurrentRow.Cells[0].Value.ToString();
            txttentl.Text = dgvTheLoai.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearInput();
            loadToText();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Text = "Xóa";
            btnXoa.Active = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearInput();
            enableInput();
            btnSua.Enabled = false;
            btnXoa.Text = "Hủy";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableInput();
            txtmatl.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Text = "Hủy";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Active || btnSua.Active)
            {
                clearInput();
                disableInput();
                btnXoa.Text = "Xóa";
                btnXoa.Active = true;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Text = "Xóa";
                btnXoa.Active = true;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                if (BUS.xoa_TL(txtmatl.Text) != 1)
                    MessageBox.Show("Không xóa được");
                else
                {
                    loadDataToDgv();
                    MessageBox.Show("Xóa Thành Công");
                }
                clearInput();
                disableInput();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnThem.Active)
                {
                    QLThuVien.ValueObject.TheLoai a = new QLThuVien.ValueObject.TheLoai();
                    a.MaTL = txtmatl.Text.Trim();
                    a.TenTL = txttentl.Text.Trim();
                    if (a.MaTL == null || a.MaTL == "") throw new Exception();
                    if (BUS.them_TL(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else throw new Exception();
                }
                else if(btnSua.Active)
                {
                    QLThuVien.ValueObject.TheLoai a = new QLThuVien.ValueObject.TheLoai();
                    a.MaTL = txtmatl.Text.Trim();
                    a.TenTL = txttentl.Text.Trim();
                    if (a.MaTL == null || a.MaTL == "") throw new Exception();
                    if (BUS.sua_TL(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Sửa Thành Công");
                    }
                    else throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Input sai");
            }
            finally
            {
                clearInput();
                disableInput();
                btnXoa.Active = true;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Text = "Xóa";
            }
        }

        
    }
}
