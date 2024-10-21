namespace ResillienceCalculatorNSWCDD
{
    partial class frmSoftware
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
            button1 = new Button();
            txtEntropy = new Label();
            openFileDialog1 = new OpenFileDialog();
            lstOutput = new ListBox();
            btnClose = new Button();
            btnReset = new Button();
            txtAverageEntropy = new TextBox();
            txtAmtOfFiles = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 0;
            label1.Text = "Software Resillience Calculator:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 229);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEntropy
            // 
            txtEntropy.AutoSize = true;
            txtEntropy.Location = new Point(12, 58);
            txtEntropy.Name = "txtEntropy";
            txtEntropy.Size = new Size(126, 20);
            txtEntropy.TabIndex = 2;
            txtEntropy.Text = "Average Entropy: ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(346, 22);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(294, 184);
            lstOutput.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(546, 229);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(446, 229);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtAverageEntropy
            // 
            txtAverageEntropy.Location = new Point(140, 55);
            txtAverageEntropy.Name = "txtAverageEntropy";
            txtAverageEntropy.Size = new Size(125, 27);
            txtAverageEntropy.TabIndex = 7;
            // 
            // txtAmtOfFiles
            // 
            txtAmtOfFiles.Location = new Point(140, 111);
            txtAmtOfFiles.Name = "txtAmtOfFiles";
            txtAmtOfFiles.Size = new Size(125, 27);
            txtAmtOfFiles.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 9;
            label2.Text = "Number of Files: ";
            // 
            // frmSoftware
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 270);
            Controls.Add(label2);
            Controls.Add(txtAmtOfFiles);
            Controls.Add(txtAverageEntropy);
            Controls.Add(btnReset);
            Controls.Add(btnClose);
            Controls.Add(lstOutput);
            Controls.Add(txtEntropy);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frmSoftware";
            Text = "Software";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label txtEntropy;
        private OpenFileDialog openFileDialog1;
        private ListBox lstOutput;
        private Button btnClose;
        private Button btnReset;
        private TextBox txtAverageEntropy;
        private TextBox txtAmtOfFiles;
        private Label label2;
    }
}