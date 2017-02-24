namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class RaceForm
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
            this.RacialBonusLabel = new System.Windows.Forms.Label();
            this.RacialBonusTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DwarfButton = new System.Windows.Forms.RadioButton();
            this.ElfButton = new System.Windows.Forms.RadioButton();
            this.HalflingButton = new System.Windows.Forms.RadioButton();
            this.HumanButton = new System.Windows.Forms.RadioButton();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RacialBonusLabel
            // 
            this.RacialBonusLabel.AutoSize = true;
            this.RacialBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusLabel.Location = new System.Drawing.Point(238, 333);
            this.RacialBonusLabel.Name = "RacialBonusLabel";
            this.RacialBonusLabel.Size = new System.Drawing.Size(115, 20);
            this.RacialBonusLabel.TabIndex = 6;
            this.RacialBonusLabel.Text = "Racial Bonus";
            // 
            // RacialBonusTextBox
            // 
            this.RacialBonusTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RacialBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RacialBonusTextBox.Location = new System.Drawing.Point(61, 356);
            this.RacialBonusTextBox.Multiline = true;
            this.RacialBonusTextBox.Name = "RacialBonusTextBox";
            this.RacialBonusTextBox.ReadOnly = true;
            this.RacialBonusTextBox.Size = new System.Drawing.Size(523, 83);
            this.RacialBonusTextBox.TabIndex = 7;
            this.RacialBonusTextBox.TextChanged += new System.EventHandler(this.RacialBonusTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DwarfButton);
            this.groupBox1.Controls.Add(this.ElfButton);
            this.groupBox1.Controls.Add(this.HalflingButton);
            this.groupBox1.Controls.Add(this.HumanButton);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(57, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Your Race";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DwarfButton
            // 
            this.DwarfButton.AutoSize = true;
            this.DwarfButton.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DwarfButton.Location = new System.Drawing.Point(21, 56);
            this.DwarfButton.Name = "DwarfButton";
            this.DwarfButton.Size = new System.Drawing.Size(58, 21);
            this.DwarfButton.TabIndex = 4;
            this.DwarfButton.TabStop = true;
            this.DwarfButton.Text = "Dwarf";
            this.DwarfButton.UseVisualStyleBackColor = true;
            this.DwarfButton.CheckedChanged += new System.EventHandler(this.DwarfButton_CheckedChanged);
            // 
            // ElfButton
            // 
            this.ElfButton.AutoSize = true;
            this.ElfButton.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ElfButton.Location = new System.Drawing.Point(21, 83);
            this.ElfButton.Name = "ElfButton";
            this.ElfButton.Size = new System.Drawing.Size(39, 21);
            this.ElfButton.TabIndex = 3;
            this.ElfButton.TabStop = true;
            this.ElfButton.Text = "Elf";
            this.ElfButton.UseVisualStyleBackColor = true;
            this.ElfButton.CheckedChanged += new System.EventHandler(this.ElfButton_CheckedChanged);
            // 
            // HalflingButton
            // 
            this.HalflingButton.AutoSize = true;
            this.HalflingButton.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HalflingButton.Location = new System.Drawing.Point(21, 110);
            this.HalflingButton.Name = "HalflingButton";
            this.HalflingButton.Size = new System.Drawing.Size(68, 21);
            this.HalflingButton.TabIndex = 2;
            this.HalflingButton.TabStop = true;
            this.HalflingButton.Text = "Halfling";
            this.HalflingButton.UseVisualStyleBackColor = true;
            this.HalflingButton.CheckedChanged += new System.EventHandler(this.HalflingButton_CheckedChanged);
            // 
            // HumanButton
            // 
            this.HumanButton.AutoSize = true;
            this.HumanButton.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HumanButton.Location = new System.Drawing.Point(21, 29);
            this.HumanButton.Name = "HumanButton";
            this.HumanButton.Size = new System.Drawing.Size(66, 21);
            this.HumanButton.TabIndex = 0;
            this.HumanButton.TabStop = true;
            this.HumanButton.Text = "Human";
            this.HumanButton.UseVisualStyleBackColor = true;
            this.HumanButton.CheckedChanged += new System.EventHandler(this.HumanButton_CheckedChanged);
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_StudentID.Properties.Resources.M_Human1;
            this.CharacterPictureBox.Location = new System.Drawing.Point(319, 45);
            this.CharacterPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CharacterPictureBox.TabIndex = 5;
            this.CharacterPictureBox.TabStop = false;
            this.CharacterPictureBox.Click += new System.EventHandler(this.CharacterPictureBox_Click);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(61, 45);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(47, 12);
            this.RaceLabel.TabIndex = 9;
            this.RaceLabel.Text = "mamaipi";
            this.RaceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RacialBonusTextBox);
            this.Controls.Add(this.RacialBonusLabel);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Character Race";
            this.Load += new System.EventHandler(this.RaceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label RacialBonusLabel;
        private System.Windows.Forms.TextBox RacialBonusTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HumanButton;
        private System.Windows.Forms.RadioButton DwarfButton;
        private System.Windows.Forms.RadioButton ElfButton;
        private System.Windows.Forms.RadioButton HalflingButton;
        internal System.Windows.Forms.PictureBox CharacterPictureBox;
        internal System.Windows.Forms.Label RaceLabel;
    }
}