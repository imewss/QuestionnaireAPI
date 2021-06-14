using System;

namespace QuestionnaireAPI.Entities.Requests
{
    public class RegisterQuestionnaireRequestModel
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }

        // Address
        public string House { get; set; }
        public string Work { get; set; }

        // Occupation
        public string Occupation { get; set; }
        public string JobTitle { get; set; }
        public string BusinessType { get; set; }
   
    }
}
