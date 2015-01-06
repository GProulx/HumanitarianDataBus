using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocumentStore.Controllers
{
    // This allows us to easily extend BaseController for Controller access instead of extending 
    // Controller directly to ensure authorization on all standard requests.
    [Authorize]
    public class BaseController : Controller
    {

    }
}