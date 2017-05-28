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
    public partial class MuonTheoNgay : UserControl
    {
        public MuonTheoNgay()
        {
            InitializeComponent();
        }
        private void load(string a)
        {
            DataTable b = new DataTable();
            b = BUS.tkmuontrongngay(a);
            dgc1.DataSource = b;
        }
        private void flat_Button1_Click(object sender, EventArgs e)
        {
            load(txtngay.Text);

        }
    }
}
