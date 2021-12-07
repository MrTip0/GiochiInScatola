using System;

namespace GiochiInScatola
{
    class Gioco
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Il nome deve contenere dati");
                }
                _nome = value;
            }
        }
        private decimal _prezzo;

        public decimal Prezzo
        {
            get { return _prezzo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Il prezzo deve essere maggiore di 0");
                }
                _prezzo = value;
            }
        }

        private int _classificazione;

        public int Classificazione
        {
            get { return _classificazione; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La classificazione deve essere maggiore o uguale a 0");
                }
                _classificazione = value;
            }
        }

        public Gioco(string Nome, decimal Prezzo, int Classificazione)
        {
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.Classificazione = Classificazione;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
