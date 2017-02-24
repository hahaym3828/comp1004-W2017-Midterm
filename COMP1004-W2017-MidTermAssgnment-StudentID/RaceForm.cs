using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class RaceForm : Form
    {
        private AbilityForm A;
       

        public RaceForm(AbilityForm Ability)
        {
            InitializeComponent();
            A = Ability;
           
        }

        public Form PreviousForm;

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void HumanButton_CheckedChanged(object sender, EventArgs e)
        {
            RaceLabel.Text = "Human";
            RacialBonusTextBox.Text = "Increase all of the Character’s Abilities by 5";
            CharacterPictureBox.Image = Properties.Resources.M_Human1;
        }            

        private void RacialBonusTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RaceForm_Load(object sender, EventArgs e)
        {
           
        }

      

        private void CharacterPictureBox_Click(object sender, EventArgs e)
        {

        }

        public void DwarfButton_CheckedChanged(object sender, EventArgs e)
        {
            RaceLabel.Text = "Dwarf";
            RacialBonusTextBox.Text = "increase	the Character’s STR and PER by 20" +
                   "points each  and decrease the Character's CHA by 10 points.";
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
        }

        public void ElfButton_CheckedChanged(object sender, EventArgs e)
        {
            RaceLabel.Text = "Elf";
            RacialBonusTextBox.Text = "increase the Character’s DEX and CHA by 15";
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
        }

        public void HalflingButton_CheckedChanged(object sender, EventArgs e)
        {
            RaceLabel.Text = "Halfling";
            RacialBonusTextBox.Text = "increase the Character’s DEX and INT by 20 and decrease the Character’s STR by 10 points.";
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {   

            if (HumanButton.Checked)
            {
               
                A.ENDTextBox.Text = (int.Parse(A.ENDTextBox.Text) + 5).ToString();
                A.STRTextBox.Text = (int.Parse(A.STRTextBox.Text) + 5).ToString();
                A.DEXTextBox.Text = (int.Parse(A.DEXTextBox.Text) + 5).ToString();
                A.INTTextBox.Text = (int.Parse(A.INTTextBox.Text) + 5).ToString();
                A.PERTextBox.Text = (int.Parse(A.PERTextBox.Text) + 5).ToString();
                A.CHATextBox.Text = (int.Parse(A.CHATextBox.Text) + 5).ToString();
            }
            if (DwarfButton.Checked)
            {
               
                A.STRTextBox.Text = (int.Parse(A.STRTextBox.Text) + 20).ToString();
                A.PERTextBox.Text = (int.Parse(A.PERTextBox.Text) + 20).ToString();
                A.CHATextBox.Text = (int.Parse(A.STRTextBox.Text) - 10).ToString();
            }
            if (ElfButton.Checked)
            {
               
                A.DEXTextBox.Text = (int.Parse(A.DEXTextBox.Text) + 15).ToString();
                A.CHATextBox.Text = (int.Parse(A.CHATextBox.Text) + 15).ToString();
            }
            if (HalflingButton.Checked)
            {
               
                A.DEXTextBox.Text = (int.Parse(A.DEXTextBox.Text) + 20).ToString();
                A.INTTextBox.Text = (int.Parse(A.INTTextBox.Text) + 20).ToString();
                A.STRTextBox.Text = (int.Parse(A.STRTextBox.Text) - 10).ToString();
            }

            JobForm Job = new JobForm(A);
         
            Job.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
