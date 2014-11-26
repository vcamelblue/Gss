using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Controller;
using Gss.Model;

namespace Gss.View 
{
    public partial class AggiungiModificaImpianto : Form 
    {
        private bool inEditingMode;
        private ResortController resortController;
        private Impianto impianto;
        private List<Pista> pisteImpianto;

        public AggiungiModificaImpianto(ResortController resortController) 
        {
            this.resortController = resortController;
            inEditingMode = false;
            impianto = null;
            pisteImpianto = new List<Pista>();

            InitializeComponent();
        }

        public AggiungiModificaImpianto(ResortController resortController, Impianto impianto)
        {
            this.resortController = resortController;
            inEditingMode = true;
            this.impianto = impianto;
            pisteImpianto = impianto.Piste;

            InitializeComponent();
        }

        private void AggiungiModificaImpianto_Load(object sender, EventArgs e)
        {
            if (inEditingMode)
            {
                codiceTextBox.Text = impianto.Codice;
                nomeTextBox.Text = impianto.Nome;
                versanteTextBox.Text = impianto.Versante;
                foreach (Pista p in pisteImpianto)
                {
                    pisteDataGridView.Rows.Add(p.Nome, GetTipologiaByPista(p), GetInfoByPista(p));
                }
                pisteTotaliLabel.Text = "Piste Totali  "+pisteImpianto.Count().ToString();
                codiceTextBox.Enabled=false;
            }
        }

        private string GetTipologiaByPista(Pista pista)
        {
            if (pista is Alpina)
                return "Alpina";
            if (pista is Fondo)
                return "Fondo";
            if (pista is SnowPark)
                return "SnowPark";
            return "";
        }
        private string GetInfoByPista(Pista pista)
        {
            if (pista is Alpina)
            {
                Alpina alpina = (Alpina)pista;
                return "Difficoltà: " + alpina.Difficolta.ToString();
            }
            if (pista is Fondo)
            {
                Fondo fondo = (Fondo)pista;
                return "Dislivello Medio: " + fondo.DislivelloMedio + ";  Dislivello Massimo: " + fondo.DislivelloMassimo; 
            }
            if (pista is SnowPark)
            {
                SnowPark snowPark = (SnowPark)pista;
                return "Salti: " + snowPark.NumeroSalti + ";  Jibs:" + snowPark.NumeroJibs;
            }
            return "";
        }


    }
}
