using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator.Application
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxUserEntry = new System.Windows.Forms.TextBox();
            this.btnNumberOne = new System.Windows.Forms.Button();
            this.btnNumberFour = new System.Windows.Forms.Button();
            this.btnNumberSeven = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnNumberTwo = new System.Windows.Forms.Button();
            this.btnNumberFive = new System.Windows.Forms.Button();
            this.btnNumberEight = new System.Windows.Forms.Button();
            this.btnNumberZero = new System.Windows.Forms.Button();
            this.btnNumberThree = new System.Windows.Forms.Button();
            this.btnNumberSix = new System.Windows.Forms.Button();
            this.btnNumberNine = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnOpenBracket = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClosingBracket = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUserEntry
            // 
            this.tableLayoutPanel.SetColumnSpan(this.txtBoxUserEntry, 5);
            this.txtBoxUserEntry.Multiline = true;
            this.txtBoxUserEntry.WordWrap = false;
            this.txtBoxUserEntry.AcceptsReturn = false;
            this.txtBoxUserEntry.Name = "txtBoxUserEntry";
            this.txtBoxUserEntry.TabIndex = 0;
            // 
            // btnNumberOne
            //
            this.btnNumberOne.Name = "btnNumberOne";
            this.btnNumberOne.TabIndex = 1;
            this.btnNumberOne.Text = "1";
            // 
            // btnNumberFour
            //
            this.btnNumberFour.Name = "btnNumberFour";
            this.btnNumberFour.TabIndex = 6;
            this.btnNumberFour.Text = "4";
            // 
            // btnNumberSeven
            //
            this.btnNumberSeven.Name = "btnNumberSeven";
            this.btnNumberSeven.TabIndex = 11;
            this.btnNumberSeven.Text = "7";
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.TabIndex = 16;
            this.btnDecimalPoint.Text = ".";
            // 
            // btnNumberTwo
            //
            this.btnNumberTwo.Name = "btnNumberTwo";
            this.btnNumberTwo.TabIndex = 2;
            this.btnNumberTwo.Text = "2";
            // 
            // btnNumberFive
            //
            this.btnNumberFive.Name = "btnNumberFive";
            this.btnNumberFive.TabIndex = 7;
            this.btnNumberFive.Text = "5";
            // 
            // btnNumberEight
            //
            this.btnNumberEight.Name = "btnNumberEight";
            this.btnNumberEight.TabIndex = 12;
            this.btnNumberEight.Text = "8";
            // 
            // btnNumberZero
            // 
            this.btnNumberZero.Name = "btnNumberZero";
            this.btnNumberZero.TabIndex = 17;
            this.btnNumberZero.Text = "0";
            // 
            // btnNumberThree
            //
            this.btnNumberThree.Name = "btnNumberThree";
            this.btnNumberThree.TabIndex = 3;
            this.btnNumberThree.Text = "3";
            // 
            // btnNumberSix
            // 
            this.btnNumberSix.Name = "btnNumberSix";
            this.btnNumberSix.TabIndex = 8;
            this.btnNumberSix.Text = "6";
            // 
            // btnNumberNine
            // 
            this.btnNumberNine.Name = "btnNumberNine";
            this.btnNumberNine.TabIndex = 13;
            this.btnNumberNine.Text = "9";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "=";
            // 
            // btnOpenBracket
            //
            this.btnOpenBracket.Name = "btnOpenBracket";
            this.btnOpenBracket.TabIndex = 4;
            this.btnOpenBracket.Text = "(";
            // 
            // btnPlus
            //
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            // 
            // btnMultiplication
            //
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.TabIndex = 14;
            this.btnMultiplication.Text = "*";
            // 
            // btnClearEntry
            //
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.TabIndex = 19;
            this.btnClearEntry.Text = "CE";
            // 
            // btnClosingBracket
            //
            this.btnClosingBracket.Name = "btnClosingBracket";
            this.btnClosingBracket.TabIndex = 5;
            this.btnClosingBracket.Text = ")";
            // 
            // btnMinus
            //
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            // 
            // btnDivision
            //
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.TabIndex = 15;
            this.btnDivision.Text = "/";
            // 
            // btnAllClear
            // 
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.TabIndex = 20;
            this.btnAllClear.Text = "AC";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.txtBoxUserEntry, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnNumberOne, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnNumberFour, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnNumberSeven, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnDecimalPoint, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.btnNumberTwo, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.btnNumberFive, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnNumberEight, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.btnNumberZero, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnNumberThree, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.btnNumberSix, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.btnNumberNine, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.btnCalculate, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.btnOpenBracket, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.btnPlus, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.btnMultiplication, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.btnClearEntry, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.btnClosingBracket, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.btnMinus, 4, 2);
            this.tableLayoutPanel.Controls.Add(this.btnDivision, 4, 3);
            this.tableLayoutPanel.Controls.Add(this.btnAllClear, 4, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(20, 144);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Padding = new Padding(5);
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.Load += Calculator_Load;
        }

        private System.Windows.Forms.TextBox txtBoxUserEntry;
        private Button btnNumberOne;
        private Button btnNumberFour;
        private Button btnNumberSeven;
        private Button btnDecimalPoint;
        private Button btnNumberTwo;
        private Button btnNumberFive;
        private Button btnNumberEight;
        private Button btnNumberZero;
        private Button btnNumberThree;
        private Button btnNumberSix;
        private Button btnNumberNine;
        private Button btnCalculate;
        private Button btnOpenBracket;
        private Button btnPlus;
        private Button btnMultiplication;
        private Button btnClearEntry;
        private Button btnClosingBracket;
        private Button btnMinus;
        private Button btnDivision;
        private Button btnAllClear;
        private TableLayoutPanel tableLayoutPanel;
    }
}

