using BilgiOptik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOptik
{
    class Kayit<T>
    {



        public void MusteriKayit(Musteri musteri)
        {

            using (BilgiOptikContext db =new BilgiOptikContext())
            {

                db.Musteri.Add(musteri);

                db.SaveChanges();
               

            }


        }



    }
}
