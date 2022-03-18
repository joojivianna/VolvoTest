using Migration_Estudo.Business;
using Migration_Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migration_Estudo.Controllers
{
    public class CaminhaoController
    {
        public void Add(Caminhao caminhao)
        {
            var caminhaodao = new CaminhaoBusiness();
            caminhaodao.Add(caminhao);
        }

        public List<Caminhao> Read()
        {
            return new CaminhaoBusiness().Read();
        }

        public void Delete(Caminhao caminhao)
        {
            new CaminhaoBusiness().Delete(caminhao);
        }

        public void Update(Caminhao caminhao)
        {
            new CaminhaoBusiness().Update(caminhao);
        }
    }
}
