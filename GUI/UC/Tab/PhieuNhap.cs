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
    public partial class PhieuNhap : UserControl
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void disableInputPN()
        {
            txtspn1.Enabled = false;
            date.Enabled = false;
            cbxthuthu.Enabled = false;
            cbxncc.Enabled = false;
        }

        private void enableInputPN()
        {
            txtspn1.Enabled = true;
            date.Enabled = true;
            cbxthuthu.Enabled = true;
            cbxncc.Enabled = true;
        }

        private void clearInputPN()
        {
            txtspn1.Clear();
            cbxthuthu.Text = "";
            cbxncc.Text = "";
        }

        private void disableInputCTN()
        {
            txtspn2.Enabled = false;
            txtmats.Enabled = false;
            txtsoluong.Enabled = false;
            txtdongia.Enabled = false;
        }

        private void enableInputCTN()
        {
            txtspn2.Enabled = true;
            txtmats.Enabled = true;
            txtsoluong.Enabled = true;
            txtdongia.Enabled = true;
        }

        private void clearInputCTN()
        {
            txtspn2.Clear();
            txtmats.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
        }

        private void loadDataToDgvPN()
        {
            dgvPN.DataSource = BUS.xuat_PN();
        }

        private void loadDataToDgvCTN(string soPN)
        {
            dgvCTN.DataSource = BUS.xuat_CTNcuaPN(soPN);
        }

        DataTable dtThuThu = new DataTable();
        DataTable dtNCC = new DataTable();

        private void loadTenTT(string maTT)
        {
            cbxthuthu.Text = "";
            foreach(DataRow row in dtThuThu.Rows)
            {
                if (Convert.ToString(row.ItemArray[0]) == maTT)
                {
                    cbxthuthu.Text = Convert.ToString(row.ItemArray[1]);
                    break;
                }
            }
        }

        private void loadTenNCC(string maNCC)
        {
            cbxncc.Text = "";
            foreach (DataRow row in dtNCC.Rows)
            {
                if (Convert.ToString(row.ItemArray[0]) == maNCC)
                {
                    cbxncc.Text = Convert.ToString(row.ItemArray[1]);
                    break;
                }
            }
        }

        private string xuatMaTT(string tenTT)
        {
            string maTT = "";
            foreach(DataRow row in dtThuThu.Rows)
            {
                if (Convert.ToString(row.ItemArray[1]) == tenTT)
                {
                    maTT = Convert.ToString(row.ItemArray[0]);
                    break;
                }
            }
            return maTT;
        }

        private string xuatMaNCC(string tenNCC)
        {
            string maNCC = "";
            foreach (DataRow row in dtNCC.Rows)
            {
                if (Convert.ToString(row.ItemArray[1]) == tenNCC)
                {
                    maNCC = Convert.ToString(row.ItemArray[0]);
                    break;
                }
            }
            return maNCC;
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            loadDataToDgvPN();
            disableInputPN();
            btnSua1.Enabled = false;
            pnlCTN.Enabled = false;
            dtThuThu = BUS.xuat_TT();
            dtNCC = BUS.xuat_NCC();

            foreach (DataRow row in dtThuThu.Rows)
                cbxthuthu.Items.Add(Convert.ToString(row.ItemArray[1]));

            foreach (DataRow row in dtNCC.Rows)
                cbxncc.Items.Add(Convert.ToString(row.ItemArray[1]));
        }

        private void loadToTextPN()
        {
            txtspn1.Text = dgvPN.CurrentRow.Cells[0].Value.ToString();
            date.Text = dgvPN.CurrentRow.Cells[1].Value.ToString();
            loadTenTT(dgvPN.CurrentRow.Cells[2].Value.ToString());
            loadTenNCC(dgvPN.CurrentRow.Cells[3].Value.ToString());
        }

        private void loadToTextCTN()
        {
            txtspn2.Text = dgvCTN.CurrentRow.Cells[0].Value.ToString();
            txtmats.Text = dgvCTN.CurrentRow.Cells[1].Value.ToString();
            txtsoluong.Text = dgvCTN.CurrentRow.Cells[2].Value.ToString();
            txtdongia.Text = dgvCTN.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlCTN.Enabled = false;
            disableInputPN();
            loadToTextPN();
            loadDataToDgvCTN(txtspn1.Text.Trim());
            btnThem1.Enabled = true;
            btnSua1.Enabled = true;
            btnXoa1.Text = "Xóa";
            btnXoa1.Active = true;
            disableInputCTN();
            btnSua2.Enabled = false;
            txtspn2.Text = txtspn1.Text;
        }

        private void dgvCTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disableInputCTN();
            loadToTextCTN();
            btnThem2.Enabled = true;
            btnSua2.Enabled = true;
            btnXoa2.Text = "Xóa";
            btnXoa2.Active = true;
        }

        private void dgvPN_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvPN.CurrentCell = (sender as DataGridView)[0, dgvPN.HitTest(e.X, e.Y).RowIndex];
                    loadToTextPN();
                    cmsPN.Show(dgvPN, e.X, e.Y);
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlCTN.Enabled = true;
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            clearInputPN();
            enableInputPN();
            pnlCTN.Enabled = false;
            clearDataCTN();
            btnSua1.Enabled = false;
            btnXoa1.Text = "Hủy";
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            enableInputPN();
            pnlCTN.Enabled = false;
            clearDataCTN();
            txtspn1.Enabled = false;
            btnThem1.Enabled = false;
            btnXoa1.Text = "Hủy";
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            pnlCTN.Enabled = false;
            clearDataCTN();
            if (btnThem1.Active || btnSua1.Active)
            {
                clearInputPN();
                disableInputPN();
                btnXoa1.Text = "Xóa";
                btnXoa1.Active = true;
                btnThem1.Enabled = true;
                btnSua1.Enabled = false;
            }
            else
            {
                btnXoa1.Text = "Xóa";
                btnXoa1.Active = true;
                btnThem1.Enabled = true;
                btnSua1.Enabled = false;
                if (BUS.xoa_PN(txtspn1.Text) != 1)
                    MessageBox.Show("Không xóa được");
                else
                {
                    loadDataToDgvPN();
                    MessageBox.Show("Xóa Thành Công");
                }
                clearInputPN();
                disableInputPN();
            }
        }

        private void btnCapNhat1_Click(object sender, EventArgs e)
        {
            try
            {
                pnlCTN.Enabled = false;
                clearDataCTN();
                if (btnThem1.Active)
                {
                    QLThuVien.ValueObject.PhieuNhap a = new QLThuVien.ValueObject.PhieuNhap();
                    a.SoPN = txtspn1.Text.Trim();
                    a.NgayLap = date.Value;
                    a.MaTT = xuatMaTT(cbxthuthu.Text.Trim());
                    a.MaNCC = xuatMaNCC(cbxncc.Text.Trim());

                    if (a.SoPN == null || a.SoPN == "") throw new Exception();
                    if (BUS.them_PN(a) == 1)
                    {
                        loadDataToDgvPN();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else throw new Exception();
                }
                else if (btnSua1.Active)
                {
                    QLThuVien.ValueObject.PhieuNhap a = new QLThuVien.ValueObject.PhieuNhap();
                    a.SoPN = txtspn1.Text.Trim();
                    a.NgayLap = date.Value;
                    a.MaTT = xuatMaTT(cbxthuthu.Text.Trim());
                    a.MaNCC = xuatMaNCC(cbxncc.Text.Trim());

                    if (a.SoPN == null || a.SoPN == "") throw new Exception();
                    if (BUS.sua_PN(a) == 1)
                    {
                        loadDataToDgvPN();
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
                clearInputPN();
                disableInputPN();
                btnXoa1.Active = true;
                btnThem1.Enabled = true;
                btnSua1.Enabled = false;
                btnXoa1.Text = "Xóa";
            }
        }

        private void clearDataCTN()
        {
            clearInputCTN();
            dgvCTN.DataSource = null;
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            clearInputCTN();
            enableInputCTN();
            txtspn2.Text = txtspn1.Text;
            txtspn2.Enabled = false;
            btnSua2.Enabled = false;
            btnXoa2.Text = "Hủy";
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            enableInputCTN();
            txtspn2.Enabled = false;
            btnThem2.Enabled = false;
            btnXoa2.Text = "Hủy";
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            if (btnThem2.Active || btnSua2.Active)
            {
                clearInputCTN();
                disableInputCTN();
                btnXoa2.Text = "Xóa";
                btnXoa2.Active = true;
                btnThem2.Enabled = true;
                btnSua2.Enabled = false;
            }
            else
            {
                btnXoa2.Text = "Xóa";
                btnXoa2.Active = true;
                btnThem2.Enabled = true;
                btnSua2.Enabled = false;
                if (BUS.xoa_CTN(txtspn2.Text) != 1)
                    MessageBox.Show("Không xóa được");
                else
                {
                    loadDataToDgvCTN(txtspn2.Text);
                    MessageBox.Show("Xóa Thành Công");
                }
                clearInputCTN();
                disableInputCTN();
            }
        }

        private void btnCapNhat2_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnThem2.Active)
                {
                    QLThuVien.ValueObject.ChiTietNhap a = new QLThuVien.ValueObject.ChiTietNhap();
                    a.SoPN = txtspn2.Text.Trim();
                    a.MaTS = txtmats.Text.Trim();
                    a.SoLuong = int.Parse(txtsoluong.Text.Trim());
                    a.DonGia = int.Parse(txtdongia.Text.Trim());
                    if (a.SoPN == null || a.SoPN == "") throw new Exception();
                    if (BUS.them_CTN(a) == 1)
                    {
                        loadDataToDgvCTN(txtspn2.Text.Trim());
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else throw new Exception();
                }
                else if (btnSua2.Active)
                {
                    QLThuVien.ValueObject.ChiTietNhap a = new QLThuVien.ValueObject.ChiTietNhap();
                    a.SoPN = txtspn2.Text.Trim();
                    a.MaTS = txtmats.Text.Trim();
                    a.SoLuong = int.Parse(txtsoluong.Text.Trim());
                    a.DonGia = int.Parse(txtdongia.Text.Trim());
                    if (a.SoPN == null || a.SoPN == "") throw new Exception();
                    if (BUS.sua_CTN(a) == 1)
                    {
                        loadDataToDgvCTN(txtspn2.Text.Trim());
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
                clearInputCTN();
                disableInputCTN();
                btnXoa2.Active = true;
                btnThem2.Enabled = true;
                btnSua2.Enabled = false;
                btnXoa2.Text = "Xóa";
            }
        }

        private void tongTien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng số tiền thanh toán:\n"+BUS.xuat_TienPN(txtspn1.Text.Trim()));
        }
    }
}
