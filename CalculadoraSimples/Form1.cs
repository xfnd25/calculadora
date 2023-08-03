namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void btnNum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Add;
            }
            else
            {
                FazerContinha(previousOperation);
            }

            txtDisplay.Text += (sender as Button).Text;
        }

        private void FazerContinha(Operation previousOperation)
        {
            List<double> lstNums = new List<double>();

            switch (previousOperation)
            {
                case Operation.Add:
                    lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
                    break;
                case Operation.Sub:
                    lstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] - lstNums[1]).ToString();
                    break;
                case Operation.Mul:
                    lstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
                    break;
                case Operation.Div:
                    break;
                case Operation.None:
                    break;
                default:
                    break;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Sub;
            }
            else
            {
                FazerContinha(previousOperation);
            }
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Mul;
            }
            else
            {
                FazerContinha(previousOperation);
            }
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Div;
            }
            else
            {
                FazerContinha(previousOperation);
            }
            txtDisplay.Text += (sender as Button).Text;
        }

        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        static Operation previousOperation = Operation.None;
    }
}