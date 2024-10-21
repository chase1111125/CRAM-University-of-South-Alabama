namespace ResillienceCalculatorNSWCDD
{
    partial class frmPhysicalRes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtScore5 = new TextBox();
            txtScore4 = new TextBox();
            txtScore3 = new TextBox();
            txtScore2 = new TextBox();
            txtScore1 = new TextBox();
            label6 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            btnReset = new Button();
            lstPhysicalOutput = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 104);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "Perimeter and Entry Controls";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 141);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 1;
            label2.Text = "Physical Access Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 175);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 2;
            label3.Text = "Environmental Controls";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 209);
            label4.Name = "label4";
            label4.Size = new Size(211, 20);
            label4.TabIndex = 3;
            label4.Text = "Data and Hardware Protection";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 246);
            label5.Name = "label5";
            label5.Size = new Size(236, 20);
            label5.TabIndex = 4;
            label5.Text = "Monitoring and Incident Response";
            // 
            // txtScore5
            // 
            txtScore5.Location = new Point(268, 248);
            txtScore5.Margin = new Padding(3, 4, 3, 4);
            txtScore5.Name = "txtScore5";
            txtScore5.Size = new Size(114, 27);
            txtScore5.TabIndex = 5;
            // 
            // txtScore4
            // 
            txtScore4.Location = new Point(268, 210);
            txtScore4.Margin = new Padding(3, 4, 3, 4);
            txtScore4.Name = "txtScore4";
            txtScore4.Size = new Size(114, 27);
            txtScore4.TabIndex = 4;
            // 
            // txtScore3
            // 
            txtScore3.Location = new Point(268, 172);
            txtScore3.Margin = new Padding(3, 4, 3, 4);
            txtScore3.Name = "txtScore3";
            txtScore3.Size = new Size(114, 27);
            txtScore3.TabIndex = 3;
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(268, 134);
            txtScore2.Margin = new Padding(3, 4, 3, 4);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(114, 27);
            txtScore2.TabIndex = 2;
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(268, 100);
            txtScore1.Margin = new Padding(3, 4, 3, 4);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(114, 27);
            txtScore1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(201, 28);
            label6.TabIndex = 10;
            label6.Text = "Physical Resillience:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(246, 283);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(160, 32);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(720, 284);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 8;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(627, 284);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lstPhysicalOutput
            // 
            lstPhysicalOutput.FormattingEnabled = true;
            lstPhysicalOutput.Location = new Point(429, 100);
            lstPhysicalOutput.Margin = new Padding(3, 4, 3, 4);
            lstPhysicalOutput.Name = "lstPhysicalOutput";
            lstPhysicalOutput.Size = new Size(377, 144);
            lstPhysicalOutput.TabIndex = 14;
            lstPhysicalOutput.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 52);
            label7.Name = "label7";
            label7.Size = new Size(616, 40);
            label7.TabIndex = 15;
            label7.Text = "This page corresponds with the Physical Security Resillience Checklist inside Documentation:\r\n\r\n";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPhysicalRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 329);
            Controls.Add(label7);
            Controls.Add(lstPhysicalOutput);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(label6);
            Controls.Add(txtScore1);
            Controls.Add(txtScore2);
            Controls.Add(txtScore3);
            Controls.Add(txtScore4);
            Controls.Add(txtScore5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPhysicalRes";
            Text = "frmPhysicalRes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtScore5;
        private TextBox txtScore4;
        private TextBox txtScore3;
        private TextBox txtScore2;
        private TextBox txtScore1;
        private Label label6;
        private Button btnCalculate;
        private Button btnExit;
        private Button btnReset;
        private ListBox lstPhysicalOutput;
        private Label label7;
    }
}