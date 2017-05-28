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
    public partial class ThuThu : UserControl
    {
        public ThuThu()
        {
            InitializeComponent();
        }
        
        private void disableInput()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            datepicker.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            txtcapbac.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void enableInput()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            datepicker.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            txtcapbac.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void clearInput()
        {
            txtma.Clear();
            txtten.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtcapbac.Clear();
            rdbnam.Checked = true;
            rdbnu.Checked = false;
        }

        private void loadDataToDgv()
        {
            dgvThuThu.DataSource = BUS.xuat_TT();
        }

        private void ThuThu_Load(object sender, EventArgs e)
        {
            loadDataToDgv();
            disableInput();
            btnSua.Enabled = false;
        }

        private void loadToText()
        {
            txtma.Text = dgvThuThu.CurrentRow.Cells[0].Value.ToString().Trim();
            txtten.Text = dgvThuThu.CurrentRow.Cells[1].Value.ToString().Trim();
            if (dgvThuThu.CurrentRow.Cells[2].Value.ToString() == "Nam") rdbnam.Checked = true;
            else if (dgvThuThu.CurrentRow.Cells[2].Value.ToString() == "Nữ") rdbnu.Checked = true;
            datepicker.Text = dgvThuThu.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = dgvThuThu.CurrentRow.Cells[4].Value.ToString().Trim();
            txtsdt.Text = dgvThuThu.CurrentRow.Cells[5].Value.ToString().Trim();
            txtcapbac.Text = dgvThuThu.CurrentRow.Cells[6].Value.ToString().Trim();
        }

        private void dgvThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtma.Enabled = false;
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
                if (BUS.xoa_TT(txtma.Text) != 1)
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
                    QLThuVien.ValueObject.ThuThu a = new QLThuVien.ValueObject.ThuThu();
                    a.MaTT = txtma.Text.Trim();
                    a.TenTT = txtten.Text.Trim();
                    a.NgaySinh = datepicker.Value;
                    a.DiaChi = txtdiachi.Text.Trim();
                    a.CapBac = txtcapbac.Text.Trim();
                    a.SDT1 = txtsdt.Text.Trim();
                    if (rdbnam.Checked) a.GioiTinh = "Nam";
                    else if (rdbnu.Checked) a.GioiTinh = "Nữ";
                    if (a.MaTT == null || a.MaTT == "") throw new Exception();
                    if (BUS.them_TT(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else throw new Exception();
                }
                else if(btnSua.Active)
                {
                    QLThuVien.ValueObject.ThuThu a = new QLThuVien.ValueObject.ThuThu();
                    a.MaTT = txtma.Text.Trim();
                    a.TenTT = txtten.Text.Trim();
                    a.NgaySinh = datepicker.Value;
                    a.DiaChi = txtdiachi.Text.Trim();
                    a.CapBac = txtcapbac.Text.Trim();
                    a.SDT1 = txtsdt.Text.Trim();
                    if (rdbnam.Checked) a.GioiTinh = "Nam";
                    else if (rdbnu.Checked) a.GioiTinh = "Nữ";
                    if (a.MaTT == null || a.MaTT == "") throw new Exception();
                    if (BUS.sua_TT(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Sửa thành công");
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
