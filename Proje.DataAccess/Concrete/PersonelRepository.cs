using Proje.DataAccess.Abstract;
using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Concrete
{
    internal class PersonelRepository : IPersonelRepository
    {
        public PersonelBilgi CreatePersonel(PersonelBilgi personel)
        {
            using (var personelDbContext = new PersonelBilgiDbContext())
            {
                personelDbContext.PersonelBilgisi.Add(personel);
                personelDbContext.SaveChanges();
                return personel;
            }
        }

        public void DeletePersonel(int Id)
        {
            using (var personelDbContext = new PersonelBilgiDbContext())
            {
                var deletedPersonel = GetPersonelById(Id);
                personelDbContext.PersonelBilgisi.Remove(deletedPersonel);
                personelDbContext.SaveChanges();
            }
        }

        public List<PersonelBilgi> GetAllPersonels()
        {
            using (var personelDbContext = new PersonelBilgiDbContext())
            {
                return personelDbContext.PersonelBilgisi.ToList();
            }
        }

        public PersonelBilgi GetPersonelById(int Id)
        {
            using (var personelDbContext = new PersonelBilgiDbContext())
            {
                return personelDbContext.PersonelBilgisi.Find(Id);
            }
        }

        public PersonelBilgi UpdatePersonel(PersonelBilgi personel)
        {
            using (var personelDbContext = new PersonelBilgiDbContext())
            {
                personelDbContext.PersonelBilgisi.Update(personel);
                return personel;
            }
        }
    }
}
