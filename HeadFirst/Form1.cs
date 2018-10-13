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

        public PartyPlannerForm()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(HealthyOptionCb.Checked, FantasyDecorationsCb.Checked);
            //c will display text in currency style, f3 3 decimal places, 0 integer value, 0% percent value, 
            CostDisplay.Text = Cost.ToString("c");
        }

        private void PeopleQuantityNm_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)PeopleQuantityNm.Value;
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
    }
}
