using Migration_Estudo.DAO;
using Migration_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migration_Estudo.Business
{
    public class CaminhaoBusiness
    {
        public void Add(Caminhao caminhao)
        {
            var caminhaodao = new CaminhaoDAO();
            caminhaodao.AddCaminhao(caminhao);
        }

        public List<Caminhao> Read()
        {
            return new CaminhaoDAO().GetList();
        }

        public void Delete(Caminhao caminhao)
        {
            new CaminhaoDAO().DeleteCaminhao(caminhao);
        }

        public void Update(Caminhao caminhao)
        {
            new CaminhaoDAO().UpdateCaminhao(caminhao);
        }
    }
}
