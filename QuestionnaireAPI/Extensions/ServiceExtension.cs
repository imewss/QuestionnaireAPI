using Microsoft.Extensions.DependencyInjection;
using QuestionnaireAPI.Interface;
using QuestionnaireAPI.Manager;

namespace QuestionnaireAPI.Extensions
{
    /// <summary>
    /// Service Extension
    /// </summary>
    public static class ServiceExtension
    {
        /// <summary>
        /// Configures the manager.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void ConfigureManager(this IServiceCollection services)
        {
            // Manager DI
            services.AddScoped<IQuestionnaireManager, QuestionnaireManager>();

         
        }

    }
}
