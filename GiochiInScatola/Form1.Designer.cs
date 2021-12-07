
namespace GiochiInScatola
{
    partial class Form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImporta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEsporta = new System.Windows.Forms.ToolStripMenuItem();
            this.datiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCasuale = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkSquadre = new System.Windows.Forms.CheckBox();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericComplex = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrezzo = new System.Windows.Forms.TextBox();
            this.tbTitolo = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericComplex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(0, 24);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(172, 213);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.datiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(107, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImporta,
            this.menuEsporta});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuImporta
            // 
            this.menuImporta.Name = "menuImporta";
            this.menuImporta.Size = new System.Drawing.Size(116, 22);
            this.menuImporta.Text = "Importa";
            this.menuImporta.Click += new System.EventHandler(this.menuImporta_Click);
            // 
            // menuEsporta
            // 
            this.menuEsporta.Name = "menuEsporta";
            this.menuEsporta.Size = new System.Drawing.Size(116, 22);
            this.menuEsporta.Text = "Esporta";
            this.menuEsporta.Click += new System.EventHandler(this.menuEsporta_Click);
            // 
            // datiToolStripMenuItem
            // 
            this.datiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCerca,
            this.menuCasuale});
            this.datiToolStripMenuItem.Name = "datiToolStripMenuItem";
            this.datiToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.datiToolStripMenuItem.Text = "Dati";
            // 
            // menuCerca
            // 
            this.menuCerca.Name = "menuCerca";
            this.menuCerca.Size = new System.Drawing.Size(115, 22);
            this.menuCerca.Text = "Cerca";
            this.menuCerca.Click += new System.EventHandler(this.menuCerca_Click);
            // 
            // menuCasuale
            // 
            this.menuCasuale.Name = "menuCasuale";
            this.menuCasuale.Size = new System.Drawing.Size(115, 22);
            this.menuCasuale.Text = "Casuale";
            this.menuCasuale.Click += new System.EventHandler(this.menuCasuale_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkSquadre);
            this.panel1.Controls.Add(this.textCategoria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericComplex);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericRating);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textPrezzo);
            this.panel1.Controls.Add(this.tbTitolo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(172, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 213);
            this.panel1.TabIndex = 2;
            // 
            // checkSquadre
            // 
            this.checkSquadre.AutoSize = true;
            this.checkSquadre.Location = new System.Drawing.Point(10, 183);
            this.checkSquadre.Name = "checkSquadre";
            this.checkSquadre.Size = new System.Drawing.Size(74, 17);
            this.checkSquadre.TabIndex = 8;
            this.checkSquadre.Text = "A squadre";
            this.checkSquadre.UseVisualStyleBackColor = true;
            this.checkSquadre.Leave += new System.EventHandler(this.updateData);
            // 
            // textCategoria
            // 
            this.textCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCategoria.Location = new System.Drawing.Point(262, 144);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(148, 20);
            this.textCategoria.TabIndex = 7;
            this.textCategoria.Leave += new System.EventHandler(this.updateData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // numericComplex
            // 
            this.numericComplex.Location = new System.Drawing.Point(10, 145);
            this.numericComplex.Name = "numericComplex";
            this.numericComplex.Size = new System.Drawing.Size(171, 20);
            this.numericComplex.TabIndex = 5;
            this.numericComplex.Leave += new System.EventHandler(this.updateData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Complessità 1/10";
            // 
            // numericRating
            // 
            this.numericRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericRating.Location = new System.Drawing.Point(7, 69);
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(171, 20);
            this.numericRating.TabIndex = 3;
            this.numericRating.Leave += new System.EventHandler(this.updateData);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "€";
            // 
            // textPrezzo
            // 
            this.textPrezzo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrezzo.Location = new System.Drawing.Point(7, 30);
            this.textPrezzo.Name = "textPrezzo";
            this.textPrezzo.Size = new System.Drawing.Size(172, 20);
            this.textPrezzo.TabIndex = 1;
            this.textPrezzo.Leave += new System.EventHandler(this.updateData);
            // 
            // tbTitolo
            // 
            this.tbTitolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitolo.Location = new System.Drawing.Point(6, 3);
            this.tbTitolo.Name = "tbTitolo";
            this.tbTitolo.Size = new System.Drawing.Size(342, 20);
            this.tbTitolo.TabIndex = 0;
            this.tbTitolo.Leave += new System.EventHandler(this.updateData);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAggiungi.Location = new System.Drawing.Point(0, 214);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 3;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRimuovi.Location = new System.Drawing.Point(97, 214);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(75, 23);
            this.btnRimuovi.TabIndex = 4;
            this.btnRimuovi.Text = "Rimuovi";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 237);
            this.Controls.Add(this.btnRimuovi);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(670, 276);
            this.Name = "Form";
            this.Text = "Giochi in Scatola";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericComplex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImporta;
        private System.Windows.Forms.ToolStripMenuItem menuEsporta;
        private System.Windows.Forms.ToolStripMenuItem datiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCerca;
        private System.Windows.Forms.ToolStripMenuItem menuCasuale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrezzo;
        private System.Windows.Forms.TextBox tbTitolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericRating;
        private System.Windows.Forms.CheckBox checkSquadre;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericComplex;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnRimuovi;
    }
}

