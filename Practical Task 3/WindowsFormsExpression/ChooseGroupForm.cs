using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExpression
{
    public partial class ChooseGroupForm : Form
    {
        int _i = 0;
        public int i
        {
            get { return _i; }
        }
        public ChooseGroupForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _i = 1;
        }

        private void group2_CheckedChanged(object sender, EventArgs e)
        {
            _i = 2;
        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
