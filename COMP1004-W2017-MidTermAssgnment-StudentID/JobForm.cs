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
    public partial class JobForm : Form
    {
        private AbilityForm A;
        private RaceForm R;
        private JobForm J;
        public JobForm(AbilityForm Ability)
        {
            InitializeComponent();
            A = Ability;
           
        }
     

        private void JobForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoldierButton_CheckedChanged(object sender, EventArgs e)
        {        
          HPText.Text = (30 + int.Parse(A.ENDTextBox.Text)).ToString();
        }

        private void RogueButton_CheckedChanged(object sender, EventArgs e)
        {
            HPText.Text = (28 + int.Parse(A.DEXTextBox.Text)).ToString();
        }

        private void MagickerButton_CheckedChanged(object sender, EventArgs e)
        {
            HPText.Text = (15 + int.Parse(A.INTTextBox.Text)).ToString();
        }

        private void CultistButton_CheckedChanged(object sender, EventArgs e)
        {
            HPText.Text = (24 + int.Parse(A.CHATextBox.Text)).ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm Final = new FinalForm(A,R,J);



            Final.Show();
            this.Hide();
        }
    }

}
