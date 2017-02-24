using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Ming Ying
 * StudentID:200258201
 * */
namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class FinalForm : Form
    {
        private AbilityForm A;
        private RaceForm R;
        private JobForm J;
        public FinalForm(AbilityForm Ability, RaceForm Race, JobForm Job)
        {
            InitializeComponent();
            A = Ability;
            R = Race;
            J = Job;
           
            STRTextBox.Text = A.STRTextBox.Text;
            DEXTextBox.Text = A.DEXTextBox.Text;
            ENDTextBox.Text = A.ENDTextBox.Text;
            INTTextBox.Text = A.INTTextBox.Text;
            PERTextBox.Text = A.PERTextBox.Text;
            CHATextBox.Text = A.CHATextBox.Text;

          //  RaceTextBox.Text = R.RaceLabel.Text;

        //    HPText.Text = J.HPText.Text;
         CharacterPictureBox.Image = R.CharacterPictureBox.Image;

            


        }

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();

        }

        private void 打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("print review");
        }

        private void FontMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void CharacterPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void AbilityBox_Enter(object sender, EventArgs e)
        {

        }

        private void CIBox_Enter(object sender, EventArgs e)
        {

        }
        private void STRTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DEXTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ENDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

            private void INTTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PERTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CHATextBox_TextChanged(object sender, EventArgs e)
        {

        }
       
    

        private void FinalForm_Load(object sender, EventArgs e)
        {

        }

        public void RaceTextBox_TextChanged(object sender, EventArgs e)
        {


          

        }

        private void JobTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HPText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
