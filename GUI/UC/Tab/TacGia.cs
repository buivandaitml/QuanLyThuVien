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
    public partial class TacGia : UserControl
    {
        public TacGia()
        {
            InitializeComponent();
        }

        private void disableInput()
        {
            txtmatg.Enabled = false;
            txtquequan.Enabled = false;
            txttentg.Enabled = false;
            groupBox1.Enabled = false;
            date.Enabled = false;
        }
        private void enableInput()
        {
            txtmatg.Enabled = true;
            txtquequan.Enabled = true;
            txttentg.Enabled = true;
            groupBox1.Enabled = true;
            date.Enabled = true;
        }
        private void clearInput()
        {
            txtmatg.Clear();
            txtquequan.Clear();
            txttentg.Clear();

            rdbnam.Checked = true;
            rdbnu.Checked = false;
        }

        private void loadDataToDgv()
        {
            dgvtacgia.DataSource = BUS.xuat_TG();
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            disableInput();
            loadDataToDgv();
            btnSua.Enabled = false;
        }

        private void loadToText()
        {
            txtmatg.Text = dgvtacgia.CurrentRow.Cells[0].Value.ToString();
            txttentg.Text = dgvtacgia.CurrentRow.Cells[1].Value.ToString();
            date.Text = dgvtacgia.CurrentRow.Cells[3].Value.ToString();
            txtquequan.Text = dgvtacgia.CurrentRow.Cells[4].Value.ToString();
            if (dgvtacgia.CurrentRow.Cells[2].Value.ToString() == "Nam") rdbnam.Checked = true;
            else if (dgvtacgia.CurrentRow.Cells[2].Value.ToString() == "Nữ") rdbnu.Checked = true;

        }

        private void dgvtacgia_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtmatg.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Text = "Hủy";
        }

        private void btnXoa_click(object sender, EventArgs e)
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
                if (BUS.xoa_TG(txtmatg.Text) != 1)
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
                    QLThuVien.ValueObject.TacGia a = new QLThuVien.ValueObject.TacGia();
                    a.MaTG = txtmatg.Text.Trim();
                    a.TenTG = txttentg.Text.Trim();
                    a.QueQuan = txtquequan.Text.Trim();
                    a.NgaySinh = date.Value;
                    if (rdbnam.Checked) a.GioiTinh = "Nam";
                    else if (rdbnu.Checked) a.GioiTinh = "Nữ";
                    if (a.MaTG == null || a.MaTG == "") throw new Exception();
                    if (BUS.them_TG(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Thêm thành công");
                    }
                    else throw new Exception();
                }
                else if (btnSua.Active)
                {
                    QLThuVien.ValueObject.TacGia a = new QLThuVien.ValueObject.TacGia();
                    a.MaTG = txtmatg.Text.Trim();
                    a.TenTG = txttentg.Text.Trim();
                    a.QueQuan = txtquequan.Text.Trim();
                    a.NgaySinh = date.Value;
                    if (rdbnam.Checked) a.GioiTinh = "Nam";
                    else if (rdbnu.Checked) a.GioiTinh = "Nữ";
                    if (a.MaTG == null || a.MaTG == "") throw new Exception();
                    if (BUS.sua_TG(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Sửa thành Công");
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
