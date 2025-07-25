
using SimpleCalculator.Logic;

namespace SimpleCalculator.Application
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            SetElementProperties();

            this.btnNumberOne.Click += (s,e) => InputButton_Click("1");
            this.btnNumberFour.Click += (s,e) => InputButton_Click("4");
            this.btnNumberSeven.Click += (s,e) => InputButton_Click("7");
            this.btnDecimalPoint.Click += (s,e) => InputButton_Click(".");
            this.btnNumberTwo.Click += (s,e) => InputButton_Click("2");
            this.btnNumberFive.Click += (s,e) => InputButton_Click("5");
            this.btnNumberEight.Click += (s,e) => InputButton_Click("8");
            this.btnNumberZero.Click += (s,e) => InputButton_Click("0");
            this.btnNumberThree.Click += (s,e) => InputButton_Click("3");
            this.btnNumberSix.Click += (s,e) => InputButton_Click("6");
            this.btnNumberNine.Click += (s,e) => InputButton_Click("9");
            this.btnCalculate.Click += (s,e) => InputButton_Click("=");
            this.btnOpenBracket.Click += (s,e) => InputButton_Click("(");
            this.btnPlus.Click += (s,e) => InputButton_Click("+");
            this.btnMultiplication.Click += (s,e) => InputButton_Click("*");
            this.btnClearEntry.Click += (s,e) => InputButton_Click("CE");
            this.btnClosingBracket.Click += (s,e) => InputButton_Click(")");
            this.btnMinus.Click += (s,e) => InputButton_Click("-");
            this.btnDivision.Click += (s,e) => InputButton_Click("/");
            this.btnAllClear.Click += (s,e) => InputButton_Click("AC");
        }

        /// <summary>
        /// Sets Element Fills Container, Font, Background Color.
        /// </summary>
        private void SetElementProperties()
        {
            this.tableLayoutPanel.BackColor = Color.DarkBlue;

            foreach (Control child in this.tableLayoutPanel.Controls)
            {
                child.Dock = DockStyle.Fill;
                child.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
                if (child != this.btnCalculate)
                    child.BackColor = Color.LightBlue;
                else
                    child.BackColor = Color.LightGreen;
            }
        }

        /// <summary>
        /// Depending on Button, handles input. Either add value to txtBoxUserEntry,
        /// remove element from txtBoxUserEntry or calculate txtBoxUserEntry.
        /// </summary>
        /// <param name="input">String Value of Input Button</param>
        private void InputButton_Click(String input)
        {
            if (input == null)
                return;

            if (this.txtBoxUserEntry.Text.Equals("error"))
                this.txtBoxUserEntry.Text = "";

            if (input.Equals("CE"))
            {
                String currentInput = this.txtBoxUserEntry.Text;
                if (currentInput != null && !currentInput.Equals(""))
                {
                    this.txtBoxUserEntry.Text = currentInput[..^1];
                }
            }
            else if (input.Equals("AC"))
            {
                this.txtBoxUserEntry.Text = "";
            }
            else if (input.Equals("="))
            {
                this.txtBoxUserEntry.Text = CalculationLogic.CalculateMathematicalInput(this.txtBoxUserEntry.Text);
            }
            else
            {
                this.txtBoxUserEntry.Text += input;
            }
        }
    }
}
