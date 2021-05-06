using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsegneEsame.Data
{
    public class Piatto
    {
        public int ID { get; set; }
        /// <summary>
        /// qui vengono indicati i tipi di portata (Es: antipasto/primo/secondo/contorno/dolce);
        /// </summary>
        public string Tipo { get; set; }
        /// <summary>
        /// qui vengono indicati gli allergeni contenuti (Es: glutine/uova/noci/crostacei);
        /// </summary>
        public string Allergeni { get; set; }
        /// <summary>
        ///  qui viene indicata la stagione di presentazione di un piatto (Es: inverno/primavera/estate/autunno);
        /// </summary>
        public string Stagione { get; set; }
        /// <summary>
        ///  Qui viene indicato il prezzo per i vari piatti da consegnare
        /// </summary>
        public double Prezzo { get; set; }
    }
}
