using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slownik.Entity;
using Slownik.Repository;

namespace Slownik.Repository
{
   public interface ISlowaRepository
    {
        int Add(Slowa slowo);

        List<Slowa> GetList();

        List<Slowa> SzukaneGetList(string search);

        List<Slowa> SzukaneUlubioneGetList(string search, string user_id);

        List<Slowa> UserGetList(string user_id);

        Slowa GetSlowo(int id);

        int EditSlowo(Slowa slowo);

        int DeleteSlowo(int id);

        int DeleteUlubioneSlowo(int id);

        int SaveSlowo(int id, string user_id);
    }
}
