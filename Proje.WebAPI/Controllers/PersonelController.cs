using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Business.Abstract;
using Proje.Business.Concrete;
using Proje.Entities;

namespace Proje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private IPersonelService _personelService;

        public PersonelController()
        {
            _personelService = new PersonelManager();
        }

        [HttpGet]
        public List<PersonelBilgi> Get()
        {
            return _personelService.GetAllPersonel();
        }
         
        [HttpPost]
        public PersonelBilgi Post([FromBody]PersonelBilgi personel)
        {
            return _personelService.CreatePersonel(personel);
        }

        [HttpPut]
        public PersonelBilgi Put([FromBody]PersonelBilgi personel)
        {
            return _personelService.UpdatePersonel(personel);
        }

        [HttpGet("{id}")]
        public PersonelBilgi Get(int Id)
        {
            return _personelService.GetPersonelById(Id);
        }

        [HttpDelete("{id}")]
        public void Delete(int Id)
        {
             _personelService.DeletePersonel(Id);
        }
    }
}
