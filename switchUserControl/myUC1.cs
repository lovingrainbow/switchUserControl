using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace switchUserControl
{
    public partial class myUC1 : UserControl
    {
        private static myUC1 _Instance;
        public static myUC1 Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new myUC1();
                return _Instance;
            }
        }
        public myUC1()
        {
            InitializeComponent();
        }
    }
}
