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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            setElementProperties();
        }

        private void setElementProperties()
        {
            foreach (Control child in this.tableLayoutPanel.Controls)
            {
                child.Dock = System.Windows.Forms.DockStyle.Fill;
                child.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            }
        }
    }
}
