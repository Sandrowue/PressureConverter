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
            string pressureKpa = textBoxkPa.Text;
            double kiloPascals = Convert.ToDouble(pressureKpa);
            double bars = Math.Round(kiloPascals * 0.01d, 2);
            double psi = Math.Round(kiloPascals * 0.145037738d, 2);
            textBoxbar.Text = Convert.ToString(bars);
            textBoxpsi.Text = Convert.ToString(psi);
        }

        private void textBoxkPa_Leave(object sender, EventArgs e)
        {
            // Check if textBoxPa contains numeric vallue
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
