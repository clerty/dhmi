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
        int _i;
        public int i
        {
            get { return _i; }
        }
        public ChooseGroupForm()
        {
            InitializeComponent();
        }

        private void group1_Click(object sender, EventArgs e)
        {
            _i = 1;
            this.Hide();
        }

        private void group2_Click(object sender, EventArgs e)
        {
            _i = 2;
            this.Hide();
        }

    }
}
