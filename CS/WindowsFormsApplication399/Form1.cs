using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication399 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            gridControl1.VisibleChanged += gridControl1_VisibleChanged;
            gridControl2.VisibleChanged += gridControl1_VisibleChanged;
        }

        void gridControl1_VisibleChanged(object sender, EventArgs e) {
            transitionManager1.EndTransition();
        }

        private void navBarControl1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            switch (e.Link.Caption) {
                case "Grid1":
                    transitionManager1.StartTransition(panelControl1);
                    gridControl2.Visible = false;
                    gridControl1.Visible = true;
                    break;
                case "Grid2":
                    transitionManager1.StartTransition(panelControl1);
                    gridControl2.Visible = true;
                    gridControl1.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}
