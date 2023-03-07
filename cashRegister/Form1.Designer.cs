namespace cashRegister
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gumLabel = new System.Windows.Forms.Label();
            this.chocolateLabel = new System.Windows.Forms.Label();
            this.icecreamLabel = new System.Windows.Forms.Label();
            this.gumInput = new System.Windows.Forms.TextBox();
            this.chocolateInput = new System.Windows.Forms.TextBox();
            this.icecreamInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumLabel
            // 
            this.gumLabel.AutoSize = true;
            this.gumLabel.Location = new System.Drawing.Point(23, 19);
            this.gumLabel.Name = "gumLabel";
            this.gumLabel.Size = new System.Drawing.Size(44, 20);
            this.gumLabel.TabIndex = 0;
            this.gumLabel.Text = "Gum";
            // 
            // chocolateLabel
            // 
            this.chocolateLabel.AutoSize = true;
            this.chocolateLabel.Location = new System.Drawing.Point(23, 58);
            this.chocolateLabel.Name = "chocolateLabel";
            this.chocolateLabel.Size = new System.Drawing.Size(81, 20);
            this.chocolateLabel.TabIndex = 1;
            this.chocolateLabel.Text = "Chocolate";
            // 
            // icecreamLabel
            // 
            this.icecreamLabel.AutoSize = true;
            this.icecreamLabel.Location = new System.Drawing.Point(23, 96);
            this.icecreamLabel.Name = "icecreamLabel";
            this.icecreamLabel.Size = new System.Drawing.Size(82, 20);
            this.icecreamLabel.TabIndex = 2;
            this.icecreamLabel.Text = "Ice Cream";
            // 
            // gumInput
            // 
            this.gumInput.Location = new System.Drawing.Point(108, 19);
            this.gumInput.Name = "gumInput";
            this.gumInput.Size = new System.Drawing.Size(100, 26);
            this.gumInput.TabIndex = 3;
            // 
            // chocolateInput
            // 
            this.chocolateInput.Location = new System.Drawing.Point(108, 58);
            this.chocolateInput.Name = "chocolateInput";
            this.chocolateInput.Size = new System.Drawing.Size(100, 26);
            this.chocolateInput.TabIndex = 4;
            // 
            // icecreamInput
            // 
            this.icecreamInput.Location = new System.Drawing.Point(108, 96);
            this.icecreamInput.Name = "icecreamInput";
            this.icecreamInput.Size = new System.Drawing.Size(100, 26);
            this.icecreamInput.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 128);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(215, 33);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(23, 176);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(77, 20);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(23, 214);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(34, 20);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(23, 252);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(104, 176);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 20);
            this.subtotalOutput.TabIndex = 10;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(104, 214);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 20);
            this.taxOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(104, 252);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 20);
            this.totalOutput.TabIndex = 12;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 292);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(77, 20);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(95, 289);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 26);
            this.tenderedInput.TabIndex = 14;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(16, 321);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(181, 32);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(16, 384);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(170, 54);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Print Recipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Location = new System.Drawing.Point(349, 9);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(288, 409);
            this.receiptOutput.TabIndex = 17;
            // 
            // neworderButton
            // 
            this.neworderButton.Location = new System.Drawing.Point(675, 358);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(98, 60);
            this.neworderButton.TabIndex = 18;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(256, 292);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 20);
            this.changeOutput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Change due";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.icecreamInput);
            this.Controls.Add(this.chocolateInput);
            this.Controls.Add(this.gumInput);
            this.Controls.Add(this.icecreamLabel);
            this.Controls.Add(this.chocolateLabel);
            this.Controls.Add(this.gumLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gumLabel;
        private System.Windows.Forms.Label chocolateLabel;
        private System.Windows.Forms.Label icecreamLabel;
        private System.Windows.Forms.TextBox gumInput;
        private System.Windows.Forms.TextBox chocolateInput;
        private System.Windows.Forms.TextBox icecreamInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label label2;
    }
}

