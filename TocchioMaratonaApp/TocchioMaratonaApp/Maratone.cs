using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TocchioMaratonaApp
{
    class Maratone
    {
        public List<Maratona> elencoMaratone;

        public Maratone()
        {
            elencoMaratone = new List<Maratona>();
        }

        public void Aggiungi(Maratona maratona)
        {
            elencoMaratone.Add(maratona);
        }

        public void LeggiDati()
        {
            using (FileStream flussoDati = new FileStream("maratona.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        Maratona maratona = new Maratona();
                        maratona.NomeAtleta = campi[0];
                        maratona.SocietàDiAppartenenza = campi[1];
                        maratona.TempoImpiegato = TrasformaTempo(campi[2]);
                        maratona.CittàInCuiSièCorsaLaMaratona = campi[3];


                        Aggiungi(maratona);

                    }
                }
            }
        }



        public string CalcolaDurata()
        {
            string durata = "0";

            return durata.ToString();
        }

        public int TrasformaTempo(string oreMinuti)
        {
            
            int ore = int.Parse(oreMinuti.Substring(0, 2));
            int minuti = int.Parse(oreMinuti.Substring(3, 2));
            return   ore * 60 + minuti;
         }
    }
}
