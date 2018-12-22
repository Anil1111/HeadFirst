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
            dinnerParty = new DinnerParty(
                            (int)NumericUpDownNumberOfPeople.Value,
                            CheckBoxHealthyOption.Checked, 
                            CheckBoxFantasyDecorations.Checked);
            birthdayParty = new BirthdayParty(
                            (int)BirthdayNumericUpDown.Value,
                            fancyBirthday.Checked, cakeWriting.Text);

            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }

        //c will display text in currency style, 
        //f3 will display 3 decimal places,
        //0 will display integer value,
        //0% will display percent value,
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost; 
            LabelCostDisplay.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal Cost = birthdayParty.Cost;
            birthdayCost.Text = Cost.ToString("c");
        }

        private void FantasyDecorationsCb_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void HealthyOptionCb_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
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

        private void BirthdayNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)BirthdayNumericUpDown.Value;
            DisplayBirthdayPartyCost();
        }

        private void NumericUpDownNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }
    }
}
