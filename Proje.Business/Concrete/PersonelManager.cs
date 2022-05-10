using Proje.Business.Abstract;
using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelService _personelService;
        public PersonelManager()
        {
            _personelService = new PersonelManager();
        }
        public PersonelBilgi CreatePersonel(PersonelBilgi personel)
        {
            if (personel.TcKimlikNo.Length<11)
            {
                return _personelService.CreatePersonel(personel);
            }
            else
            {
                throw new Exception("Tc kimlik No 11 haneli olmalıdır.");
            }
        }

        public void DeletePersonel(int id)
        {
            _personelService.DeletePersonel(id);
        }

        public List<PersonelBilgi> GetAllPersonel()
        {
            return _personelService.GetAllPersonel();
        }

        public PersonelBilgi GetPersonelById(int Id)
        {
            if (Id < 0)
            {
                return _personelService.GetPersonelById(Id);
            }

            throw new Exception("İd 1 den küçük olamaz.");
        }

        public PersonelBilgi UpdatePersonel(PersonelBilgi personel)
        {
            return _personelService.UpdatePersonel(personel);
        }
    }
}
