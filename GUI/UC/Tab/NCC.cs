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
    public partial class NCC : UserControl
    {
        public NCC()
        {
            InitializeComponent();
        }

        private void loadDataToDgv()
        {
            dgvNXB.DataSource = BUS.xuat_NCC();
        }

        private void NXB_Load(object sender, EventArgs e)
        {
            loadDataToDgv();
            disableInput();
            btnSua.Enabled = false;
        }

        private void disableInput()
        {
            txtdiachi.Enabled = false;
            txtemail.Enabled = false;
            txtmancc.Enabled = false;
            txtsdt.Enabled = false;
            txttenncc.Enabled = false;
        }
        private void enableInput()
        {
            txtdiachi.Enabled = true;
            txtemail.Enabled = true;
            txtmancc.Enabled = true;
            txtsdt.Enabled = true;
            txttenncc.Enabled = true;

        }

        private void clearInput()
        {
            txtdiachi.Clear();
            txtemail.Clear();
            txtmancc.Clear();
            txtsdt.Clear();
            txttenncc.Clear();
        }

        private void loadToText()
        {
            txtmancc.Text = dgvNXB.CurrentRow.Cells[0].Value.ToString().Trim();
            txttenncc.Text = dgvNXB.CurrentRow.Cells[1].Value.ToString().Trim();
            txtdiachi.Text = dgvNXB.CurrentRow.Cells[2].Value.ToString().Trim();
            txtemail.Text = dgvNXB.CurrentRow.Cells[4].Value.ToString().Trim();
            txtsdt.Text = dgvNXB.CurrentRow.Cells[3].Value.ToString().Trim();

        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disableInput();
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
            txtmancc.Enabled = false;
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
                if (BUS.xoa_NCC(txtmancc.Text) != 1)
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
                if (btnThem.Active)
                {
                    QLThuVien.ValueObject.NCC a = new QLThuVien.ValueObject.NCC();
                    a.MaNCC = txtmancc.Text.Trim();
                    a.TenNCC = txttenncc.Text.Trim();
                    a.DiaChi = txtdiachi.Text.Trim();
                    a.SDT1 = txtsdt.Text.Trim();
                    a.Email = txtemail.Text.Trim();
                    if (a.MaNCC == null || a.MaNCC == "") throw new Exception();
                    if (BUS.them_NCC(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else throw new Exception();
                }
                else if (btnSua.Active)
                {
                    QLThuVien.ValueObject.NCC a = new QLThuVien.ValueObject.NCC();
                    a.MaNCC = txtmancc.Text.Trim();
                    a.TenNCC = txttenncc.Text.Trim();
                    a.DiaChi = txtdiachi.Text.Trim();
                    a.SDT1 = txtsdt.Text.Trim();
                    a.Email = txtemail.Text.Trim();
                    if (a.MaNCC == null || a.MaNCC == "") throw new Exception();
                    if (BUS.sua_NCC(a) == 1)
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
