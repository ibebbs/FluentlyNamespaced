using Microsoft.AspNetCore.Mvc;

namespace FluentlyNamespaced.Group
{
    [Route("api/group")]
    [ApiController]
    public class Controller : ControllerBase
    {
        public Controller(Person.Data.Source personDataSource, Person.Mapping.Provider personMappingProvider)
        {

        }
    }
}
