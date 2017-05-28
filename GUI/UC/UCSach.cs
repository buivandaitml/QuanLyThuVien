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
    public partial class UCSach : UserControl
    {
        public UCSach()
        {
            InitializeComponent();
        }

        private void btnTuaSach_Click(object sender, EventArgs e)
        {
            Tab.TuaSach tabTs = new Tab.TuaSach();
            tabTs.Dock = DockStyle.Fill;
            pnlUseSach.Controls.Add(tabTs);
            foreach (Control ctrl in pnlUseSach.Controls)
            {
                if (ctrl != tabTs)
                    ctrl.Dispose();
            }
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            Tab.TacGia tabTg = new Tab.TacGia();
            tabTg.Dock = DockStyle.Fill;
            pnlUseSach.Controls.Add(tabTg);
            foreach (Control ctrl in pnlUseSach.Controls)
            {
                if (ctrl != tabTg)
                    ctrl.Dispose();
            }
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            Tab.TheLoai tabTl = new Tab.TheLoai();
            tabTl.Dock = DockStyle.Fill;
            pnlUseSach.Controls.Add(tabTl);
            foreach (Control ctrl in pnlUseSach.Controls)
            {
                if (ctrl != tabTl)
                    ctrl.Dispose();
            }
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            Tab.NXB tabNXB = new Tab.NXB();
            tabNXB.Dock = DockStyle.Fill;
            pnlUseSach.Controls.Add(tabNXB);
            foreach (Control ctrl in pnlUseSach.Controls)
            {
                if (ctrl != tabNXB)
                    ctrl.Dispose();
            }
        }
    }
}
