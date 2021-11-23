using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiochiInScatola
{
    class GiocoDaTavolo: Gioco
    {
        private byte _comp;

        public byte Complessita
        {
            get { return _comp; }
            set {
                if (value <= 0 || value > 10)
                {
                    throw new ArgumentException("La complessita deve essere compresa tra 1 e 10");
                }
                _comp = value;
            }
        }

        private bool _squadre;

        public bool Squadre
        {
            get { return _squadre; }
            set { _squadre = value; }
        }

        private string _categoria;

        public string Categoria
        {
            get { return _categoria; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("La categoria non può essere vuota");
                }
                _categoria = value;
            }
        }

        public GiocoDaTavolo(string Nome, decimal Prezzo, int Classificazione, byte Complessita, bool Squadre, string Categoria):
            base(Nome, Prezzo, Classificazione)
        {
            this.Categoria = Categoria;
            this.Classificazione = Classificazione;
            this.Complessita = Complessita;
        }

    }
}
