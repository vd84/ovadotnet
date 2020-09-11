
using Microsoft.AspNetCore.Mvc;
using Sometextapi.Models;

namespace api1.Controller {
  [Route("api")]
  [ApiController]
  public class api1 {
    public api1 () {

    }
    [HttpGet ("sometext")]
    public ActionResult<string> getAllCountries () {
      return new OkObjectResult (new Sometext("sometext for api"));
    }

  }
}