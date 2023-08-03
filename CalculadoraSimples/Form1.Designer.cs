namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDisplay = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEquals = new Button();
            button19 = new Button();
            btnZero = new Button();
            button17 = new Button();
            btnDiv = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnMult = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnMinus = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnSum = new Button();
            btnReset = new Button();
            btnCopy = new Button();
            btnClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtDisplay, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(326, 479);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            txtDisplay.Dock = DockStyle.Fill;
            txtDisplay.Location = new Point(3, 3);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(320, 89);
            txtDisplay.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnEquals, 3, 4);
            tableLayoutPanel2.Controls.Add(button19, 2, 4);
            tableLayoutPanel2.Controls.Add(btnZero, 1, 4);
            tableLayoutPanel2.Controls.Add(button17, 0, 4);
            tableLayoutPanel2.Controls.Add(btnDiv, 3, 3);
            tableLayoutPanel2.Controls.Add(btnThree, 2, 3);
            tableLayoutPanel2.Controls.Add(btnTwo, 1, 3);
            tableLayoutPanel2.Controls.Add(btnOne, 0, 3);
            tableLayoutPanel2.Controls.Add(btnMult, 3, 2);
            tableLayoutPanel2.Controls.Add(btnSix, 2, 2);
            tableLayoutPanel2.Controls.Add(btnFive, 1, 2);
            tableLayoutPanel2.Controls.Add(btnFour, 0, 2);
            tableLayoutPanel2.Controls.Add(btnMinus, 3, 1);
            tableLayoutPanel2.Controls.Add(btnNine, 2, 1);
            tableLayoutPanel2.Controls.Add(btnEight, 1, 1);
            tableLayoutPanel2.Controls.Add(btnSeven, 0, 1);
            tableLayoutPanel2.Controls.Add(btnSum, 3, 0);
            tableLayoutPanel2.Controls.Add(btnReset, 2, 0);
            tableLayoutPanel2.Controls.Add(btnCopy, 1, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 98);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(320, 378);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnEquals
            // 
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Location = new Point(243, 303);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(74, 72);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Dock = DockStyle.Fill;
            button19.Location = new Point(163, 303);
            button19.Name = "button19";
            button19.Size = new Size(74, 72);
            button19.TabIndex = 18;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            btnZero.Dock = DockStyle.Fill;
            btnZero.Location = new Point(83, 303);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(74, 72);
            btnZero.TabIndex = 17;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnNum_Click;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Fill;
            button17.Location = new Point(3, 303);
            button17.Name = "button17";
            button17.Size = new Size(74, 72);
            button17.TabIndex = 16;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Dock = DockStyle.Fill;
            btnDiv.Location = new Point(243, 228);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(74, 69);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnThree
            // 
            btnThree.Dock = DockStyle.Fill;
            btnThree.Location = new Point(163, 228);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(74, 69);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnNum_Click;
            // 
            // btnTwo
            // 
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.Location = new Point(83, 228);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(74, 69);
            btnTwo.TabIndex = 13;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnNum_Click;
            // 
            // btnOne
            // 
            btnOne.Dock = DockStyle.Fill;
            btnOne.Location = new Point(3, 228);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(74, 69);
            btnOne.TabIndex = 12;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnNum_Click;
            // 
            // btnMult
            // 
            btnMult.Dock = DockStyle.Fill;
            btnMult.Location = new Point(243, 153);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(74, 69);
            btnMult.TabIndex = 11;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnSix
            // 
            btnSix.Dock = DockStyle.Fill;
            btnSix.Location = new Point(163, 153);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(74, 69);
            btnSix.TabIndex = 10;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnNum_Click;
            // 
            // btnFive
            // 
            btnFive.Dock = DockStyle.Fill;
            btnFive.Location = new Point(83, 153);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(74, 69);
            btnFive.TabIndex = 9;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnNum_Click;
            // 
            // btnFour
            // 
            btnFour.Dock = DockStyle.Fill;
            btnFour.Location = new Point(3, 153);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(74, 69);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnNum_Click;
            // 
            // btnMinus
            // 
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Location = new Point(243, 78);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(74, 69);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnNine
            // 
            btnNine.Dock = DockStyle.Fill;
            btnNine.Location = new Point(163, 78);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(74, 69);
            btnNine.TabIndex = 6;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNum_Click;
            // 
            // btnEight
            // 
            btnEight.Dock = DockStyle.Fill;
            btnEight.Location = new Point(83, 78);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(74, 69);
            btnEight.TabIndex = 5;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnNum_Click;
            // 
            // btnSeven
            // 
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.Location = new Point(3, 78);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(74, 69);
            btnSeven.TabIndex = 4;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnNum_Click;
            // 
            // btnSum
            // 
            btnSum.Dock = DockStyle.Fill;
            btnSum.Location = new Point(243, 3);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(74, 69);
            btnSum.TabIndex = 3;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Fill;
            btnReset.Location = new Point(163, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(74, 69);
            btnReset.TabIndex = 2;
            btnReset.Text = "Limpar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCopy
            // 
            btnCopy.Dock = DockStyle.Fill;
            btnCopy.Location = new Point(83, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(74, 69);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copiar";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 69);
            btnClear.TabIndex = 0;
            btnClear.Text = "Apagar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 503);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "calculadora 1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button19;
        private Button btnZero;
        private Button button17;
        private Button btnDiv;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnMult;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnMinus;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnSum;
        private Button btnReset;
        private Button btnCopy;
        private Button btnClear;
        private Button btnEquals;
    }
}