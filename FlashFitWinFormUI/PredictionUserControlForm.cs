using FlashFitClassLibrary.Resources.Prediction;
using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Services;

namespace FlashFitWinFormUI
{
    public partial class PredictionUserControlForm : UserControl
    {

        PredictionService _predictionService;
        UserService _userService;
        public PredictionUserControlForm()
        {
            InitializeComponent();
            _predictionService = new PredictionService();
            _userService = new UserService();
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            UserResource userData = await _userService.getUserByEmail(Program.getLoggedInUser().Email);

            string email = userData.Email;
            decimal currentWeight = userData.WeightInKiloGrams;
            DateTime toDate = predictedToDateCalender.SelectionStart;

            if (((int)(toDate - DateTime.UtcNow).TotalDays) <= 0)
            {
                MessageBox.Show("Pls select a Future Date");
            }


            PredictionResponse? prediction = await _predictionService.predictHealthStatus(email, toDate);

            if(prediction == null)
            {
                MessageBox.Show("No prediction for you keep working");
                return;
            }
            else
            {
                predictedWeigtText.Text = $"{prediction.WeightPredicted:F2}";
                predictedBMIText.Text = $"{prediction.BmiPredicted:F2}";
                placeholderForHealthStatusLabel.Visible = true;
                placeholderForHealthStatusLabel.Text = prediction.HealthStatusPredicted.ToString();
                plcSuggestionLabel.Visible = true;
                plcSuggestionLabel.Text = prediction.Suggestion;
            }



        }
    }
}
