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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(aField.Text);
                double x = Convert.ToDouble(xField.Text);
                yField.Text = Convert.ToString(MyTools.ArithmeticExpressions.Expression1(x, a));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число, повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
