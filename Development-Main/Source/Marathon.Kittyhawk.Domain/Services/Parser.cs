using System;

namespace Marathon.Kittyhawk.Domain.Services
{
    /// <summary>
    /// Static service class containing generic parsing methods.
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// Parses a string into a nullable type that is provided in the method call.
        /// </summary>
        /// <typeparam name="T">Nullable type</typeparam>
        /// <param name="s">String to parse</param>
        /// <param name="parse">parsing function</param>
        /// <returns>Parsed result</returns>
        public static T? ParseNullable<T>(string s, Func<string, T> parse) where T : struct
        {
            if (string.IsNullOrEmpty(s))
            {
                return null;
            }
            else
            {
                return parse(s);
            }
        }

        /// <summary>
        /// Trims and parses a string into a nullable type that is provided in the method call.
        /// </summary>
        /// <typeparam name="T">Nullable type</typeparam>
        /// <param name="s">String to parse</param>
        /// <param name="parse">parsing function</param>
        /// <returns>Parsed result</returns>
        public static T? TrimAndParseNullable<T>(string s, Func<string, T> parse) where T : struct
        {
            if (string.IsNullOrEmpty(s))
            {
                return null;
            }
            else
            {
                return parse(s.Trim());
            }
        }

        /// <summary>
        /// Attempts to parse the input into an enum, and returns null if the parse is invalid.
        /// </summary>
        /// <typeparam name="T">Enum type</typeparam>
        /// <param name="source">String to parse</param>
        /// <returns>Enum value or null</returns>
        public static T? ParseEnum<T>(string source) where T : struct
        {
            T value;
            if (Enum.TryParse<T>(source, out value))
                return value;
            else
                return null;
        }

        /// <summary>
        /// Gets the string representation of the enum, or null if it has no value.
        /// </summary>
        /// <typeparam name="T">Enum type</typeparam>
        /// <param name="nullableEnum">Enum to parse</param>
        /// <returns>String value of the enum</returns>
        public static string GetNullableEnumName<T>(T? nullableEnum) where T : struct
        {
            if (nullableEnum.HasValue)
                return Enum.GetName(typeof(T), nullableEnum);
            else
                return null;
        }

        /// <summary>
		/// Converts various forms of true/false to boolean values
		/// </summary>
		/// <param name="code">String code to parse</param>
		/// <returns></returns>
		public static bool? GetTrueFalseValue(string code)
		{
			if (code == "Y" || code == "True" || code == "1")
				return true;
			else if (code == "N" || code == "False" || code == "0")
				return false;
			else
				return null;
		}

		/// <summary>
		/// Parses a string to null if it is blank, or the value that is provided in the method call.
		/// </summary>
		/// <param name="s">String to parse</param>
		/// <returns>Parsed result</returns>
		public static string StringToNullOrValue(this string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return null;
			}
			else
			{
				return s;
			}
		}
	}
}
