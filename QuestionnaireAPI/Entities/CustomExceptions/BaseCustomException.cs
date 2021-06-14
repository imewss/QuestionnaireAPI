using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Questionnaire.Entities.CustomExceptions
{
    /// <summary>
    /// Base custom exception
    /// </summary>
    public class BaseCustomException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCustomException"/> class.
        /// </summary>
        /// <param name="enumErrorCode">The enum of error code.</param>
        public BaseCustomException(EnumErrorCode enumErrorCode)
        {
            ErrorCode = enumErrorCode;
            ErrorMessage = SplitCamelCase(enumErrorCode);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCustomException"/> class.
        /// </summary>
        /// <param name="enumErrorCode">The enum of error code.</param>
        /// <param name="detail">The detail.</param>
        public BaseCustomException(EnumErrorCode enumErrorCode, string detail)
        {
            ErrorCode = enumErrorCode;
            ErrorMessage = $"{SplitCamelCase(enumErrorCode)}: {detail}";
        }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public EnumErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Split the name of enumErrorCode to string
        /// </summary>
        /// <param name="badRequestEnum">Bad request Enum</param>
        /// <returns cref="string">Result of string</returns>
        private static string SplitCamelCase(EnumErrorCode badRequestEnum)
        {
            var words = Regex.Matches(badRequestEnum.ToString(), @"([A-Z][a-z]+)").Select(m => m.Value);
            var result = string.Join(" ", words);
            return result;
        }
    }
}
