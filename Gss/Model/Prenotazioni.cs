﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Prenotazioni
    {
        private List<Prenotazione> _prenotazioni;

        public Prenotazioni(List<Prenotazione> prenotazioni)
        {
            _prenotazioni = prenotazioni;
        }

        public Prenotazioni(){
            _prenotazioni = new List<Prenotazione>();
        }

        public List<Prenotazione> ListaPrenotazioni
        {
            get { return _prenotazioni; }
            set { _prenotazioni = value; }
        }


        public bool Add(Prenotazione prenotazione)
        {
            if (ListaPrenotazioni.Contains(prenotazione))
                return false;

            ListaPrenotazioni.Add(prenotazione);

            return true;
        }

        public bool Remove(Prenotazione prenotazione)
        {
            return ListaPrenotazioni.Remove(prenotazione);
        }

        public Prenotazione GetPrenotazioneByNumPrenotazione(int numeroPrenotazione)
        {
            foreach (Prenotazione p in ListaPrenotazioni)
            {
                if (p.NumeroPrenotazione == numeroPrenotazione)
                    return p;
            }
            return null;
        }

        public List<PrenotazioneAttiva> GetPrenotazioniAttive()
        {
            List<PrenotazioneAttiva> result = new List<PrenotazioneAttiva>();

            foreach (Prenotazione p in ListaPrenotazioni)
            {
                if (p is PrenotazioneAttiva)
                {
                    PrenotazioneAttiva prenotazione = (PrenotazioneAttiva)p;
                    result.Add(prenotazione);
                }
            }
            return result;
        }

        public List<PrenotazioneArchiviata> GetPrenotazioneArchiviata()
        {
            List<PrenotazioneArchiviata> result = new List<PrenotazioneArchiviata>();

            foreach (Prenotazione p in ListaPrenotazioni)
            {
                if (p is PrenotazioneArchiviata)
                {
                    PrenotazioneArchiviata prenotazione = (PrenotazioneArchiviata)p;
                    result.Add(prenotazione);
                }
            }
            return result;
        }


        public bool ArchiviaPrenotazione(PrenotazioneAttiva prenotazioneAttiva)
        {
            Fattura fattura = Fatturatore.GeneraFattura(prenotazioneAttiva);

            PrenotazioneArchiviata prenotazioneArchiviata = CreaPrenotazioneArchiviata(prenotazioneAttiva, fattura);
           
            if (this.Remove(prenotazioneAttiva))
            {
                return this.Add(prenotazioneArchiviata);
            }

            return false;
        }

        public Prenotazioni GetPrenotazioniByCliente(Cliente cliente)
        {
            Prenotazioni prenotazioni = new Prenotazioni();

            foreach(Prenotazione p in this.ListaPrenotazioni)
            {
                if (p.Cliente.Equals(cliente))
                    prenotazioni.Add(p);
            }
            return prenotazioni;
            
        }

        private PrenotazioneArchiviata CreaPrenotazioneArchiviata(PrenotazioneAttiva prenotazioneAttiva, Fattura fattura)
        {
            int numeroPrenotazione = prenotazioneAttiva.NumeroPrenotazione;
            int numeroPersone = prenotazioneAttiva.NumeroPersone;
            DateTime dataInizio = prenotazioneAttiva.DataInizio;
            DateTime dataFine = prenotazioneAttiva.DataFine;
            Cliente cliente = prenotazioneAttiva.Cliente;

            return new PrenotazioneArchiviata(numeroPrenotazione, numeroPersone, dataInizio, dataFine, cliente, fattura);
        }

    }
}
