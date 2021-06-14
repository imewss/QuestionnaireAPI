namespace Questionnaire.Entities.CustomExceptions
{
    /// <summary>
    /// Bad request exception
    /// </summary>
    public class BadRequestException : BaseCustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        /// <param name="enumErrorCode">The enum of error code.</param>
        /// <param name="detail">The detail.</param>
        public BadRequestException(EnumErrorCode enumErrorCode, string detail) : base(enumErrorCode, detail)
        {
        }
    }
}
