using System.Numerics;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the button click to select a CSV file
        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            // Opens a file dialog to select a CSV file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                // If a file is selected and OK is clicked in the dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read all lines from the selected CSV file
                        string filePath = openFileDialog.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        // Calculate the sum of all numbers in the CSV file
                        BigInteger sum = CalculateSum(lines);
                        // Get the last ten digits of the sum and display it in the text box
                        string lastTenDigits = GetLastTenDigits(sum);
                        ResultTextBox.Text = lastTenDigits;
                    }
                    catch (Exception ex)
                    {
                        // Display an error message if there's an exception while reading the file
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        // Method to calculate the sum of all numbers in the CSV file
        private BigInteger CalculateSum(string[] lines)
        {
            BigInteger sum = 0;
            foreach (string line in lines)
            {
                // Split each line by comma and sum the numbers
                string[] numbers = line.Split(',');
                foreach (string numberString in numbers)
                {
                    // Remove surrounding quotes if they exist
                    string trimmedNumberString = numberString.Trim('\'');

                    // Parse the number as a BigInteger and add it to the sum
                    if (BigInteger.TryParse(trimmedNumberString, out BigInteger number))
                    {
                        sum += number;
                    }
                    else
                    {
                        // Display a message box for invalid numbers
                        MessageBox.Show($"Invalid number: {trimmedNumberString}. Skipping...");
                    }
                }
            }
            return sum;
        }

        // Method to get the last ten digits of a BigInteger number
        private string GetLastTenDigits(BigInteger number)
        {
            // Take the last 10 digits of the number
            string numberString = number.ToString();
            int length = numberString.Length;
            if (length <= 10)
                return numberString.PadLeft(10, '0'); // If the number is less than 10 digits, pad it with leading zeros
            else
                return numberString.Substring(length - 10);
        }
    }
}

