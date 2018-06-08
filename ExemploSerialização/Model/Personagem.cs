using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Personagem
    {
        private string Nome;
        private string Cla;
        private int NivelChakra;

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        
        public void SetCla(string cla)
        {
            this.Cla = cla;
        }

        public void SetNivelChakra(int nivelChakra)
        {
            this.NivelChakra = nivelChakra;
        }

        public string GetNome() { return Nome; }
        public string GetCla() { return Cla; }
        public int GetNivelChakra() { return NivelChakra; }
    }
}
