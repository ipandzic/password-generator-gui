using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 6;
            trackBar1.Maximum = 20;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            bool includeLetters = false;
            bool includeNumerals = false;
            bool includeSymbols = false;

            if (checkBoxCaps.Checked)
            {
                includeLetters = true;
            }

            if (checkBoxNums.Checked)
            {
                includeNumerals = true;
            }

            if (checkBoxSymbol.Checked)
            {
                includeSymbols = true;
            }

            PasswordGenerator(trackBar1.Value, includeLetters, includeNumerals, includeSymbols);

        }

        public void PasswordGenerator(int len, bool includeLetters, bool includeNumerals, bool includeSymbols)
        {
            string ValidChar = " ";

            if (includeLetters == true)
            {
                ValidChar += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (includeNumerals == true)
            {
                ValidChar += "0123456789";
            }

            if (includeSymbols == true)
            {
                ValidChar += "~`!@#$%^&*()_-+={[}]|\\:;\"'<,>.?/";
            }

            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            textBox1.Text = result.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter PasswordWriter = new StreamWriter(Application.StartupPath + "password_text.txt");

            PasswordWriter.WriteLine(textBox1.Text);
            PasswordWriter.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}