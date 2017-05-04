using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSKI_ferramenta_de_competição
{
    class CompetidorKata
    {
        public const int tamanhoPontos = 5;
      //  public string association;
      //  public string name;
        public float[] pontos = new float[tamanhoPontos];


        public int buscaIndiceMaior()
        {
            int indiceMaior=0,tamanhoPontos=5;
            float maior=0;
            for (int i = 0; i < tamanhoPontos; i++)
            {
                if (maior < pontos[i])
                {
                    maior = pontos[i];
                    indiceMaior = i;
                }
            }
            return indiceMaior;
        }

        public int buscaIndiceMenor()
        {
            int indiceMenor = 0;
            float menor = 10;
            for (int i = 0; i < tamanhoPontos; i++)
            {
                if (menor > pontos[i])
                {
                    menor = pontos[i];
                    indiceMenor = i;
                }
            }
            return indiceMenor;
        }


        public float calculaSoma()
        {
            float sum=0;
            int indiceMenor, indiceMaior;
            indiceMaior = buscaIndiceMaior();
            indiceMenor = buscaIndiceMenor();
            if (indiceMaior == indiceMenor)
            {
                indiceMenor = 1;
                indiceMaior = 0;
            }
            for (int i = 0; i < tamanhoPontos; i++)
            {
                if (i != indiceMaior && i != indiceMenor)
                {
                    sum += pontos[i];
                }
            }
            return sum;
        }
    }
}
