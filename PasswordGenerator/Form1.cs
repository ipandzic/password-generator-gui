using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            bool includeLetters = false;
            bool includeNumerals = false;
            bool includeSymbols = false;
            int characterNumber = 8;

            if (checkBox1.Checked)
            {
                characterNumber = 10;
            }

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

            PasswordGenerator(characterNumber, includeLetters, includeNumerals, includeSymbols);

        }

        public void PasswordGenerator(int len, bool includeLetters, bool includeNumerals, bool includeSymbols)
        {
            string ValidChar = " ";

            if (includeLetters == true)
            {
                ValidChar += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
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
    }
}