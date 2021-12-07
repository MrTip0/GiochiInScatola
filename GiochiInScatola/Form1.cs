using System;
using System.Linq;
using System.Windows.Forms;

namespace GiochiInScatola
{
    public partial class Form : System.Windows.Forms.Form
    {
        private GiocoDaTavolo selected;
        private Scaffale s;
        public Form()
        {
            InitializeComponent();
            s = new Scaffale();
            numericComplex.Maximum = 10;
            numericComplex.Minimum = 1;
            showData();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedIndex == -1)
            {
                selected = null;
            }
            else
            {
                selected = s.Giochi.ElementAt(lista.SelectedIndex);
            }
            showData();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title: Giochi Da Tavolo\nAuthor: Nicolò Luigi Allegris", "About");
        }

        private void menuImporta_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "%HOMEDIRECTORY%";
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        s = Scaffale.DaFile(filePath);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Il caricamento ha generato un errore: {err.Message}", "Errore");
                    }
                    showData();
                }
            }
        }

        private void menuEsporta_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "%HOMEDIRECTORY%";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.CheckFileExists = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    if (!filePath.EndsWith(".json"))
                    {
                        filePath += ".json";
                    }
                    s.Salva(filePath);
                }
            }
        }

        private void menuCerca_Click(object sender, EventArgs e)
        {
        }

        private void menuCasuale_Click(object sender, EventArgs e)
        {
            selected = s.Casuale();
        }

        private void showData()
        {
            if (selected != null)
            {
                tbTitolo.Text = selected.Nome;
                textPrezzo.Text = selected.Prezzo.ToString();
                textCategoria.Text = selected.Categoria;
                numericComplex.Value = selected.Complessita;
                numericRating.Value = selected.Classificazione;
                checkSquadre.Checked = selected.Squadre;
            }
            else
            {
                tbTitolo.Text = "Nessuno";
                textPrezzo.Text = "1";
                textCategoria.Text = "Nessuna";
                numericComplex.Value = 6;
                numericRating.Value = 0;
                checkSquadre.Checked = false;
            }
            lista.Items.Clear();
            lista.Items.AddRange(s.Giochi.ToArray());
        }
        private void updateData(object sender, EventArgs e)
        {
            if (selected != null)
            {
                decimal prezzo;
                bool ok = decimal.TryParse(textPrezzo.Text, out prezzo);
                if (ok)
                {
                    try
                    {
                        selected.Complessita = Convert.ToByte(numericComplex.Value);
                        selected.Classificazione = Convert.ToByte(numericRating.Value);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Inserisci un numero");
                    }
                    try
                    {
                        selected.Prezzo = prezzo;
                        selected.Nome = tbTitolo.Text;
                        selected.Categoria = textCategoria.Text;
                        selected.Squadre = checkSquadre.Checked;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Inserisci un numero");
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            selected = new GiocoDaTavolo("Vuoto", 1, 0, 6, false, "Nessuna");
            s.Aggiungi(selected);
            showData();
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            s.Rimuovi(selected);
            selected = null;
            showData();
        }
    }
}
