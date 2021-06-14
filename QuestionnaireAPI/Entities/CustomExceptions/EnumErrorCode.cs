namespace Questionnaire.Entities.CustomExceptions
{
    /// <summary>
    /// Custom error enum
    /// </summary>
    public enum EnumErrorCode
    {
        /// <summary>
        /// Missing required data
        /// </summary>
        MissingRequiredData = 10001,

        /// <summary>
        /// Duplicate data
        /// </summary>
        DuplicateData = 10002,

        /// <summary>
        /// Incorrect format
        /// </summary>
        IncorrectFormat = 10003,

        /// <summary>
        /// Item already exists
        /// </summary>
        ItemAlreadyExists = 10004,

        /// <summary>
        /// Bad status
        /// </summary>
        BadStatus = 10005,

        /// <summary>
        /// Not found of custom error
        /// </summary>
        NotFound = 10006,

        /// <summary>
        /// The internal server error
        /// </summary>
        InternalServerError = 10007,

        /// <summary>
        /// The country not support
        /// </summary>
        CountryNotSupport = 1008,

        /// <summary>
        /// The unauthorized
        /// </summary>
        Unauthorized = 1009
    }
}
