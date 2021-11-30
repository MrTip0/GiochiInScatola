
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
            this.menuSalva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEsporta = new System.Windows.Forms.ToolStripMenuItem();
            this.datiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCasuale = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTitolo = new System.Windows.Forms.TextBox();
            this.textPrezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericComplex = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.checkSquadre = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericComplex)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(0, 24);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(172, 266);
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
            this.btnAbout.Size = new System.Drawing.Size(180, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSalva,
            this.menuEsporta});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuSalva
            // 
            this.menuSalva.Name = "menuSalva";
            this.menuSalva.Size = new System.Drawing.Size(180, 22);
            this.menuSalva.Text = "Salva";
            this.menuSalva.Click += new System.EventHandler(this.menuSalva_Click);
            // 
            // menuEsporta
            // 
            this.menuEsporta.Name = "menuEsporta";
            this.menuEsporta.Size = new System.Drawing.Size(180, 22);
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
            this.menuCerca.Size = new System.Drawing.Size(180, 22);
            this.menuCerca.Text = "Cerca";
            this.menuCerca.Click += new System.EventHandler(this.menuCerca_Click);
            // 
            // menuCasuale
            // 
            this.menuCasuale.Name = "menuCasuale";
            this.menuCasuale.Size = new System.Drawing.Size(180, 22);
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
            this.panel1.Size = new System.Drawing.Size(482, 266);
            this.panel1.TabIndex = 2;
            // 
            // tbTitolo
            // 
            this.tbTitolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitolo.Location = new System.Drawing.Point(6, 3);
            this.tbTitolo.Name = "tbTitolo";
            this.tbTitolo.Size = new System.Drawing.Size(342, 20);
            this.tbTitolo.TabIndex = 0;
            // 
            // textPrezzo
            // 
            this.textPrezzo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrezzo.Location = new System.Drawing.Point(7, 30);
            this.textPrezzo.Name = "textPrezzo";
            this.textPrezzo.Size = new System.Drawing.Size(172, 20);
            this.textPrezzo.TabIndex = 1;
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
            // numericRating
            // 
            this.numericRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericRating.Location = new System.Drawing.Point(7, 69);
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(171, 20);
            this.numericRating.TabIndex = 3;
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
            // numericComplex
            // 
            this.numericComplex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericComplex.Location = new System.Drawing.Point(10, 145);
            this.numericComplex.Name = "numericComplex";
            this.numericComplex.Size = new System.Drawing.Size(171, 20);
            this.numericComplex.TabIndex = 5;
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
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(262, 144);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(180, 20);
            this.textCategoria.TabIndex = 7;
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
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(670, 223);
            this.Name = "Form";
            this.Text = "Giochi in Scatola";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericComplex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSalva;
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
    }
}

