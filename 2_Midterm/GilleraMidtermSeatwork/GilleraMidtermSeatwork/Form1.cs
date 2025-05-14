namespace GilleraMidtermSeatwork
{
    public partial class Form1 : Form
    {
        private double num1, num2, result;
        private string operate;
        private bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // Initial value
        operation.Text = "0";
    }

    // Add to improve user feedback
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // Add a subtle separator line
        using (Pen pen = new Pen(Color.FromArgb(70, 70, 75), 1))
        {
            e.Graphics.DrawLine(pen, 12, 80, 338, 80);
        }
    }

        private void bttnCE_Click(object sender, EventArgs e)
        {
            operation.Text = "0";
        }

        private void bttnC_Click(object sender, EventArgs e)
        {
            operation.Text = "0";
            num1 = num2 = result = 0;
            operate = "";
        }

        private void bttnErase_Click(object sender, EventArgs e)
        {
            if (operation.Text.Length > 1)
                operation.Text = operation.Text.Substring(0, operation.Text.Length - 1);
            else
                operation.Text = "0";
        }

        private void bttnEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation.Text))
            {
                num2 = double.Parse(operation.Text);

                switch (operate)
                {
                    case "+":
                        num1 += num2;
                        break;
                    case "-":
                        num1 -= num2;
                        break;
                    case "*":
                        num1 *= num2;
                        break;
                    case "/":
                        num1 = num2 != 0 ? num1 / num2 : 0;
                        break;
                }

                operation.Text = num1.ToString();
                operate = "";
            }
        }

        private void bttnPN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation.Text) && operation.Text != "0")
            {
                if (operation.Text.StartsWith("-"))
                    operation.Text = operation.Text.Substring(1);
                else
                    operation.Text = "-" + operation.Text;
            }
        }
        private void btnnDot_Click(object sender, EventArgs e)
        {
            if (!operation.Text.Contains("."))
                operation.Text += ".";
        }

        private void bttn0_Click(object sender, EventArgs e) { AppendNumber("0"); }
        private void bttn1_Click(object sender, EventArgs e) { AppendNumber("1"); }
        private void bttn2_Click(object sender, EventArgs e) { AppendNumber("2"); }
        private void bttn3_Click(object sender, EventArgs e) { AppendNumber("3"); }
        private void bttn4_Click(object sender, EventArgs e) { AppendNumber("4"); }
        private void bttn5_Click(object sender, EventArgs e) { AppendNumber("5"); }
        private void bttn6_Click(object sender, EventArgs e) { AppendNumber("6"); }
        private void bttn7_Click(object sender, EventArgs e) { AppendNumber("7"); }
        private void bttn8_Click(object sender, EventArgs e) { AppendNumber("8"); }
        private void bttn9_Click(object sender, EventArgs e) { AppendNumber("9"); }

        private void AppendNumber(string num)
        {
            if (operation.Text == "0" || isOperationPerformed)
                operation.Text = num;
            else
                operation.Text += num;

            isOperationPerformed = false;
        }

        private void bttnPlus_Click(object sender, EventArgs e) { SetOperator("+"); }
        private void bttnMinus_Click(object sender, EventArgs e) { SetOperator("-"); }
        private void bttnTimes_Click(object sender, EventArgs e) { SetOperator("*"); }
        private void bttnDivide_Click(object sender, EventArgs e) { SetOperator("/"); }

        private void SetOperator(string op)
        {
            if (!string.IsNullOrEmpty(operation.Text))
            {
                if (!string.IsNullOrEmpty(operate))
                {
                    bttnEqual_Click(null, null);
                }

                num1 = double.Parse(operation.Text);
                operate = op;
                isOperationPerformed = true;
            }
        }


        private void operation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}