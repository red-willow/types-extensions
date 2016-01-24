using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RedWillow.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the specified regular expression finds a match in this string.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        public static bool IsMatch(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        /// <summary>
        /// Indicates whether the specified regular expression finds a match in this string.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        public static bool IsMatch(this string str, string pattern, RegexOptions options)
        {
            return Regex.IsMatch(str, pattern, options);
        }

        /// <summary>
        /// Replaces all strings that match a specified regular expression with a specified replacement string.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <returns>A new string that is identical to the input string, except that the replacement
        ///     string takes the place of each matched string. If pattern is not matched in the
        ///     current instance, the method returns the current instance unchanged.</returns>
        public static string ReReplace(this string str, string pattern, string replacement)
        {
            return Regex.Replace(str, pattern, replacement);
        }

        /// <summary>
        /// Replaces all strings that match a specified regular expression with a specified
        /// replacement string. Specified options modify the matching operation.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>A new string that is identical to the input string, except that the replacement
        ///     string takes the place of each matched string. If pattern is not matched in the
        ///     current instance, the method returns the current instance unchanged.</returns>
        public static string ReReplace(this string str, string pattern, string replacement, RegexOptions options)
        {
            return Regex.Replace(str, pattern, replacement, options);
        }

        /// <summary>
        /// Returns the string in title case. By default mixed words (words with upper case
        /// letters or numbers in them) are ignored.
        /// </summary>
        /// <param name="changeMixedWords">Flag to indicate if mixed words should be capitalised too.</param>
        /// <returns>String made up of title case.</returns>
        public static string TitleCase(this string str, bool changeMixedWords = false)
        {
            var words = str.Split(' ');
            var title = new List<string>();

            foreach(var word in words)
            {
                if (Regex.IsMatch(word, "^[a-zA-Z][a-z\\-.]+$") ||
                    (changeMixedWords && Regex.IsMatch(word, "^[a-zA-Z].+$")))
                {
                    title.Add(word.Substring(0, 1).ToUpper() + word.Substring(1));
                }
                else if (Regex.IsMatch(word, "^[a-zA-Z]$"))
                {
                    title.Add(word.ToUpper());
                }
                else
                {
                    title.Add(word);
                }
            }

            return string.Join(" ", title.ToArray());
        }

        /// <summary>
        ///    Concatenates the members of a constructed <see cref="IEnumerable{T}"/>
        ///    collection of type <see cref="string"/> , using the specified separator between each
        ///    member.
        /// </summary>
        /// <param name="separator">The string to use as a separator. separator is included in the returned string
        ///    only if values has more than one element.</param>
        /// <returns>A string that consists of the members of values delimited by the separator string.
        ///    If values has no members, the method returns System.String.Empty</returns>
        public static string Join(this IEnumerable<string> enumeration, string separator)
        {
#if NET35
            return string.Join(separator, (new List<string>(enumeration)).ToArray());
#else
            return string.Join(separator, enumeration);
#endif
        }
    }
}
