using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace MVC_kurs.Middleware
{
    public class LoginMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if(context.Request.Path == "/dupa")
            {
                StreamReader sr = new StreamReader(context.Request.Body);
                string body = await sr.ReadToEndAsync();

                Dictionary<string, StringValues> queryDict = QueryHelpers.ParseQuery(body);

                if (queryDict.ContainsKey("email") && queryDict.ContainsKey("password"))
                {
                    string email = queryDict["email"].ToString();
                    string pwd = queryDict["password"].ToString();

                    bool correct = email == "admin@example.com" && pwd == "admin1234";

                    if (correct)
                    {
                        context.Response.StatusCode = 200;
                        await context.Response.WriteAsync("Logowanie poprawne");

                    }
                    else
                    {
                        context.Response.StatusCode = 200;
                        await context.Response.WriteAsync("Logowanie niepoprawne");

                    }
                }
                else
                {
                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync("Brak danych logowania");

                }


                await next(context);
            }
        }
    }
}
