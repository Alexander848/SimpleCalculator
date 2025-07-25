using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApplication
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
        }

        /// <summary>
        /// Sets Element Fills Container, Font, Background Color.
        /// </summary>
        private void SetElementProperties()
        {
            this.tableLayoutPanel.BackColor = Color.DarkBlue;

            foreach (Control child in this.tableLayoutPanel.Controls)
            {
                child.Dock = System.Windows.Forms.DockStyle.Fill;
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
        /// <param name="sender">Sender Object</param>
        /// <param name="e">Event</param>
        /// <param name="input">String Value of Input Button</param>
        private void EntryButton_Click(object sender, EventArgs e, String input)
        {
            if (this.txtBoxUserEntry.Text.Equals("error"))
                this.txtBoxUserEntry.Text = "";

            if (input.Equals("CE"))
            {
                String currentInput = this.txtBoxUserEntry.Text;
                if (currentInput != null && !currentInput.Equals(""))
                {
                    this.txtBoxUserEntry.Text = currentInput.Remove(currentInput.Length - 1);
                }
            } else if (input.Equals("AC"))
            {
                this.txtBoxUserEntry.Text = "";
            }
            else if (input.Equals("="))
            {
                this.txtBoxUserEntry.Text = CalculationLogic.CalculateMathematicalInput(this.txtBoxUserEntry.Text);
            } else
            {
                this.txtBoxUserEntry.Text += input;
            }
        }
    }
}
