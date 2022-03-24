using Microsoft.VisualBasic.Logging;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((tb_result.Text == "0") || (isOperationPerformed))
            {
                tb_result.Clear();
            }

            if (button.Text == ",")
            {
                if (!tb_result.Text.Contains(","))
                {
                    tb_result.Text = tb_result.Text + button.Text;
                }
            }
            else
            {
                tb_result.Text = tb_result.Text + button.Text;
            }
            isOperationPerformed = false;

        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEq.PerformClick();
                operationPerformed = button.Text;
                labelCO.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(tb_result.Text);
                labelCO.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void CEClick(object sender, EventArgs e)
        {
            tb_result.Text = "0";
        }

        private void CClick(object sender, EventArgs e)
        {
            tb_result.Text = "0";
            resultValue = 0;

        }

        private void eqClick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    tb_result.Text = (resultValue + Double.Parse(tb_result.Text)).ToString();
                    break;
                case "-":
                    tb_result.Text = (resultValue - Double.Parse(tb_result.Text)).ToString();
                    break;
                case "*":
                    tb_result.Text = (resultValue * Double.Parse(tb_result.Text)).ToString();
                    break;
                case "/":
                    tb_result.Text = (resultValue / Double.Parse(tb_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(tb_result.Text);
            labelCO.Text = "";
        }
    }
}