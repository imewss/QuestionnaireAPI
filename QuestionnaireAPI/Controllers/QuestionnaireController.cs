using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Questionnaire.Entities.CustomExceptions;
using QuestionnaireAPI.Entities.DomainModels;
using QuestionnaireAPI.Entities.Models;
using QuestionnaireAPI.Entities.Requests;
using QuestionnaireAPI.Helper;
using QuestionnaireAPI.Interface;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;

namespace QuestionnaireAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionnaireController : ControllerBase
    {
        private readonly ILogger<QuestionnaireController> _logger;
        private readonly IQuestionnaireManager  _questionnaireManager;

        public QuestionnaireController(ILogger<QuestionnaireController> logger, IQuestionnaireManager questionnaireManager)
        {
            _logger = logger;
            _questionnaireManager = questionnaireManager;
        }

       
        [HttpPost]
        [Route("Register")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(BaseDomainModel<QuestionnaireResponse>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(BaseDomainModel<ProblemDetails>))]
        public async Task<JsonResult> RegisterQuestionnaire(RegisterQuestionnaireRequestModel registerQuestionnaireRequestModel)
        {

            object response;

            try
            {
                var result = await _questionnaireManager.RegisterQuestionnaire(registerQuestionnaireRequestModel);
                response = new BaseDomainModel<QuestionnaireResponse>() { Success = true, Payload = result };
            }
            catch (BadRequestException ex)
            {
                _logger.LogError("BadRequestException in RegisterQuestionnaire" + ex);
                HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                response = new BadRequestError(GeneralHelper.GetPathFromContext(HttpContext), ex.ErrorMessage, "RegisterQuestionnaire");
            }
            catch (Exception ex)
            {
                response = new BaseDomainModel<QuestionnaireResponse>() { Success = false, Payload = null };
                _logger.LogError("Exception in RegisterQuestionnaire" + ex);
            }
            return new JsonResult(response);

        }
    }
}
