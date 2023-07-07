using FlashFitClassLibrary.Enumz;
using FlashFitClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFitWinFormUI
{
    public partial class PredictionUserControlForm : UserControl
    {

        PredictionService predictionService = new PredictionService();
        UserService userService = new UserService();
        public PredictionUserControlForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string email = Program.getLoggedInUser().Email;
            decimal currentWeight = userService.getUserByEmail(email).WeightInKiloGrams;
            string toDate = predictedToDateCalender.SelectionStart.ToString();
            decimal weight = predictionService.weightPredication(email, toDate, currentWeight);
            decimal bmi = userService.calculateAndUpdateBMI(email, weight);

            DateTime current = DateTime.Now;
            DateTime futureDate = DateTime.Parse(toDate);

            ;
            if (((int)(futureDate - current).TotalDays) <= 0)
            {
                MessageBox.Show("Pls select a Future Date");
                weight = currentWeight;
            }
            {

            }
            predictedWeigtText.Text = $"{weight:F2}";
            predictedBMIText.Text = $"{userService.calculateAndUpdateBMI(email, weight):F2}";
            placeholderForHealthStatusLabel.Visible = true;
            placeholderForHealthStatusLabel.Text = predictionService.getCurrentHealthStatus(email, bmi).ToString();

        }
    }
}
