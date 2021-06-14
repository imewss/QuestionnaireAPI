namespace QuestionnaireAPI.Entities.DomainModels
{
    /// <summary>
    /// Base response DTO
    /// </summary>
    /// <typeparam name="T">parameter type</typeparam>
    public class BaseDomainModel<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BaseDomainModel{T}"/> is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        /// <value>
        /// The payload.
        /// </value>
        public T Payload { get; set; }
    }
}
