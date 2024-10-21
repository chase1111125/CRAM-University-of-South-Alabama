namespace ResillienceCalculatorNSWCDD
{
    partial class frmScoring
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
            btnCalcFinalResillience = new Button();
            txtPhysical = new TextBox();
            txtHardware = new TextBox();
            txtSoftware = new TextBox();
            txtFinalScore = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            lbRisk = new Label();
            btnReset = new Button();
            btnClose = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcFinalResillience
            // 
            btnCalcFinalResillience.Location = new Point(53, 157);
            btnCalcFinalResillience.Name = "btnCalcFinalResillience";
            btnCalcFinalResillience.Size = new Size(186, 29);
            btnCalcFinalResillience.TabIndex = 3;
            btnCalcFinalResillience.Text = "Calculate Resillience";
            btnCalcFinalResillience.UseVisualStyleBackColor = true;
            btnCalcFinalResillience.Click += btnCalcFinalResillience_Click;
            // 
            // txtPhysical
            // 
            txtPhysical.Location = new Point(53, 98);
            txtPhysical.Name = "txtPhysical";
            txtPhysical.Size = new Size(150, 27);
            txtPhysical.TabIndex = 4;
            // 
            // txtHardware
            // 
            txtHardware.Location = new Point(282, 98);
            txtHardware.Name = "txtHardware";
            txtHardware.Size = new Size(150, 27);
            txtHardware.TabIndex = 5;
            // 
            // txtSoftware
            // 
            txtSoftware.Location = new Point(527, 98);
            txtSoftware.Name = "txtSoftware";
            txtSoftware.Size = new Size(150, 27);
            txtSoftware.TabIndex = 6;
            // 
            // txtFinalScore
            // 
            txtFinalScore.Location = new Point(527, 159);
            txtFinalScore.Name = "txtFinalScore";
            txtFinalScore.ReadOnly = true;
            txtFinalScore.Size = new Size(113, 27);
            txtFinalScore.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 161);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 8;
            label1.Text = "Final Resillience Score: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(702, 20);
            label2.TabIndex = 9;
            label2.Text = "Below displays all of the scores; Calculate the resillience below to see the total resillience of the business.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 10;
            label3.Text = "Final Resillience Scoring:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(746, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, exitToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(128, 26);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(646, 159);
            label4.Name = "label4";
            label4.Size = new Size(36, 28);
            label4.TabIndex = 12;
            label4.Text = "/ 5";
            // 
            // lbRisk
            // 
            lbRisk.AutoSize = true;
            lbRisk.Location = new Point(331, 196);
            lbRisk.Name = "lbRisk";
            lbRisk.Size = new Size(38, 20);
            lbRisk.TabIndex = 13;
            lbRisk.Text = "Risk:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(520, 215);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(620, 215);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmScoring
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 256);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPhysical);
            Controls.Add(btnCalcFinalResillience);
            Controls.Add(lbRisk);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtFinalScore);
            Controls.Add(txtSoftware);
            Controls.Add(txtHardware);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmScoring";
            Text = "Final Scoring";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalcFinalResillience;
        private TextBox txtPhysical;
        private TextBox txtHardware;
        private TextBox txtSoftware;
        private TextBox txtFinalScore;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label4;
        private Label lbRisk;
        private Button btnReset;
        private Button btnClose;
    }
}