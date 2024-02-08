# *CSV Sum Calculator*
This is a simple CSV Sum Calculator application implemented in C# using WinForms. The purpose of this application is to allow users to select a CSV (Comma Separated Values) file and calculate the sum of all numbers contained within it. It provides a user interface where users can click a button to select a CSV file, and upon selection, the application calculates the sum of all numbers in the file and displays the last ten digits of the sum in a text box.

## How it Works
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

This file contains the design and layout configuration of `Form1`.

### Components:

1. **ResultTextBox**: TextBox control to display the result.
   
2. **SelectFileButton**: Button control to trigger the file selection process.

### Methods:

1. **Dispose(bool disposing)**: Disposes of the form's components when the form is disposed of.

2. **SuspendLayout**: Prevent unnecessary layout updates while controls are being added.

3. **ResumeLayout(false) and PerformLayout**: Resume layout logic without performing layout operation right away. Then execute the pending layout requests for the form and its children.
           
## Program.cs

This file contains the main entry point for the application.

### Methods:

1. **Main()**: Main entry point of the application. Initializes the application configuration and runs the `Form1`.

## Dependencies
- **System.Numerics**: for handling large integer numbers.
- **System.Windows.Forms**: for building the GUI.

# Reflection

1. **Extensibility**:  
   a) This program could be written to read from a database instead of a CSV file by implementing a separate class for data access. 
   b) Efficiently processes large numbers by utilizing the BigInteger data type allowing it to handle a lot of data with large datasets.
   c) Processes comma-separated values (CSV) files without single quotes around numbers and parses to trim surrounding single quotes before parsing numbers as BigIntegers without needing modifications.

2. **Readability**: 
   a) I believe this code is clean and easy to read, but just in case, I have added comments and explanations for clarity.

3. **Efficiency**: 
   a) The code is efficient for its purpose but could be enhanced for performance requirements such as optimizing the algorithm.

4. **How could this be made faster**? 
   a) To improve the program's speed I could use a different file reader such as Streamreader to save memory usage and profile the program using performance profiling tools to identify hotspots and areas for optimization.

5. **Does it work with negatives**?
   a) BigInteger data type was used for sum calculation and is capable of handling negative numbers.

6. **Can this cause problems for a very large number of loads**?
   a) Using File.ReadAllLines() to load the entire CSV file into memory, may encounter issues with very large files due to memory constraints and performance degradation. Streaming reading should be used to optimize efficiency.

7. **Does the memory usage of your application grow over time? Could this be prevented**?
  a) In the current implementation, the application's memory usage may increase over time when processing numerous large CSV files or repeatedly handling sizable datasets without releasing resources, which can lead to memory leaks. Strategies such as disposal of resources and garbage collection optimization should be used to prevent this.

8. **Are we processing unnecessary information**?
  a) The program currently reads and parses the entire CSV file, processing every line even if some lines do not contain relevant information. This issue can be resolved by modifying the parsing logic to skip irrelevant information.

9. **What kinds of input would destroy your program? Should it not crash? Does it crash gracefully**?
  a)This program handles invalid CSV formats and invalid inputs by implementing error handling and validation checks to prevent parsing errors. 
  b)To solve performance issues or crashes caused by large input files, use a StreamReader to process data.
  c)Implementing data validation checks to detect and handle invalid data values should prevent unexpected crashes.
