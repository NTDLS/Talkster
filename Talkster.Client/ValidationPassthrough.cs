using NTDLS.Helpers;
using NTDLS.WinFormsHelpers;
using ReaLTaiizor.Controls;
using System.Reflection;

namespace Talkster.Client
{
    public static class ValidationPassthrough
    {
        public static TextBox TextBox(this PoisonTextBox poisonTextBox)
            => (TextBox?)typeof(PoisonTextBox)?.GetField("baseTextBox", BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(poisonTextBox)
                ?? throw new InvalidOperationException("Failed to access inner TextBox of PoisonTextBox.");

        public static T ValueAs<T>(this PoisonTextBox textBox)
            => Converters.ConvertTo<T>(textBox.Text);

        /// <summary>
        /// Gets an integer value from a windows textbox. Ensures that the value falls within the given ranges.
        /// </summary>
        /// <param name="textBox">Text box to get the value from.</param>
        /// <param name="minValue">The minimum value for the parsed control text validation.</param>
        /// <param name="maxValue">The maximum value for the parsed control text validation.</param>
        /// <param name="message">Message for the exception which is thrown when validation fails. Use [min] and [max] for place holders of the given minValue and maxValue.</param>
        /// <returns>Returns the parsed integer.</returns>
        public static int GetAndValidateNumeric(this PoisonTextBox textBox, int minValue, int maxValue, string message)
            => textBox.TextBox().GetAndValidateNumeric(minValue, maxValue, message);

        /// <summary>
        /// Gets a double floating value from a windows textbox. Ensures that the value falls within the given ranges.
        /// </summary>
        /// <param name="textBox">Text box to get the value from.</param>
        /// <param name="minValue">The minimum value for the parsed control text validation.</param>
        /// <param name="maxValue">The maximum value for the parsed control text validation.</param>
        /// <param name="message">Message for the exception which is thrown when validation fails. Use [min] and [max] for place holders of the given minValue and maxValue.</param>
        /// <returns>Returns the parsed double.</returns>
        public static double GetAndValidateNumeric(this PoisonTextBox textBox, double minValue, double maxValue, string message)
            => textBox.TextBox().GetAndValidateNumeric(minValue, maxValue, message);

        /// <summary>
        /// Gets a float floating value from a windows textbox. Ensures that the value falls within the given ranges.
        /// </summary>
        /// <param name="textBox">Text box to get the value from.</param>
        /// <param name="minValue">The minimum value for the parsed control text validation.</param>
        /// <param name="maxValue">The maximum value for the parsed control text validation.</param>
        /// <param name="message">Message for the exception which is thrown when validation fails. Use [min] and [max] for place holders of the given minValue and maxValue.</param>
        /// <returns>Returns the parsed float.</returns>
        public static float GetAndValidateNumeric(this PoisonTextBox textBox, float minValue, float maxValue, string message)
            => textBox.TextBox().GetAndValidateNumeric(minValue, maxValue, message);

        /// <summary>
        /// Gets a string value from a windows textbox. Ensures that the length falls within the given ranges.
        /// </summary>
        /// <param name="textBox">Text box to get the value from.</param>
        /// <param name="minLength">The minimum length of the control text.</param>
        /// <param name="maxLength">The maximum length of the control text.</param>
        /// <param name="message">Message for the exception which is thrown when validation fails. Use [min] and [max] for place holders of the given minLength and maxLength.</param>
        /// <returns>Returns the control text.</returns>
        public static string GetAndValidateText(this PoisonTextBox textBox, int minLength, int maxLength, string message)
            => textBox.TextBox().GetAndValidateText(minLength, maxLength, message);

        /// <summary>
        /// Gets a string value from a windows textbox. Ensures that it contains a value.
        /// </summary>
        /// <param name="textBox">Text box to get the value from.</param>
        /// <param name="message">Message for the exception which is thrown when validation fails.</param>
        /// <returns>Returns the control text.</returns>
        public static string GetAndValidateText(this PoisonTextBox textBox, string message)
            => textBox.TextBox().GetAndValidateText(message);

    }
}
