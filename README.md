# CSV Sum Calculator
This is a simple CSV Sum Calculator application implemented in C# using WinForms. The purpose of this application is to allow users to select a CSV (Comma Separated Values) file and calculate the sum of all numbers contained within it. It provides a user interface where users can click a button to select a CSV file, and upon selection, the application calculates the sum of all numbers in the file and displays the last ten digits of the sum in a text box.

##How it Works
1. **Selecting a CSV File**: Users can click the "Select CSV File" button to open a file dialog where they can navigate to and select a CSV file.

2. **Calculating the Sum**: Once a CSV file is selected, the application reads all lines from the file, splits each line by comma, and sums up all the numbers found in the file.

3. **Displaying the Result**: After calculating the sum, the application displays the last ten digits of the sum in the text box provided.

# Features and Code Overview
- Ability to handle large numbers using the BigInteger data type.
- Error handling for invalid numbers encountered in the CSV file.
- GUI for user interaction, making it easy to select files and view results.

## Form1.cs

This file contains the main logic for the Windows Forms application.

### Methods:

1. **Form1()**: Constructor for the `Form1` class, initializes the form components.
   
2. **SelectFileButton_Click(object sender, EventArgs e)**: Event handler for the button click event. Opens a file dialog to select a CSV file, reads the file, calculates the sum of numbers in the CSV, and displays the last ten digits of the sum in the `ResultTextBox`.

3. **CalculateSum(string[] lines)**: Calculates the sum of numbers from the lines of the CSV file. Parses each line by comma and removes surrounding single quotes. Handles invalid numbers by displaying a message box. Returns the sum as a `BigInteger`.

4. **GetLastTenDigits(BigInteger number)**: Returns the last ten digits of a `BigInteger` number as a string. Pads the number with leading zeros if it has less than ten digits.

## Form1.Designer.cs

This file contains the design and layout configuration of the `Form1`.

### Components:

1. **ResultTextBox**: TextBox control to display the result.
   
2. **SelectFileButton**: Button control to trigger the file selection process.

### Methods:

1. **Dispose(bool disposing)**: Disposes of the form's components when the form is disposed.

2. **SuspendLayout**: Prevent unnecessary layout updates while controls are being added.

3. **ResumeLayout(false) and PerformLayout**: Resume layout logic without performing layout operation right away. Then execute the pending layout requests for the form and its children.
           
## Program.cs

This file contains the main entry point for the application.

### Methods:

1. **Main()**: Main entry point of the application. Initializes the application configuration and runs the `Form1`.

## Dependencies
- **System.Numerics**: for handling large integer numbers.
- **System.Windows.Forms**: for building the GUI.
