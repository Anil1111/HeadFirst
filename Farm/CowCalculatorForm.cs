using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    public partial class CowCalculatorForm : Form
    {
        Farmer farmer;

        public CowCalculatorForm()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags to feed {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void CowQuantityNm_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)CowQuantityNm.Value;
        }

        private void CowCalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
