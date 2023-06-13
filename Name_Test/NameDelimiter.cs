using System;
namespace Name_Test
{
    static class NameDelimiter
    {


        public static string FormatName(string fullName)
        {
            string[] nameParts = fullName.Split(' ');

            for (int i = 0; i < nameParts.Length; i++)
            {
                string namePart = nameParts[i];

                if (i == 0 || i == nameParts.Length - 1)
                {
                    namePart = Capitalize(namePart);
                }
                else
                {
                    // Перевіряємо, чи є це французька або німецька приставка
                    if (IsFrenchPrefix(namePart))
                    {
                        namePart = Capitalize(namePart);
                    }
                    else if (IsGermanPrefix(namePart))
                    {
                        namePart = Capitalize(namePart);
                    }
                    else
                    {
                        namePart = Lowercase(namePart);
                    }
                }

                nameParts[i] = namePart;
            }

            return string.Join(" ", nameParts);
        }

        static bool IsFrenchPrefix(string input)
        {
            string[] frenchPrefixes = { "de", "du", "le", "la","saint" };
            return Array.Exists(frenchPrefixes, prefix => prefix.Equals(input, StringComparison.OrdinalIgnoreCase));
        }

        static bool IsGermanPrefix(string input)
        {
            string[] germanPrefixes = { "von", "der","berg" };
            return Array.Exists(germanPrefixes, prefix => prefix.Equals(input, StringComparison.OrdinalIgnoreCase));
        }

        static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        static string Lowercase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToLower(input[0]) + input.Substring(1);
        }

    }
}

