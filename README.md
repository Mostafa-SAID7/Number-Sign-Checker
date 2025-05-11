# Number Sign Checker in C#

## Description
This simple **C# console application** prompts the user to input a number and determines whether the number is **positive**, **negative**, or **zero**. The application handles invalid input gracefully by using **`Convert.ToInt32()`** for converting the input and a **`try-catch` block** to prevent the program from crashing in case of invalid input (non-integer values).

## Features
- Prompts the user for an integer input.
- Checks whether the input is positive, negative, or zero.
- Handles invalid input (such as strings or non-numeric characters) by displaying an error message.
- Built-in error handling with **`try-catch`**.

## How to Use
1. **Run the application**.
2. When prompted, **enter any integer** or a non-integer value.
3. The program will display whether the number is **positive**, **negative**, or **zero**. If an invalid input is given, it will notify the user.

### Example Output

For a valid integer input:

```bash
Enter a number: -10
The number is negative.

For invalid input (non-integer):
Enter a number: hello
Invalid input. Please enter a valid integer.
```
###Tech Stack
C# (Console Application)
.NET Core / .NET Framework (depending on your environment)

###Contributing
Feel free to fork this project, make changes, and submit pull requests if you'd like to contribute.

###License
This project is licensed under the MIT License.

### Explanation:
- The title `# Number Sign Checker in C#` is the repository name or project title.
- The sections are clearly separated using headings like `## Description`, `## Features`, etc.
- The **code blocks** for example outputs are surrounded by triple backticks to preserve formatting, just like how GitHub displays it.

This format will look great on GitHub and is structured to be clear and easy to read for anyone visiting your repository.
