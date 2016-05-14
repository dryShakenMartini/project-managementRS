using Microsoft.AspNet.Mvc.Filters;
using Microsoft.AspNet.Mvc;
using ProjectManagementRS.Models;

namespace ProjectManagementRS.Filters
{
    public class AdminAttribute: ActionFilterAttribute
    {
        private readonly IRoleRepository _repository;
        public AdminAttribute(IRoleRepository repository)
        {
            _repository = repository;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated &&
                context.HttpContext.User.IsInRole(_repository.GetRole(RoleType.Administrator)))
            {
                // do nothing
            }
            else
            {
                context.Result = new HttpUnauthorizedResult(); // mark unauthorized
            }
        }
    
    }
}
