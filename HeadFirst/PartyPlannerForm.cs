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
            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }
        //c will display text in currency style, 
        //f3 will display 3 decimal places,
        //0 will display integer value,
        //0% will display percent value,
        private void DisplayDinnerPartyCost()
        {
            dinnerParty = new DinnerParty(
                            (int)NumericUpDownNumberOfPeople.Value,
                            CheckBoxHealthyOption.Checked,
                            CheckBoxFancyDecorations.Checked);
            decimal Cost = dinnerParty.Cost; 
            LabelCostDisplay.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            birthdayParty = new BirthdayParty(
                            (int)NumericUpDownNumberOfPeopleBD.Value,
                            CheckBoxFancyDecorationsBD.Checked,
                            TextBoxCakeWriting.Text);
            LabelWritingTooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal Cost = birthdayParty.Cost;
            LabelCostDisplayBD.Text = Cost.ToString("c");
        }
        //Dinner Party Methods
        private void NumericUpDownNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void CheckBoxFancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void CheckBoxHealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }
        //Birthday Party Methods

        private void NumericUpDownNumberOfPeopleBD_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)NumericUpDownNumberOfPeopleBD.Value;
            DisplayBirthdayPartyCost();
        }

        private void CheckBoxFancyDecorationsBD_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = CheckBoxFancyDecorationsBD.Checked;
            DisplayBirthdayPartyCost();
        }

        private void TextBoxCakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = TextBoxCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
