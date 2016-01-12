using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace WebApiTester
{
    //class BasicAuthMiddleware:OwinMiddleware
    //{
    //    public BasicAuthMiddleware(OwinMiddleware next) : base(next)
    //    {
    //    }

    //    //public override Task Invoke(IOwinContext context)
    //    //{
            
            
    //    //    context.Request.OnSendingHeaders(state =>
    //    //    {
    //    //        var resp = (OwinResponse)state;

    //    //        if (resp.StatusCode == 401)
    //    //            resp.SetHeader("WWW-Authenticate", "Basic");
    //    //    }, response);

    //    //    var header = request.GetHeader("Authorization");

    //    //    if (!String.IsNullOrWhiteSpace(header))
    //    //    {
    //    //        var authHeader = System.Net.Http.Headers
    //    //                           .AuthenticationHeaderValue.Parse(header);

    //    //        if ("Basic".Equals(authHeader.Scheme,
    //    //                                 StringComparison.OrdinalIgnoreCase))
    //    //        {
    //    //            string parameter = Encoding.UTF8.GetString(
    //    //                                  Convert.FromBase64String(
    //    //                                        authHeader.Parameter));
    //    //            var parts = parameter.Split(':');

    //    //            string userName = parts[0];
    //    //            string password = parts[1];

    //    //            if (userName == password) // Just a dumb check
    //    //            {
    //    //                var claims = new[]
    //    //            {
    //    //                new Claim(ClaimTypes.Name, "Badri")
    //    //            };
    //    //                var identity = new ClaimsIdentity(claims, "Basic");

    //    //                request.User = new ClaimsPrincipal(identity);
    //    //            }
    //    //        }
    //    //    }

    //    //    await Next.Invoke(request, response);
    //    //}
    //}
}
