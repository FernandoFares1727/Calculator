
namespace Calculadora
{
    partial class Calculator
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
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dotButton = new Button();
            deleteButton = new Button();
            resultButton = new Button();
            addButton = new Button();
            subButton = new Button();
            prodButton = new Button();
            divButton = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            resultTextBox = new TextBox();
            resetTextBoxButton = new Button();
            bracketButton = new Button();
            elevButton = new Button();
            rootButton = new Button();
            lastResultButton = new Button();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Location = new Point(20, 349);
            button0.Name = "button0";
            button0.Size = new Size(55, 44);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += addOperation_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 302);
            button1.Name = "button1";
            button1.Size = new Size(55, 44);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addOperation_Click;
            // 
            // button2
            // 
            button2.Location = new Point(81, 302);
            button2.Name = "button2";
            button2.Size = new Size(55, 44);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += addOperation_Click;
            // 
            // button3
            // 
            button3.Location = new Point(142, 302);
            button3.Name = "button3";
            button3.Size = new Size(55, 44);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += addOperation_Click;
            // 
            // dotButton
            // 
            dotButton.Location = new Point(81, 349);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(55, 44);
            dotButton.TabIndex = 4;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = true;
            dotButton.Click += addOperation_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(142, 349);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(55, 44);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "X";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(203, 349);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(55, 44);
            resultButton.TabIndex = 6;
            resultButton.Text = "=";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(203, 302);
            addButton.Name = "addButton";
            addButton.Size = new Size(55, 44);
            addButton.TabIndex = 7;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addOperation_Click;
            // 
            // subButton
            // 
            subButton.Location = new Point(203, 252);
            subButton.Name = "subButton";
            subButton.Size = new Size(55, 44);
            subButton.TabIndex = 8;
            subButton.Text = "-";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += addOperation_Click;
            // 
            // prodButton
            // 
            prodButton.Location = new Point(203, 202);
            prodButton.Name = "prodButton";
            prodButton.Size = new Size(55, 44);
            prodButton.TabIndex = 9;
            prodButton.Text = "*";
            prodButton.UseVisualStyleBackColor = true;
            prodButton.Click += addOperation_Click;
            // 
            // divButton
            // 
            divButton.Location = new Point(203, 152);
            divButton.Name = "divButton";
            divButton.Size = new Size(55, 44);
            divButton.TabIndex = 10;
            divButton.Text = "/";
            divButton.UseVisualStyleBackColor = true;
            divButton.Click += addOperation_Click;
            // 
            // button6
            // 
            button6.Location = new Point(142, 252);
            button6.Name = "button6";
            button6.Size = new Size(55, 44);
            button6.TabIndex = 13;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += addOperation_Click;
            // 
            // button5
            // 
            button5.Location = new Point(81, 252);
            button5.Name = "button5";
            button5.Size = new Size(55, 44);
            button5.TabIndex = 12;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += addOperation_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 252);
            button4.Name = "button4";
            button4.Size = new Size(55, 44);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += addOperation_Click;
            // 
            // button9
            // 
            button9.Location = new Point(142, 202);
            button9.Name = "button9";
            button9.Size = new Size(55, 44);
            button9.TabIndex = 16;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += addOperation_Click;
            // 
            // button8
            // 
            button8.Location = new Point(81, 202);
            button8.Name = "button8";
            button8.Size = new Size(55, 44);
            button8.TabIndex = 15;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += addOperation_Click;
            // 
            // button7
            // 
            button7.Location = new Point(20, 202);
            button7.Name = "button7";
            button7.Size = new Size(55, 44);
            button7.TabIndex = 14;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += addOperation_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(17, 12);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(251, 27);
            resultTextBox.TabIndex = 17;
            // 
            // resetTextBoxButton
            // 
            resetTextBoxButton.Location = new Point(142, 102);
            resetTextBoxButton.Name = "resetTextBoxButton";
            resetTextBoxButton.Size = new Size(55, 44);
            resetTextBoxButton.TabIndex = 18;
            resetTextBoxButton.Text = "ESC";
            resetTextBoxButton.UseVisualStyleBackColor = true;
            resetTextBoxButton.Click += resetTextBox_Click;
            // 
            // bracketButton
            // 
            bracketButton.Location = new Point(142, 152);
            bracketButton.Name = "bracketButton";
            bracketButton.Size = new Size(55, 44);
            bracketButton.TabIndex = 19;
            bracketButton.Text = "( )";
            bracketButton.UseVisualStyleBackColor = true;
            bracketButton.Click += bracketButton_Click;
            // 
            // elevButton
            // 
            elevButton.Location = new Point(81, 152);
            elevButton.Name = "elevButton";
            elevButton.Size = new Size(55, 44);
            elevButton.TabIndex = 20;
            elevButton.Text = "^";
            elevButton.UseVisualStyleBackColor = true;
            elevButton.Click += addOperation_Click;
            // 
            // rootButton
            // 
            rootButton.Location = new Point(20, 152);
            rootButton.Name = "rootButton";
            rootButton.Size = new Size(55, 44);
            rootButton.TabIndex = 21;
            rootButton.Text = "√";
            rootButton.UseVisualStyleBackColor = true;
            rootButton.Click += addOperation_Click;
            // 
            // lastResultButton
            // 
            lastResultButton.Location = new Point(203, 102);
            lastResultButton.Name = "lastResultButton";
            lastResultButton.Size = new Size(55, 44);
            lastResultButton.TabIndex = 22;
            lastResultButton.Text = "ANS";
            lastResultButton.UseVisualStyleBackColor = true;
            lastResultButton.Click += lastResultButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 403);
            Controls.Add(lastResultButton);
            Controls.Add(rootButton);
            Controls.Add(elevButton);
            Controls.Add(bracketButton);
            Controls.Add(resetTextBoxButton);
            Controls.Add(resultTextBox);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(divButton);
            Controls.Add(prodButton);
            Controls.Add(subButton);
            Controls.Add(addButton);
            Controls.Add(resultButton);
            Controls.Add(deleteButton);
            Controls.Add(dotButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button dotButton;
        private Button deleteButton;
        private Button resultButton;
        private Button addButton;
        private Button subButton;
        private Button prodButton;
        private Button divButton;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private TextBox resultTextBox;
        private Button resetTextBoxButton;
        private Button bracketButton;
        private Button elevButton;
        private Button rootButton;
        private Button lastResultButton;
    }
}
