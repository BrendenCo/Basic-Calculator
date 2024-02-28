using System.Linq.Expressions;
using System.Data;

namespace Basic_Calculator
{
    public partial class Calculator : Form
    {


        public Calculator()
        {
            InitializeComponent();

        }

        private void calculate(object sender, EventArgs e)
        {
            Button? numClicked = sender as Button;

            if (numClicked != null)
            {
                string numText = numClicked.Text;
                string currentText = calcDisplay.Text;

                bool isOperator = numText == "+" || numText == "-" || numText == "x" || numText == "/";

                if (isOperator)
                {
                    // following code is to prevent adding multiple operators
                    if (currentText.Length > 0 && (currentText.EndsWith("+") || currentText.EndsWith("-") ||
                                                   currentText.EndsWith("x") || currentText.EndsWith("/")))
                    {
                        calcDisplay.Text = currentText.Substring(0, currentText.Length - 1) + numText;
                    }
                    else
                    {
                        calcDisplay.Text += numText;
                    }
                }

                else if (currentText.Length > 0 && numText == "<-") // FIXME: Prevent printing "<-" when no characters are present
                {
                    calcDisplay.Text = currentText.Substring(0, currentText.Length - 1);
                }

                else if (numText == "C")
                {
                    calcDisplay.Text = "";
                }


                

                else if (currentText.Length > 0 && numText == "( - )") // FIXME: Fix negative number logic
                {

                    // Check if the current number is already negative
                    if (currentText.StartsWith("-"))
                    {
                        calcDisplay.Text = currentText.Substring(1);
                    }
                    else
                    {
                        calcDisplay.Text = "-" + currentText;
                    }
                }

                else if (currentText.Length > 0 && numText == "=")
                {
                    calcDisplay.Text = currentText;

                    //calculate the result

                    DataTable dt = new DataTable();
                    currentText = currentText.Replace('x', '*');
                    var v = dt.Compute(currentText, "");
                    calcDisplay.Text = v.ToString();
                }

                else if (numText == "(") // FIXME: Fix parentheses logic
                {
                    if (calcDisplay.Text.Contains("("))
                    {
                        return;
                    }
                    else
                    {
                        calcDisplay.Text += numText;
                    }
                }

                else if (numText == ")")
                {
                    if (calcDisplay.Text.Contains(")"))
                    {
                        return;
                    }
                    else
                    {
                        calcDisplay.Text += numText;
                    }
                }

              
                else if (currentText.Length > 0 && numText == ".")
                {

                    // if the number already contains a decimal point
                    if (calcDisplay.Text.Contains("."))
                    {
                        return;
                    }
                    else
                    {
                        calcDisplay.Text = currentText + ".";
                    }
                }

                else
                {
                    // every unspecified character is added to the string.
                    calcDisplay.Text += numText;
                }

            }
        }
    }
}
