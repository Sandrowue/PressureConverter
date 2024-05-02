namespace PressureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLaske_Click(object sender, EventArgs e)
        {
            decimal kPaTB;
            decimal psiTB;
            decimal barTB;

            bool kPaValue = decimal.TryParse(textBoxkPa.Text, out kPaTB);
            bool psiValue = decimal.TryParse(textBoxpsi.Text, out psiTB);
            bool barValue = decimal.TryParse(textBoxbar.Text, out barTB);


            if (kPaValue == true)
            { 
                string pressureKpa = textBoxkPa.Text;
                double kiloPascals = Convert.ToDouble(pressureKpa);
                double bars = Math.Round(kiloPascals * 0.01d, 2);
                double psi = Math.Round(kiloPascals * 0.145037738d, 2);
                textBoxbar.Text = Convert.ToString(bars);
                textBoxpsi.Text = Convert.ToString(psi);
            }

            else if (psiValue == true) 
            {
                string pressurepsi = textBoxpsi.Text;
                double psi = Convert.ToDouble(pressurepsi);
                double kiloPascals = Math.Round(psi / 0.145037738, 2);
                double bars = Math.Round(psi / 14.5037738, 2);
                textBoxbar.Text = Convert.ToString(bars);
                textBoxkPa.Text = Convert.ToString(kiloPascals);
            }

            else if (barValue == true)
            {
                string pressurebar = textBoxbar.Text;
                double bars = Convert.ToDouble(pressurebar);
                double psi = Math.Round(bars * 14.5037738, 2);
                double kiloPascals = Math.Round(bars * 100, 2);
                textBoxkPa.Text = Convert.ToString(kiloPascals);
                textBoxpsi.Text = Convert.ToString(psi);
            }
        }

        private void textBoxkPa_Leave(object sender, EventArgs e)
        {
            // Check if textBoxPa contains numeric vallue

            // Define a variable for parsed value
            decimal kPa;

            bool numericValue = decimal.TryParse(textBoxkPa.Text, out kPa);
            if (numericValue != true)
            {
                string message = "Anna pelkki‰ numeroita.";
                string header = "V‰‰r‰ painetieto!";
                DialogResult kPaErrorMsg;
                kPaErrorMsg = MessageBox.Show(message, header, MessageBoxButtons.RetryCancel);

                buttonLaske.Enabled = false;
            }

            else
            {
                textBoxpsi.Enabled = false;
                textBoxbar.Enabled = false;
                // Change buttton state to enabled
                buttonLaske.Enabled = true;
                buttonLaske.Focus();
            }
        }

        private void textBoxpsi_Leave(object sender, EventArgs e)
        {
            decimal psi;

            bool numericValue = decimal.TryParse(textBoxpsi.Text, out psi);
            if (numericValue != true)
            {
                string message = "Anna pelkki‰ numeroita.";
                string header = "V‰‰r‰ painetieto!";
                DialogResult psiErrorMsg;
                psiErrorMsg = MessageBox.Show(message, header, MessageBoxButtons.RetryCancel);

                buttonLaske.Enabled = false;
            }

            else
            {
                textBoxkPa.Enabled = false;
                textBoxbar.Enabled = false;
                // Change buttton state to enabled
                buttonLaske.Enabled = true;
                buttonLaske.Focus();
            }

        }
        private void textBoxbar_Leave(object sender, EventArgs e)
        {
            decimal bar;

            bool numericValue = decimal.TryParse(textBoxbar.Text, out bar);
            if (numericValue != true)
            {
                string message = "Anna pelkki‰ numeroita.";
                string header = "V‰‰r‰ painetieto!";
                DialogResult barErrorMsg;
                barErrorMsg = MessageBox.Show(message, header, MessageBoxButtons.RetryCancel);

                buttonLaske.Enabled = false;
            }

            else
            {   
                textBoxkPa.Enabled = false;
                textBoxpsi.Enabled = false;
                // Change buttton state to enabled
                buttonLaske.Enabled = true;
                buttonLaske.Focus();
            }
        }

        private void buttonTyhjenna_Click(object sender, EventArgs e)
        {
            textBoxkPa.Text = string.Empty;
            textBoxbar.Text = string.Empty;
            textBoxpsi.Text = string.Empty;
            buttonLaske.Enabled = false;
        }

    }
}
