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
    public partial class myUC2 : UserControl
    {
        private static myUC2 _Instance;
        public static myUC2 Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new myUC2();
                return _Instance;
            }
        }
        public myUC2()
        {
            InitializeComponent();
        }
    }
}
