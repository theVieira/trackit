using System.Text.RegularExpressions;

namespace Trackit.Util;

public static class SpellCheck
{
    public static string CapitalizeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");

        return Regex.Replace(name.ToLower(), @"(^\w)|(\s\w)", match => match.Value.ToUpper());
    }

    public static string CleanSpecialCharacters(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "";
        
        return Regex.Replace(input, @"[^\d]", string.Empty);
    }

    public static string CapitalizeText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new ArgumentException("Name cannot be empty.");

        return text[..1].ToUpper() + text[1..];
    }
}