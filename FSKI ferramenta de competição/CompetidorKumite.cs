using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSKI_ferramenta_de_competição
{
    class CompetidorKumite
    {
       // public string association;
       // public string name;
        public int pontuação;
        public enum AtenaiBehavior { NotAvailable, Ichi, Keikoku, Chui, Hansoku };
        public AtenaiBehavior atenaiBehavior;
        public enum Jogai { NotAvailable, Ichi, Keikoku, Chui, Hansoku };
        public Jogai jogai;

        public CompetidorKumite()
        {
            pontuação = 0;
            atenaiBehavior = AtenaiBehavior.NotAvailable;
            jogai = Jogai.NotAvailable;
        }

        public void addWazari()
        {
            this.pontuação++;
        }

        public void addIponn()
        {
            this.pontuação += 2;
        }
        
        public void subWazari()
        {
            if(this.pontuação>0)
                this.pontuação--;
        }

        public void subIponn()
        {
            if (this.pontuação > 1)
                this.pontuação -= 2;
        }


    }
}
