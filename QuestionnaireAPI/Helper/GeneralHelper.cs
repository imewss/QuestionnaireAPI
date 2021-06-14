using Microsoft.AspNetCore.Http;

namespace QuestionnaireAPI.Helper
{
    /// <summary>
    /// General Helper
    /// </summary>
    public class GeneralHelper
    {
        /// <summary>
        /// Get Path From Context.
        /// </summary>
        /// <param name="httpContext">Http Context.</param>
        /// <returns cref="string">System String.</returns>
        public static string GetPathFromContext(HttpContext httpContext)
        {
            var routePath = $"{httpContext.Request.Method} {httpContext.Request.Path}";
            return routePath;
        }
    }
}
