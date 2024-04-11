namespace Mod2LabA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateBMI(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(Weight.Text);
            double height = Convert.ToDouble(Height.Text);
            double bmi = 703 * (weight / (height * height));

            string bmiStatus = " - ";
            if (bmi <= 18.4)
            {
                bmiStatus += "Underweight";
            } else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiStatus += "Normal";
            } else if (bmi >= 25.0 && bmi <= 39.9)
            {
                bmiStatus += "Overweight";
            } else if (bmi >= 40)
            {
                bmiStatus += "Obese";
            }

            BmiOutput.Text = $"Your BMI is: {bmi:N2}{bmiStatus}";
        }
    }

}
