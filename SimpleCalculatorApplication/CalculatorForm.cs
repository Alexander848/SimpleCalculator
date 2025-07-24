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

        // Sets Element Fills Container, Font
        private void SetElementProperties()
        {
            foreach (Control child in this.tableLayoutPanel.Controls)
            {
                child.Dock = System.Windows.Forms.DockStyle.Fill;
                child.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
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
            if (input.Equals("C"))
            {
                String currentInput = this.txtBoxUserEntry.Text;
                if (currentInput != null && !currentInput.Equals(""))
                {
                    this.txtBoxUserEntry.Text = currentInput.Remove(currentInput.Length - 1);
                }
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
