namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double? x = null;
        private string pendingOperator = null;
        private string pendingSingleOperator = null;
        private bool justCalculated = false;
        private bool isNegated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button0_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("9");
        }
        // determines whether to start a new number or append to the existing one
        private void HandleNumberButtonClick(string number)
        {
            if (justCalculated)
            {
                textBox1.Text = number;
                justCalculated = false;
            }
            else
            {
                if (textBox1.Text == "0") // if string is just 0, replace it with the number
                {
                    textBox1.Text = number;
                }
                else
                {
                    textBox1.Text += number;
                }
            }
        }
        // operator button handlers
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            HandleOperator("+");
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            HandleOperator("-");
        }
        private void buttonMul_Click(object sender, EventArgs e)
        {
            HandleOperator("*");
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            HandleOperator("/");
        }
        private void buttonRem_Click(object sender, EventArgs e)
        {
            HandleOperator("%");
        }

        // operation button handlers which only need 1 number
        private void buttonExp_Click(object sender, EventArgs e)
        {
            HandleSingleOperator("^");
        }
        private void buttonRoot_Click(object sender, EventArgs e)
        {
            HandleSingleOperator("sqroot");
        }
        private void buttonLog_Click(object sender, EventArgs e)
        {
            HandleSingleOperator("log");
        }
        private void buttonNeg_Click(object sender, EventArgs e)
        {
            HandleSingleOperator("neg");
        }


        //determines whether to perform a calculation or set the operator
        private void HandleOperator(string op)
        {
            if (double.TryParse(textBox1.Text, out double value)) // outputs the textbox number as a double variable "value".
            {
                if (x == null) // this is to set the value of x 
                {
                    x = value;
                }
                else if (pendingOperator != null && !justCalculated)
                {
                    x = Calculate(x.Value, value, pendingOperator);
                    textBox1.Text = x.ToString(); // Display the result
                    justCalculated = true;  // for the bottom if-block, so the result doesnt get cleared.
                }
            }
            pendingOperator = op;

            if (!justCalculated) // this is so that we don't clear the answer
            {
                textBox1.Text = string.Empty;
            }
        }

        // performs the calculation based on the operator
        private double Calculate(double left, double right, string op)
        {
            // Handle division by zero
            if (op == "/" && right == 0)
            {
                textBox1.Text = "Error";
                MessageBox.Show("Cannot divide by 0.");
                justCalculated = true;
                pendingOperator = null;
                return 0;
            }
            else
            {
                // depending on the operator, return a value from the appropriate computation
                return op switch
                {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => left / right,
                    "%" => left % right,
                    _ => right
                };
            }
        }
        private void HandleSingleOperator(string sop)
        {
            if (double.TryParse(textBox1.Text, out double value)) // outputs the textbox number as a double variable "value".
            {
                textBox1.Text = (CalculateSingle(value, sop)).ToString(); // Display the result, while not tampering with x, allowing you to calculate the single operator while the pending operator stays
                justCalculated = true;
                pendingSingleOperator = null; // Clear the operator after calculation
            }
        }

        private double CalculateSingle(double num, string sop)
        {
            // Handle negation by zero, because without this it outputs -0, which although doesn't affect calculation, could be confusing.
            if (sop == "neg" && num == 0)
            {
                return 0;
            }

            return sop switch
            {
                "sqroot" => Math.Sqrt(num),
                "^" => Math.Pow(num, 2),
                "log" => Math.Log(num),
                "neg" => -num,
                _ => num
            };
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            x = null;
            pendingOperator = null;
            pendingSingleOperator = null;
            justCalculated = false;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (pendingOperator != null && double.TryParse(textBox1.Text, out double value) && x != null)
            {
                x = Calculate(x.Value, value, pendingOperator);
                textBox1.Text = x.ToString(); // Display the result
                justCalculated = true;
                pendingOperator = null; // Clear the operator after calculation
                x = null; // Reset x to allow new calculations
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            // Only allow one decimal point in the current number
            if (justCalculated)
            {
                textBox1.Text = "0.";
                justCalculated = false;
            }
            else if (!textBox1.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                    textBox1.Text = "0.";
                else
                    textBox1.Text += ".";
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
        }

        private void buttonClearLine_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
