using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GiochiInScatola
{
    class Scaffale
    {
        private List<GiocoDaTavolo> _giochi;

        public List<GiocoDaTavolo> Giochi
        {
            get { return _giochi; }
            private set
            {
                _giochi = value;
            }
        }

        public Scaffale()
        {
            Giochi = new List<GiocoDaTavolo>();
        }

        public Scaffale(List<GiocoDaTavolo> Giochi)
        {
            this.Giochi = Giochi;
        }

        static public Scaffale DaFile(string FileName)
        {
            if (!File.Exists(FileName))
            {
                throw new Exception("Il file non esiste");
            }
            var lista = new List<GiocoDaTavolo>();
            lista.AddRange(JsonSerializer.Deserialize<GiocoDaTavolo[]>(File.ReadAllText(FileName)));
            return new Scaffale(lista);
        }

        public void Salva(string FileName)
        {
            var opt = new JsonSerializerOptions();
            opt.WriteIndented = true;
            File.WriteAllText(FileName, JsonSerializer.Serialize(Giochi.ToArray(), opt));
        }

        public GiocoDaTavolo Casuale()
        {
            Random rand = new Random();
            return Giochi[rand.Next(Giochi.Count)];
        }

        private int trova(string titolo)
        {
            string trova = titolo.ToLower();
            for (int j = 0; j < Giochi.Count; j++)
            {
                var gioco = Giochi[j];
                int i = 0;
                int tl = titolo.Length;
                int l = gioco.Nome.Length - tl;
                while (i < l)
                {
                    if (gioco.Nome.Substring(i, tl).ToLower() == trova)
                    {
                        return j;
                    }
                    i++;
                }
            }
            return -1;
        }

        public GiocoDaTavolo Cerca(string titolo)
        {
            int p = trova(titolo);
            if (p != -1)
            {
                return Giochi[p];
            }
            else
            {
                return null;
            }
        }
        public void Aggiungi(GiocoDaTavolo nuovo)
        {
            if (nuovo != null)
            {
                Giochi.Add(nuovo);
            }
            else
            {
                throw new ArgumentException("Il nuovo gioco non deve essere void");
            }
        }
        public void Rimuovi(string nome)
        {
            int index = trova(nome);
            if (index != -1)
            {
                Giochi.Remove(Giochi[index]);
            }
        }
        public void Rimuovi(GiocoDaTavolo gioco)
        {
            Giochi.Remove(gioco);
        }
    }
}
