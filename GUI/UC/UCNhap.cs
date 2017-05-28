using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC
{
    public partial class UCNhap : UserControl
    {
        public UCNhap()
        {
            InitializeComponent();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            UC.Tab.PhieuNhap ucPhieuNhap = new Tab.PhieuNhap();
            ucPhieuNhap.Dock = DockStyle.Fill;
            pnlUseNhap.Controls.Add(ucPhieuNhap);
            foreach (Control ctrl in pnlUseNhap.Controls)
            {
                if (ctrl != ucPhieuNhap)
                    ctrl.Dispose();
            }
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            UC.Tab.NCC ucNCC = new Tab.NCC();
            ucNCC.Dock = DockStyle.Fill;
            pnlUseNhap.Controls.Add(ucNCC);
            foreach (Control ctrl in pnlUseNhap.Controls)
            {
                if (ctrl != ucNCC)
                    ctrl.Dispose();
            }
        }

        private void btnSCN_Click(object sender, EventArgs e)
        {
            UC.Tab.SCN ucSCN = new Tab.SCN();
            ucSCN.Dock = DockStyle.Fill;
            pnlUseNhap.Controls.Add(ucSCN);
            foreach (Control ctrl in pnlUseNhap.Controls)
            {
                if (ctrl != ucSCN)
                    ctrl.Dispose();
            }
        }
    }
}
