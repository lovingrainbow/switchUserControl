using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace switchUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(myUC1.Instance))
            {
                panel.Controls.Add(myUC1.Instance);
                myUC1.Instance.Dock = DockStyle.Fill;
                myUC1.Instance.BringToFront();
            }
            else
                myUC1.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(myUC2.Instance))
            {
                panel.Controls.Add(myUC2.Instance);
                myUC2.Instance.Dock = DockStyle.Fill;
                myUC2.Instance.BringToFront();
            }
            else
                myUC2.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(myUC3.Instance))
            {
                panel.Controls.Add(myUC3.Instance);
                myUC3.Instance.Dock = DockStyle.Fill;
                myUC3.Instance.BringToFront();
            }
            else
                myUC3.Instance.BringToFront();
        }
    }
}
