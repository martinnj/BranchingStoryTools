using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonGui
{
    public partial class VarEditor : UserControl
    {
        public string Varname;
        public string VarValue;
        public VarEditor(string label, string value)
        {
            InitializeComponent();
            label1.Text = label;
            textBox1.Text = value;
            Varname = label;
            VarValue = value;
        }
    }
}
