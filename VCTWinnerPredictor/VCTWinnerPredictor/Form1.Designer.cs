namespace VCTWinnerPredictor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamA = new System.Windows.Forms.Label();
            this.teamACombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.teamARankingLabel = new System.Windows.Forms.Label();
            this.teamARosterLabel = new System.Windows.Forms.Label();
            this.teamAWinLabel = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teamB = new System.Windows.Forms.Label();
            this.teamBCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.teamBRankingLabel = new System.Windows.Forms.Label();
            this.teamBRosterLabel = new System.Windows.Forms.Label();
            this.teamBWinLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 311);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(600, 311);
            this.splitContainer3.SplitterDistance = 300;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer4.Size = new System.Drawing.Size(300, 311);
            this.splitContainer4.SplitterDistance = 100;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamA);
            this.groupBox1.Controls.Add(this.teamACombo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team A";
            // 
            // teamA
            // 
            this.teamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamA.Location = new System.Drawing.Point(3, 37);
            this.teamA.Name = "teamA";
            this.teamA.Size = new System.Drawing.Size(294, 60);
            this.teamA.TabIndex = 1;
            this.teamA.Text = "Team A name";
            this.teamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamACombo
            // 
            this.teamACombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamACombo.FormattingEnabled = true;
            this.teamACombo.Items.AddRange(new object[] {
            "100 Thieves",
            "Cloud9",
            "Evil Geniuses",
            "FURIA",
            "KRU Esports",
            "Leviatan",
            "LOUD",
            "MIBR",
            "NRG Esports",
            "Sentinels",
            "G2 Esports"});
            this.teamACombo.Location = new System.Drawing.Point(3, 16);
            this.teamACombo.Name = "teamACombo";
            this.teamACombo.Size = new System.Drawing.Size(294, 21);
            this.teamACombo.TabIndex = 0;
            this.teamACombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.teamARankingLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.teamARosterLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.teamAWinLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 207);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // teamARankingLabel
            // 
            this.teamARankingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamARankingLabel.Location = new System.Drawing.Point(3, 138);
            this.teamARankingLabel.Name = "teamARankingLabel";
            this.teamARankingLabel.Size = new System.Drawing.Size(294, 69);
            this.teamARankingLabel.TabIndex = 2;
            this.teamARankingLabel.Text = "label3";
            this.teamARankingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamARosterLabel
            // 
            this.teamARosterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamARosterLabel.Location = new System.Drawing.Point(3, 69);
            this.teamARosterLabel.Name = "teamARosterLabel";
            this.teamARosterLabel.Size = new System.Drawing.Size(294, 69);
            this.teamARosterLabel.TabIndex = 1;
            this.teamARosterLabel.Text = "label2";
            this.teamARosterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamAWinLabel
            // 
            this.teamAWinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamAWinLabel.Location = new System.Drawing.Point(3, 0);
            this.teamAWinLabel.Name = "teamAWinLabel";
            this.teamAWinLabel.Size = new System.Drawing.Size(294, 69);
            this.teamAWinLabel.TabIndex = 0;
            this.teamAWinLabel.Text = "label1";
            this.teamAWinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer5.Size = new System.Drawing.Size(296, 311);
            this.splitContainer5.SplitterDistance = 100;
            this.splitContainer5.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teamB);
            this.groupBox2.Controls.Add(this.teamBCombo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team B";
            // 
            // teamB
            // 
            this.teamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamB.Location = new System.Drawing.Point(3, 37);
            this.teamB.Name = "teamB";
            this.teamB.Size = new System.Drawing.Size(290, 60);
            this.teamB.TabIndex = 1;
            this.teamB.Text = "Team B name";
            this.teamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamBCombo
            // 
            this.teamBCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamBCombo.FormattingEnabled = true;
            this.teamBCombo.Items.AddRange(new object[] {
            "100 Thieves",
            "Cloud9",
            "Evil Geniuses",
            "FURIA",
            "KRU Esports",
            "Leviatan",
            "LOUD",
            "MIBR",
            "NRG Esports",
            "Sentinels",
            "G2 Esports"});
            this.teamBCombo.Location = new System.Drawing.Point(3, 16);
            this.teamBCombo.Name = "teamBCombo";
            this.teamBCombo.Size = new System.Drawing.Size(290, 21);
            this.teamBCombo.TabIndex = 0;
            this.teamBCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.teamBRankingLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.teamBRosterLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.teamBWinLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 207);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // teamBRankingLabel
            // 
            this.teamBRankingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamBRankingLabel.Location = new System.Drawing.Point(3, 138);
            this.teamBRankingLabel.Name = "teamBRankingLabel";
            this.teamBRankingLabel.Size = new System.Drawing.Size(290, 69);
            this.teamBRankingLabel.TabIndex = 3;
            this.teamBRankingLabel.Text = "label6";
            this.teamBRankingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamBRosterLabel
            // 
            this.teamBRosterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamBRosterLabel.Location = new System.Drawing.Point(3, 69);
            this.teamBRosterLabel.Name = "teamBRosterLabel";
            this.teamBRosterLabel.Size = new System.Drawing.Size(290, 69);
            this.teamBRosterLabel.TabIndex = 2;
            this.teamBRosterLabel.Text = "label5";
            this.teamBRosterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamBWinLabel
            // 
            this.teamBWinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamBWinLabel.Location = new System.Drawing.Point(3, 0);
            this.teamBWinLabel.Name = "teamBWinLabel";
            this.teamBWinLabel.Size = new System.Drawing.Size(290, 69);
            this.teamBWinLabel.TabIndex = 1;
            this.teamBWinLabel.Text = "label4";
            this.teamBWinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.generateButton);
            this.splitContainer2.Size = new System.Drawing.Size(180, 311);
            this.splitContainer2.SplitterDistance = 232;
            this.splitContainer2.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateButton.Location = new System.Drawing.Point(0, 0);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(180, 75);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Prediction";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "VCT Prediction Device";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label teamA;
        private System.Windows.Forms.ComboBox teamACombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label teamB;
        private System.Windows.Forms.ComboBox teamBCombo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label teamARankingLabel;
        private System.Windows.Forms.Label teamARosterLabel;
        private System.Windows.Forms.Label teamAWinLabel;
        private System.Windows.Forms.Label teamBRankingLabel;
        private System.Windows.Forms.Label teamBRosterLabel;
        private System.Windows.Forms.Label teamBWinLabel;
    }
}

