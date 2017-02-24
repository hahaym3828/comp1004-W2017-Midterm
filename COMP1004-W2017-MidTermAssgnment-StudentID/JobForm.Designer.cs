namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MagickerButton = new System.Windows.Forms.RadioButton();
            this.CultistButton = new System.Windows.Forms.RadioButton();
            this.RogueButton = new System.Windows.Forms.RadioButton();
            this.SoldierButton = new System.Windows.Forms.RadioButton();
            this.HPLabel = new System.Windows.Forms.Label();
            this.HPText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(434, 308);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MagickerButton);
            this.groupBox1.Controls.Add(this.CultistButton);
            this.groupBox1.Controls.Add(this.RogueButton);
            this.groupBox1.Controls.Add(this.SoldierButton);
            this.groupBox1.Location = new System.Drawing.Point(74, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 255);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your job";
            // 
            // MagickerButton
            // 
            this.MagickerButton.AutoSize = true;
            this.MagickerButton.Location = new System.Drawing.Point(19, 97);
            this.MagickerButton.Name = "MagickerButton";
            this.MagickerButton.Size = new System.Drawing.Size(71, 16);
            this.MagickerButton.TabIndex = 3;
            this.MagickerButton.TabStop = true;
            this.MagickerButton.Text = "Magicker";
            this.MagickerButton.UseVisualStyleBackColor = true;
            this.MagickerButton.CheckedChanged += new System.EventHandler(this.MagickerButton_CheckedChanged);
            // 
            // CultistButton
            // 
            this.CultistButton.AutoSize = true;
            this.CultistButton.Location = new System.Drawing.Point(19, 128);
            this.CultistButton.Name = "CultistButton";
            this.CultistButton.Size = new System.Drawing.Size(65, 16);
            this.CultistButton.TabIndex = 2;
            this.CultistButton.TabStop = true;
            this.CultistButton.Text = "Cultist";
            this.CultistButton.UseVisualStyleBackColor = true;
            this.CultistButton.CheckedChanged += new System.EventHandler(this.CultistButton_CheckedChanged);
            // 
            // RogueButton
            // 
            this.RogueButton.AutoSize = true;
            this.RogueButton.Location = new System.Drawing.Point(19, 65);
            this.RogueButton.Name = "RogueButton";
            this.RogueButton.Size = new System.Drawing.Size(53, 16);
            this.RogueButton.TabIndex = 1;
            this.RogueButton.TabStop = true;
            this.RogueButton.Text = "Rogue";
            this.RogueButton.UseVisualStyleBackColor = true;
            this.RogueButton.CheckedChanged += new System.EventHandler(this.RogueButton_CheckedChanged);
            // 
            // SoldierButton
            // 
            this.SoldierButton.AutoSize = true;
            this.SoldierButton.Location = new System.Drawing.Point(19, 34);
            this.SoldierButton.Name = "SoldierButton";
            this.SoldierButton.Size = new System.Drawing.Size(65, 16);
            this.SoldierButton.TabIndex = 0;
            this.SoldierButton.TabStop = true;
            this.SoldierButton.Text = "Soldier";
            this.SoldierButton.UseVisualStyleBackColor = true;
            this.SoldierButton.CheckedChanged += new System.EventHandler(this.SoldierButton_CheckedChanged);
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Location = new System.Drawing.Point(325, 45);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(119, 12);
            this.HPLabel.TabIndex = 5;
            this.HPLabel.Text = "Health Points (HP):";
            // 
            // HPText
            // 
            this.HPText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HPText.Location = new System.Drawing.Point(363, 79);
            this.HPText.Name = "HPText";
            this.HPText.ReadOnly = true;
            this.HPText.Size = new System.Drawing.Size(144, 21);
            this.HPText.TabIndex = 6;
            this.HPText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(544, 349);
            this.Controls.Add(this.HPText);
            this.Controls.Add(this.HPLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.Load += new System.EventHandler(this.JobForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MagickerButton;
        private System.Windows.Forms.RadioButton CultistButton;
        private System.Windows.Forms.RadioButton RogueButton;
        private System.Windows.Forms.RadioButton SoldierButton;
        private System.Windows.Forms.Label HPLabel;
        internal System.Windows.Forms.TextBox HPText;
    }
}