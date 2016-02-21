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
    public partial class BinaryForm : Form
    {
        int i = 0;
        public BinaryForm(int i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(aField.Text);
                double x = Convert.ToDouble(xField.Text);
                yField.Text = Convert.ToString(MyTools.ArithmeticExpressions.binaryExpressions[i - 1](x, a));
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат входных данных, повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                xField.Focus();
            }
        }

        private void xField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calc.PerformClick();
                exit.Focus();
            }
        }
    }
}
