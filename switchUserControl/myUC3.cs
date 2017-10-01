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
    public partial class myUC3 : UserControl
    {
        private static myUC3 _Instance;
        public static myUC3 Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new myUC3();
                return _Instance;
            }
        }
        public myUC3()
        {
            InitializeComponent();
        }
    }
}
