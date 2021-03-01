using GPRC.core.domaine.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GPRC.core.domaine.Entities
{
  public  class Dossier: BaseEntity
    {

        public int Numero_dossier { get; set; }
        public DateTime Date_entree_jouissance { get; set; }
        public DateTime Date_effet_premier_paiement { get; set; }
        public int Num_as400 { get; set; }
        public string Zone_libre { get; set; }
        public bool Flag_majoration_rente { get; set; }
        public DateTime Date_mise_en_sommeil { get; set; }

    }
}
