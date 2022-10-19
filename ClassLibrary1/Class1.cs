using Microsoft.AspNetCore.Mvc.Filters;

namespace ClassLibrary1
{
    public class Class1 : IAsyncActionFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}