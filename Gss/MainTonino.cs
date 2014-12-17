﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Model;
using Gss.Controller;
using Gss.View;

namespace Gss 
{
    public static class MainTonino 
    {
        public static void myTest() 
        {


            #region Clienti
            //Clienti
            Cliente cliente1 = new Cliente("Pasquale", "Presutti", "PRRPQL92E14B519M", new DateTime(1992, 5, 14), "indirizzo1", "3453090659", "pasquale@hotmail.it");
            Cliente cliente2 = new Cliente("Antonio", "Benincasa", "BNSANT92E05B519C", new DateTime(1992, 7, 5), "indirizzo2", "3460093633", "antonio@hotmail.it");
            Cliente cliente3 = new Cliente("Vincenzo", "Villani", "VNN92E12B519A", new DateTime(1992, 8, 12), "indirizzo3", "3450083223", "vincenzo@hotmail.it");
            Cliente cliente4 = new Cliente("Anthony", "De Castro", "DCSNTN92E08B519F", new DateTime(1992,1,8), "indirizzo4", "3920398760", "anthony@hotmail.it");
            Cliente cliente5 = new Cliente("Nicola", "Mignogna", "MGNNCLE92N054D", new DateTime(1992,3,14),"indirizzo5","3483948761","nicola@hotmail.it");

            //ClientiController
            ClientiController clientiController = new ClientiController();

            //Test add
            clientiController.AddCliente(cliente1); clientiController.AddCliente(cliente2); clientiController.AddCliente(cliente3);
            clientiController.AddCliente(cliente4); clientiController.AddCliente(cliente5);
            //Console.Out.Write(clientiController.Gss.Clienti.ToString());
            //clientiController.AddCliente(cliente1); test sull'aggiunta di un cliente uguale


            //Test edit
            //Cliente cliente4 = new Cliente("Pasquale", "Presutti", "PRRPQL92E14B519M", new DateTime(1992, 5, 14), "3453090659", "yahoo@hotmail.it");
            //clientiController.EditCliente(cliente1, cliente4);
            //clientiController.EditCliente(cliente1, cliente1); test sulla non modifica
            //Console.Out.Write(clientiController.Gss.Clienti.ToString());

            //Test allclienti
            //Console.Out.Write(clientiController.GetAllClienti().ToString());
            #endregion

            #region Piste

            Alpina alpina1 = new Alpina("Campitello", Difficolta.Bassa);
            Alpina alpina2 = new Alpina("Terminio", Difficolta.Bassa);
            Alpina alpina3 = new Alpina("Monte Stella", Difficolta.Media);
            Alpina alpina4 = new Alpina("Montagnola", Difficolta.Media);
            Alpina alpina5 = new Alpina("Zoncolan", Difficolta.Alta);
            Alpina alpina6 = new Alpina("Gelbison", Difficolta.Alta);

            Fondo fondo1 = new Fondo("Capracotta", 10.5, 7);
            Fondo fondo2 = new Fondo("Cervati", 20.2, 13.3);
            Fondo fondo3 = new Fondo("Alburni", 15.2, 10.1);
            Fondo fondo4 = new Fondo("Accellica", 7.3, 5.5);
            Fondo fondo5 = new Fondo("Monte Vergine", 2.2, 1.5);
            Fondo fondo6 = new Fondo("Assusa", 17.3, 10.4);

            SnowPark snowpark1 = new SnowPark("RedBull", 12, 7);
            SnowPark snowpark2 = new SnowPark("Obereggen", 5, 8);
            SnowPark snowpark3 = new SnowPark("Ursus", 10, 7);
            SnowPark snowpark4 = new SnowPark("Livigno", 8, 8);
            SnowPark snowpark5 = new SnowPark("Bardonecchia", 11, 4);
            SnowPark snowpark6 = new SnowPark("Grostè", 9, 7);

            #endregion

            #region Impianti

            Impianto impianto1 = new Impianto("I0001", "DiFontenay", "Nord");
            Impianto impianto2 = new Impianto("I0002", "Matilde", "Sud");
            Impianto impianto3 = new Impianto("I0003", "Stella", "Est");
            Impianto impianto4 = new Impianto("I0004", "SetteBello", "Sud");
            Impianto impianto5 = new Impianto("I0005", "EHEI", "Nord");

            impianto1.Add(alpina1); impianto1.Add(alpina4); impianto1.Add(snowpark3); impianto1.Add(fondo6);
            impianto2.Add(alpina2); impianto2.Add(fondo2); impianto2.Add(fondo4); impianto2.Add(snowpark1);
            impianto3.Add(alpina3); impianto3.Add(snowpark2); impianto3.Add(snowpark4); impianto3.Add(fondo1);
            impianto4.Add(alpina5); impianto4.Add(fondo3); impianto4.Add(snowpark6);
            impianto5.Add(alpina6); impianto5.Add(fondo5); impianto5.Add(snowpark5);

            Impianti impianti = new Impianti();
            impianti.Add(impianto1); impianti.Add(impianto2); impianti.Add(impianto3); impianti.Add(impianto4); impianti.Add(impianto5);
            //Console.Out.Write(impianti);
            
            #endregion
            
            
            //Creazione Resort con stagione
            DateTime DataInizioStagione = DateTime.Today.AddMonths(-1);
            DateTime DataFineStagione = DateTime.Today.AddMonths(3);
            ResortController resortController = new ResortController();
            resortController.SetResort(new Resort("Gelbison SuperSki", "Via dei Pazzi, 23", "GSS@info.it", "335904825967", DataInizioStagione,DataFineStagione));

            #region Bungalow
            Bungalow b1 = new Bungalow("B0001");
            Bungalow b2 = new Bungalow("B0002");
            Bungalow b3 = new Bungalow("B0003");
            Bungalow b4 = new Bungalow("B0004");
            Bungalow b5 = new Bungalow("B0005");
            Bungalow b6 = new Bungalow("B0006");
            Bungalow b7 = new Bungalow("B0007");
            Bungalow b8 = new Bungalow("B0008");

            Stanza s1 = new Stanza(2,3);
            Stanza s2 = new Stanza(2,2);
            Stanza s3 = new Stanza(3,3);
            Stanza s4 = new Stanza(2,4);
            Stanza s5 = new Stanza(3,4);
            Stanza s6 = new Stanza(3,5);
            Stanza s7 = new Stanza(2,4);
            Stanza s8 = new Stanza(4,5);
            Stanza s9 = new Stanza(1, 3);
            Stanza s10 = new Stanza(2, 2);
            Stanza s11 = new Stanza(2, 3);
            Stanza s12 = new Stanza(5, 7);
            
            

            b1.Add(s3);
            b1.Add(s9);
            b2.Add(s2);
            b3.Add(s1);
            b4.Add(s5);
            b5.Add(s4);
            b5.Add(s10);
            b6.Add(s6);
            b7.Add(s7);
            b7.Add(s11);
            b8.Add(s8);
            b8.Add(s12);
#endregion

            #region Aggiunta Bungalows al Resort
            resortController.AddBungalow(b1);
            resortController.AddBungalow(b2);
            resortController.AddBungalow(b3);
            resortController.AddBungalow(b4);
            resortController.AddBungalow(b5);
            resortController.AddBungalow(b6);
            resortController.AddBungalow(b7);
            resortController.AddBungalow(b8);


            /*resort.AddStanzaABungalow(b1, s1);
            resort.AddStanzaABungalow(b2, s2);
            resort.AddStanzaABungalow(b3, s3);
            resort.AddStanzaABungalow(b4, s4);
            resort.AddStanzaABungalow(b5, s5);
            resort.AddStanzaABungalow(b6, s6);
            resort.AddStanzaABungalow(b7, s7);
            resort.AddStanzaABungalow(b8, s8);*/
            #endregion

            #region Aggiunta Impianti al Resort
            resortController.AddImpianto(impianto1);
            resortController.AddImpianto(impianto2);
            resortController.AddImpianto(impianto3);
            resortController.AddImpianto(impianto5);
            resortController.AddImpianto(impianto4);
            #endregion

            PeriodiProfiliController periodiProfiliController = new PeriodiProfiliController();

            #region Profili

            ProfiliPrezziRisorse profili = new ProfiliPrezziRisorse();
            ProfiloPrezziRisorse alta = new ProfiloPrezziRisorse("Alta");
            ProfiloPrezziRisorse bassa = new ProfiloPrezziRisorse("Bassa");
            ProfiloPrezziRisorse media = new ProfiloPrezziRisorse("Media");
            profili.Add(alta);
            profili.Add(bassa);
            profili.Add(media);
            periodiProfiliController.Gss.ProfiliPrezziRisorse = profili;

            #endregion

            
           /* PrenotazioniController prenotazioni = new PrenotazioniController();
            PrenotazioneAttiva p1 = new PrenotazioneAttiva(1, 4, new DateTime(2014, 11, 26), new DateTime(2014, 11, 29), cliente1);
            p1.Bungalow = prenotazioni.FindBungalowDisponibiliFor(p1.DataInizio,p1.DataFine,p1.NumeroPersone).ListaBungalow.First();

            prenotazioni.AddPrenotazione(p1);
            Console.Out.WriteLine(prenotazioni.GetPrenotazioneByNumeroPrenotazione(1));
     
            Bungalows b=prenotazioni.FindBungalowDisponibiliFor(new DateTime(2014,11, 21), new DateTime(2014,11,25),4);
            Console.Out.WriteLine(b);*/
            #region Aggiunta Prezzi Periodi
            List<PrezzoSpecifico> prezzispecifici = new List<PrezzoSpecifico>();
            PrezzoSpecifico prezzoPerAccesso = new PrezzoSpecifico(TipologiaPrezzo.PrezzoPerAccesso, 5);
            PrezzoSpecifico prezzoPerPersonaExtra = new PrezzoSpecifico(TipologiaPrezzo.PrezzoPerPersonaExtra, 6);
            prezzispecifici.Add(prezzoPerPersonaExtra);
            prezzispecifici.Add(prezzoPerAccesso);
            PrezziRisorsa prezziImpianto1Alta = new PrezziRisorsa(10, prezzispecifici);
            PrezziRisorsa prezziImpianto2Alta = new PrezziRisorsa(20, prezzispecifici);
            PrezziRisorsa prezziImpianto3Alta = new PrezziRisorsa(15, prezzispecifici);
            PrezziRisorsa prezziImpianto4Alta = new PrezziRisorsa(20, prezzispecifici);
            PrezziRisorsa prezziImpianto5Alta = new PrezziRisorsa(11, prezzispecifici);

            PrezziRisorsa prezziImpianto1Media = new PrezziRisorsa(8, prezzispecifici);
            PrezziRisorsa prezziImpianto2Media = new PrezziRisorsa(18, prezzispecifici);
            PrezziRisorsa prezziImpianto3Media = new PrezziRisorsa(12, prezzispecifici);
            PrezziRisorsa prezziImpianto4Media = new PrezziRisorsa(15, prezzispecifici);
            PrezziRisorsa prezziImpianto5Media = new PrezziRisorsa(7, prezzispecifici);

            PrezziRisorsa prezziImpianto1Bassa = new PrezziRisorsa(5, prezzispecifici);
            PrezziRisorsa prezziImpianto2Bassa = new PrezziRisorsa(15, prezzispecifici);
            PrezziRisorsa prezziImpianto3Bassa = new PrezziRisorsa(10, prezzispecifici);
            PrezziRisorsa prezziImpianto4Bassa = new PrezziRisorsa(12, prezzispecifici);
            PrezziRisorsa prezziImpianto5Bassa = new PrezziRisorsa(3, prezzispecifici);

            PrezziRisorsa prezziBungalow1Alta = new PrezziRisorsa(60, prezzispecifici);
            PrezziRisorsa prezziBungalow2Alta = new PrezziRisorsa(20, prezzispecifici);
            PrezziRisorsa prezziBungalow3Alta = new PrezziRisorsa(30, prezzispecifici);
            PrezziRisorsa prezziBungalow4Alta = new PrezziRisorsa(35, prezzispecifici);
            PrezziRisorsa prezziBungalow5Alta = new PrezziRisorsa(45, prezzispecifici);
            PrezziRisorsa prezziBungalow6Alta = new PrezziRisorsa(50, prezzispecifici);
            PrezziRisorsa prezziBungalow7Alta = new PrezziRisorsa(65, prezzispecifici);
            PrezziRisorsa prezziBungalow8Alta = new PrezziRisorsa(80, prezzispecifici);

            PrezziRisorsa prezziBungalow1Media = new PrezziRisorsa(50, prezzispecifici);
            PrezziRisorsa prezziBungalow2Media = new PrezziRisorsa(15, prezzispecifici);
            PrezziRisorsa prezziBungalow3Media = new PrezziRisorsa(23, prezzispecifici);
            PrezziRisorsa prezziBungalow4Media = new PrezziRisorsa(30, prezzispecifici);
            PrezziRisorsa prezziBungalow5Media = new PrezziRisorsa(38, prezzispecifici);
            PrezziRisorsa prezziBungalow6Media = new PrezziRisorsa(45, prezzispecifici);
            PrezziRisorsa prezziBungalow7Media = new PrezziRisorsa(55, prezzispecifici);
            PrezziRisorsa prezziBungalow8Media = new PrezziRisorsa(70, prezzispecifici);

            PrezziRisorsa prezziBungalow1Bassa = new PrezziRisorsa(45, prezzispecifici);
            PrezziRisorsa prezziBungalow2Bassa = new PrezziRisorsa(12, prezzispecifici);
            PrezziRisorsa prezziBungalow3Bassa = new PrezziRisorsa(20, prezzispecifici);
            PrezziRisorsa prezziBungalow4Bassa = new PrezziRisorsa(25, prezzispecifici);
            PrezziRisorsa prezziBungalow5Bassa = new PrezziRisorsa(33, prezzispecifici);
            PrezziRisorsa prezziBungalow6Bassa = new PrezziRisorsa(40, prezzispecifici);
            PrezziRisorsa prezziBungalow7Bassa = new PrezziRisorsa(50, prezzispecifici);
            PrezziRisorsa prezziBungalow8Bassa = new PrezziRisorsa(65, prezzispecifici);


            periodiProfiliController.SetPrezziForRisorsaInProfilo(b1, prezziBungalow1Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b2, prezziBungalow2Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b3, prezziBungalow3Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b4, prezziBungalow4Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b5, prezziBungalow5Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b6, prezziBungalow6Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b7, prezziBungalow7Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b8, prezziBungalow8Alta, "Alta");

            periodiProfiliController.SetPrezziForRisorsaInProfilo(b1, prezziBungalow1Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b2, prezziBungalow2Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b3, prezziBungalow3Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b4, prezziBungalow4Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b5, prezziBungalow5Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b6, prezziBungalow6Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b7, prezziBungalow7Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b8, prezziBungalow8Media, "Media");

            periodiProfiliController.SetPrezziForRisorsaInProfilo(b1, prezziBungalow1Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b2, prezziBungalow2Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b3, prezziBungalow3Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b4, prezziBungalow4Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b5, prezziBungalow5Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b6, prezziBungalow6Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b7, prezziBungalow7Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(b8, prezziBungalow8Bassa, "Bassa");




            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto1, prezziImpianto1Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto2, prezziImpianto2Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto3, prezziImpianto3Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto4, prezziImpianto4Alta, "Alta");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto5, prezziImpianto5Alta, "Alta");

            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto1, prezziImpianto1Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto2, prezziImpianto2Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto3, prezziImpianto3Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto4, prezziImpianto4Media, "Media");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto5, prezziImpianto5Media, "Media");

            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto1, prezziImpianto1Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto2, prezziImpianto2Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto3, prezziImpianto3Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto4, prezziImpianto4Bassa, "Bassa");
            periodiProfiliController.SetPrezziForRisorsaInProfilo(impianto5, prezziImpianto5Bassa, "Bassa");
            #endregion

            #region Periodi

            Periodo periodo1 = new Periodo(new DateTime(2014 , 12 , 1), new DateTime(2014 , 12 , 10));
            Periodo periodo2 = new Periodo(new DateTime(2014 , 12 , 11), new DateTime(2014 , 12 , 20));
            Periodo periodo3 = new Periodo(new DateTime(2014 , 12 , 24), new DateTime(2015 , 1 , 2));
            Periodo periodo4 = new Periodo(new DateTime(2015 , 1 , 4), new DateTime(2015 , 1 , 25));
            Periodo periodo5 = new Periodo(new DateTime(2015, 1, 27), new DateTime(2015, 2, 5));
            

            periodo1.Profilo=periodiProfiliController.GetProfiloPrezziRisorsaByNome("Bassa");
            periodo2.Profilo = periodiProfiliController.GetProfiloPrezziRisorsaByNome("Media");
            periodo3.Profilo = periodiProfiliController.GetProfiloPrezziRisorsaByNome("Alta");
            periodo4.Profilo = periodiProfiliController.GetProfiloPrezziRisorsaByNome("Media");
            periodo5.Profilo = periodiProfiliController.GetProfiloPrezziRisorsaByNome("Bassa");
              


            List<Periodo> periodi=new List<Periodo>();
            periodi.Add(periodo1);periodi.Add(periodo2);periodi.Add(periodo3);periodi.Add(periodo4);
            periodi.Add(periodo5);

            #endregion


            //Console.Out.WriteLine(ppc.TrySetPeriodi(periodi));
            periodiProfiliController.SetPeriodi(periodi);
            

            foreach (Periodo p in GSS.GetInstance().GestorePeriodi.Periodi)
              Console.Out.WriteLine(p);


           
            
            PrenotazioniController prenotazioniController = new PrenotazioniController();

            /*PrenotazioneAttiva prenotazioneAttivaPassata1 = new PrenotazioneAttiva(prenotazioniController.Gss.NumeroPrenotazioni, 5, DateTime.Today.AddDays(-1), DateTime.Today, cliente5);
            prenotazioneAttivaPassata1.Bungalow = prenotazioniController.FindBungalowDisponibiliFor(prenotazioneAttivaPassata1.DataInizio, prenotazioneAttivaPassata1.DataFine, prenotazioneAttivaPassata1.NumeroPersone).ListaBungalow.First();
            prenotazioniController.AddPrenotazione(prenotazioneAttivaPassata1);
            prenotazioniController.ArchiviaPrenotazione(prenotazioneAttivaPassata1);*/

            PrenotazioneAttiva prenotazioneAttivaPassata2 = new PrenotazioneAttiva(prenotazioniController.Gss.NumeroPrenotazioni, 5, DateTime.Today.AddDays(-5), DateTime.Today, cliente4);
            prenotazioneAttivaPassata2.Bungalow = prenotazioniController.FindBungalowDisponibiliFor(prenotazioneAttivaPassata2.DataInizio, prenotazioneAttivaPassata2.DataFine, prenotazioneAttivaPassata2.NumeroPersone).ListaBungalow.First();
            prenotazioniController.AddPrenotazione(prenotazioneAttivaPassata2);

            PrenotazioneAttiva prenotazioneAttivaPassata3 = new PrenotazioneAttiva(prenotazioniController.Gss.NumeroPrenotazioni, 5, DateTime.Today.AddDays(-6), DateTime.Today.AddDays(-1), cliente4);
            prenotazioneAttivaPassata3.Bungalow = prenotazioniController.FindBungalowDisponibiliFor(prenotazioneAttivaPassata3.DataInizio, prenotazioneAttivaPassata3.DataFine, prenotazioneAttivaPassata3.NumeroPersone).ListaBungalow.First();
            prenotazioniController.AddPrenotazione(prenotazioneAttivaPassata3);
            
            

            //Console.Out.WriteLine(prenotazioni.FindBungalowDisponibiliFor(new DateTime(2014, 11, 30), new DateTime(2014, 12, 04), 5));
            PrenotazioneAttiva prenotazioneAttiva1 = new PrenotazioneAttiva(prenotazioniController.Gss.NumeroPrenotazioni, 5, DateTime.Today, DateTime.Today.AddDays(5), cliente1);
            prenotazioneAttiva1.Bungalow = prenotazioniController.FindBungalowDisponibiliFor(prenotazioneAttiva1.DataInizio, prenotazioneAttiva1.DataFine, prenotazioneAttiva1.NumeroPersone).ListaBungalow.First();
            prenotazioniController.AddPrenotazione(prenotazioneAttiva1);

            //Console.Out.WriteLine(prenotazioni.FindBungalowDisponibiliFor(new DateTime(2014, 11, 30), new DateTime(2014, 12, 04), 4));
            PrenotazioneAttiva prenotazioneAttiva2 = new PrenotazioneAttiva(prenotazioniController.Gss.NumeroPrenotazioni, 4, DateTime.Today, DateTime.Today.AddDays(7), cliente3);
            prenotazioneAttiva2.Bungalow = prenotazioniController.FindBungalowDisponibiliFor(prenotazioneAttiva2.DataInizio, prenotazioneAttiva2.DataFine, prenotazioneAttiva2.NumeroPersone).ListaBungalow.First();
            prenotazioniController.AddPrenotazione(prenotazioneAttiva2);

            //Console.Out.WriteLine(prenotazioni.FindBungalowDisponibiliFor(new DateTime(2014, 12, 12), new DateTime(2014, 12, 20), 7));
            PrenotazioneAttiva prenotazioneAttiva3 = new PrenotazioneAttiva(prenotazioniController.Gss.NumeroPrenotazioni, 7, DateTime.Today.AddMonths(1), DateTime.Today.AddMonths(1).AddDays(4), cliente2);
            prenotazioneAttiva3.Bungalow = prenotazioniController.FindBungalowDisponibiliFor(prenotazioneAttiva3.DataInizio, prenotazioneAttiva3.DataFine, prenotazioneAttiva3.NumeroPersone).ListaBungalow.First();
            prenotazioniController.AddPrenotazione(prenotazioneAttiva3);

            PrenotazioneAttiva prenotazioneAttiva4 = new PrenotazioneAttiva(prenotazioniController.Gss.NumeroPrenotazioni, 3, DateTime.Today.AddDays(15), DateTime.Today.AddDays(22), cliente5);
            prenotazioneAttiva3.Bungalow = prenotazioniController.FindBungalowDisponibiliFor(prenotazioneAttiva3.DataInizio, prenotazioneAttiva3.DataFine, prenotazioneAttiva3.NumeroPersone).ListaBungalow.First();
            prenotazioniController.AddPrenotazione(prenotazioneAttiva4);


            
            //PrenotazioneArchiviata prenotazioneArchiviata1=new PrenotazioneArchiviata(prenotazioni.Gss.NumeroPrenotazioni,3)

            Console.Out.WriteLine(prenotazioneAttiva1.Bungalow);
            Console.Out.WriteLine(prenotazioneAttiva2.Bungalow);
            Console.Out.WriteLine(prenotazioneAttiva3.Bungalow);
            Application.Run(new MainView(prenotazioniController,clientiController,resortController,periodiProfiliController));
            
             
        }
    }
}
