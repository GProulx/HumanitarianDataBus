using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DocumentStore.Controllers
{
    // This allows us to easily extend ApiBaseController for ApiController access instead of extending 
    // ApiController directly to ensure authorization on all api requests.
    [Authorize]
    public class ApiBaseController : ApiController
    {

    }
}