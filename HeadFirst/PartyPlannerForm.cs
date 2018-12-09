using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirst
{
    public partial class PartyPlannerForm : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public PartyPlannerForm()
        {
            InitializeComponent();
            // in book in dinner party constructor there was (int)PeopleQuantityNm.Value,
            //HealthyOptionCb.Checked, FantasyDecorationsCb.Checked but we've 
            // handled things differently
            dinnerParty = new DinnerParty();
            birthdayParty = new BirthdayParty((int)numberBirthday.Value,
                fancyBirthday.Checked, cakeWriting.Text);
            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(HealthyOptionCb.Checked, FantasyDecorationsCb.Checked, (int)PeopleQuantityNm.Value);
            //c will display text in currency style, f3 3 decimal places, 0 integer value, 0% percent value, 
            CostDisplay.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal Cost = birthdayParty.Cost;
            birthdayCost.Text = Cost.ToString("c");
        }

        private void PeopleQuantityNm_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void FantasyDecorationsCb_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void HealthyOptionCb_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void PeopleQuantityNm2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
