using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business.Abstract
{
    public interface IPersonelService
    {
        List<PersonelBilgi> GetAllPersonel();
        PersonelBilgi GetPersonelById(int Id);
        PersonelBilgi CreatePersonel(PersonelBilgi personel);
        PersonelBilgi UpdatePersonel(PersonelBilgi personel);
        void DeletePersonel(int id);
    }
}
