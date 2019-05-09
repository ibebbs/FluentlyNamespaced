using Microsoft.AspNetCore.Mvc;

namespace FluentlyNamespaced.Role
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly Repository _roleRepository;
        private readonly Person.Repository _personRespository;

        public Controller(Repository roleRepository, Person.Repository personRepository)
        {
            _roleRepository = roleRepository;
            _personRespository = personRepository;
        }

        [HttpPost("{roleId}/{personId}")]
        public void AddUserToRole(int roleId, int personId)
        {
            Model role = _roleRepository.Get(roleId);
            Person.Model person = _personRespository.Get(personId);

            role.Add(person);

            _roleRepository.Save(role);
        }
    }
}
