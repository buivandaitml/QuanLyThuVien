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
    public partial class SCN : UserControl
    {
        public SCN()
        {
            InitializeComponent();
        }

        private DataTable dtThuThu = new DataTable();
        private DataTable dtNCC = new DataTable();

        private void loadTenTT(string maTT)
        {
            cbxmatt.Text = "";
            foreach (DataRow row in dtThuThu.Rows)
            {
                if (Convert.ToString(row.ItemArray[0]) == maTT)
                {
                    cbxmatt.Text = Convert.ToString(row.ItemArray[1]);
                    break;
                }
            }
        }

        private void loadTenNCC(string maNCC)
        {
            cbxmancc.Text = "";
            foreach (DataRow row in dtNCC.Rows)
            {
                if (Convert.ToString(row.ItemArray[0]) == maNCC)
                {
                    cbxmatt.Text = Convert.ToString(row.ItemArray[1]);
                    break;
                }
            }
        }

        private void loadDataToDgv()
        {
            dgvNXB.DataSource = BUS.xuat_SCN();
        }

        private void NXB_Load(object sender, EventArgs e)
        {
            loadDataToDgv();
            disableInput();
            btnSua.Enabled = false;
            cbxloaihinhnhap.Items.Add("Nhập mới");
            cbxloaihinhnhap.Items.Add("Nhập thêm");
            dtThuThu = BUS.xuat_TT();
            dtNCC = BUS.xuat_NCC();

            foreach(DataRow row in dtThuThu.Rows)
            {
                cbxmatt.Items.Add(Convert.ToString(row.ItemArray[1]));
            }

            foreach (DataRow row in dtNCC.Rows)
            {
                cbxmancc.Items.Add(Convert.ToString(row.ItemArray[1]));
            }
        }

        private void disableInput()
        {
            txttenscn.Enabled = false;
            txttg.Enabled = false;
            txttl.Enabled = false;
            cbxloaihinhnhap.Enabled = false;
            cbxmatt.Enabled = false;
            cbxmancc.Enabled = false;
        }
        private void enableInput()
        {
            txttenscn.Enabled = true;
            txttg.Enabled = true;
            txttl.Enabled = true;
            cbxloaihinhnhap.Enabled = true;
            cbxmatt.Enabled = true;
            cbxmancc.Enabled = true;
        }

        private void clearInput()
        {
            txttenscn.Clear();
            txttg.Clear();
            txttl.Clear();
            cbxloaihinhnhap.Text = "Nhập mới";
            cbxmatt.Text = "";
            cbxmancc.Text = "";
        }

        private void loadToText()
        {
            txttenscn.Text = dgvNXB.CurrentRow.Cells[0].Value.ToString().Trim();
            txttg.Text = dgvNXB.CurrentRow.Cells[1].Value.ToString().Trim();
            txttl.Text = dgvNXB.CurrentRow.Cells[2].Value.ToString().Trim();
            cbxloaihinhnhap.Text = dgvNXB.CurrentRow.Cells[3].Value.ToString().Trim();
            cbxmatt.Text = dgvNXB.CurrentRow.Cells[4].Value.ToString().Trim();
            cbxmancc.Text = dgvNXB.CurrentRow.Cells[5].Value.ToString().Trim();
            foreach (DataRow row in dtThuThu.Rows)
            {
                if (dgvNXB.CurrentRow.Cells[4].Value.ToString().Trim() == row.ItemArray[0].ToString())
                {
                    cbxmatt.Text = row.ItemArray[1].ToString();
                    break;
                }
            }

            foreach (DataRow row in dtNCC.Rows)
            {
                if (dgvNXB.CurrentRow.Cells[5].Value.ToString().Trim() == row.ItemArray[0].ToString())
                {
                    cbxmancc.Text = row.ItemArray[1].ToString();
                    break;
                }
            }
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
            txttenscn.Enabled = false;
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
                if (BUS.xoa_SCN(txttenscn.Text) != 1)
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
                    QLThuVien.ValueObject.SachCN a = new QLThuVien.ValueObject.SachCN();
                    a.TenSach = txttenscn.Text.Trim();
                    a.TacGia = txttg.Text.Trim();
                    a.TheLoai = txttl.Text.Trim();
                    a.LaoiHinhNhap = cbxloaihinhnhap.Text.Trim();
                    a.MaTT = null;
                    a.MaNCC = null;

                    foreach (DataRow row in dtThuThu.Rows)
                    {
                        if(cbxmatt.Text==row.ItemArray[1].ToString())
                        {
                            a.MaTT = row.ItemArray[0].ToString();
                            break;
                        }
                    }

                    foreach (DataRow row in dtNCC.Rows)
                    {
                        if (cbxmancc.Text == row.ItemArray[1].ToString())
                        {
                            a.MaNCC = row.ItemArray[0].ToString();
                            break;
                        }
                    }

                    if (a.TenSach == null || a.TenSach == "") throw new Exception();
                    if (BUS.them_SCN(a) == 1)
                    {
                        loadDataToDgv();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else throw new Exception();
                }
                else if (btnSua.Active)
                {
                    QLThuVien.ValueObject.SachCN a = new QLThuVien.ValueObject.SachCN();
                    a.TenSach = txttenscn.Text.Trim();
                    a.TacGia = txttg.Text.Trim();
                    a.TheLoai = txttl.Text.Trim();
                    a.LaoiHinhNhap = cbxloaihinhnhap.Text.Trim();
                    a.MaTT = null;
                    a.MaNCC = null;

                    foreach (DataRow row in dtThuThu.Rows)
                    {
                        if (cbxmatt.Text == row.ItemArray[1].ToString())
                        {
                            a.MaTT = row.ItemArray[0].ToString();
                            break;
                        }
                    }

                    foreach (DataRow row in dtNCC.Rows)
                    {
                        if (cbxmancc.Text == row.ItemArray[1].ToString())
                        {
                            a.MaNCC = row.ItemArray[0].ToString();
                            break;
                        }
                    }

                    if (a.TenSach == null || a.TenSach == "") throw new Exception();
                    if (BUS.sua_SCN(a) == 1)
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
