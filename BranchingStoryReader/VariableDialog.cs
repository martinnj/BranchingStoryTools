using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSTParser;
using CommonGui;


namespace BranchingStoryReader
{
    public partial class VariableDialog : Form
    {
        /// <summary>
        /// Variables we want to edit.
        /// </summary>
        public Hashtable Vars;

        public VariableDialog(Hashtable vars)
        {
            InitializeComponent();
            Vars = vars;

            // Read variables from the hashtable and add appropriate controls.
            foreach (DictionaryEntry entry in Vars)
            {
                flowLayoutPanel1.Controls.Add(new VarEditor(entry.Key.ToString(), entry.Value.ToString()));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Save controls data back to Vars.
            foreach (VarEditor v in flowLayoutPanel1.Controls)
            {
                Vars[v.Varname] = v.VarValue;
            }
        }
    }
}
