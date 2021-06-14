using Microsoft.Extensions.Logging;
using Questionnaire.Entities.CustomExceptions;
using QuestionnaireAPI.Entities.Models;
using QuestionnaireAPI.Entities.Requests;
using QuestionnaireAPI.Interface;
using System;
using System.Threading.Tasks;

namespace QuestionnaireAPI.Manager
{
    public class QuestionnaireManager : BaseManager<QuestionnaireManager>, IQuestionnaireManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionnaireManager"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="mapper">The mapper.</param>
        /// <param name="configuration">The configuration.</param>
        public QuestionnaireManager(
            ILogger<QuestionnaireManager> logger ) : base(logger)
        {
          
        }


        public async Task<QuestionnaireResponse> RegisterQuestionnaire(RegisterQuestionnaireRequestModel registerQuestionnaireRequestModel)
        {
            LogStart();
            try
            {
                var result = new QuestionnaireResponse();

                result.FirstName = registerQuestionnaireRequestModel.FirstName;
                result.Lastname = registerQuestionnaireRequestModel.Lastname;
                result.Title = registerQuestionnaireRequestModel.Title;
                result.DateOfBirth = registerQuestionnaireRequestModel.DateOfBirth;

                // validate country
                if (registerQuestionnaireRequestModel.Country.ToLower() == "cambodia"
                      || registerQuestionnaireRequestModel.Country.ToLower() == "Myanmar" || registerQuestionnaireRequestModel.Country.ToLower() == "Pakistan")
                {
                    throw new BadRequestException(EnumErrorCode.IncorrectFormat, "Questionnaire is done.");
                }

                result.House = registerQuestionnaireRequestModel.House;
                result.Work = registerQuestionnaireRequestModel.Work;

                result.Occupation = registerQuestionnaireRequestModel.Occupation;
                result.JobTitle = registerQuestionnaireRequestModel.JobTitle;
                result.BusinessType = registerQuestionnaireRequestModel.BusinessType;

                LogEnd();
                return result;
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw ex;
            }
        }



    }
}
