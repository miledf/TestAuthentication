using System.Web.Http;
using TesteAuthentication.App_Start;

namespace TesteAuthentication.Controllers
{
    [ApiAuthenticationFilter]
    public class LoginController : ApiController
    {
        public string Get()
        {
            return "Hello Miled" ;
        }
    }
}
