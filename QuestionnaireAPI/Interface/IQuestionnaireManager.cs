using QuestionnaireAPI.Entities.Models;
using QuestionnaireAPI.Entities.Requests;
using System.Threading.Tasks;

namespace QuestionnaireAPI.Interface
{
    public interface IQuestionnaireManager
    {
        Task<QuestionnaireResponse> RegisterQuestionnaire(RegisterQuestionnaireRequestModel registerQuestionnaireRequestModel);
    }
}
