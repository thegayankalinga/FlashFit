using System.Text.RegularExpressions;

namespace FlashFitWinFormUI.Services;

public class ValidatorService
{
    public static bool IsValidEmail(string email)
    {
        // Regular expression pattern for validating email addresses
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Use the Regex.IsMatch method to check if the email matches the pattern
        return Regex.IsMatch(email, pattern);
    }

    public static bool ValidateTextField(TextBox textBox)
    {
        // Add your validation logic here
        string userInput = textBox.Text;

        // Example: Check if the field is not empty
        if (string.IsNullOrWhiteSpace(userInput))
        {
            return false;
        }

        // Add more validation checks if needed

        // Validation passed
        return true;
    }

}
