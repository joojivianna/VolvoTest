using Migration_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migration_Estudo.DAO
{
    public class CaminhaoDAO
    {
        public List<Caminhao> GetList()
        {
            using (var db = new CaminhaoContext())
            {
                var blogs = db.Caminhoes.ToList();
                return blogs;
            }
        }

        public void AddCaminhao(Caminhao caminhao)
        {
            using (var db = new CaminhaoContext())
            {
                db.Caminhoes.Add(caminhao);
                db.SaveChanges();
            }
        }

        public void UpdateCaminhao(Caminhao caminhao)
        {
            using (var db = new CaminhaoContext())
            {                
                db.Caminhoes.Add(caminhao);
                db.SaveChanges();
            }
        }

        public void DeleteCaminhao(Caminhao caminhao)
        {
            using (var db = new CaminhaoContext())
            {
                db.Caminhoes.Remove(caminhao);
                db.SaveChanges();
            }
        }

    }
}
