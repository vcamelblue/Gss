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
            Cliente cliente1 = new Cliente("Pasquale", null, "PRRPQL92E14B519M", new DateTime(1992, 5, 14), "indirizzo1", "3453090659", "pasquale@hotmail.it");
            Cliente cliente2 = new Cliente("Antonio", "Benincasa", "BNSANT92E05B519C", new DateTime(1992, 7, 5), "indirizzo2", "3460093633", "antonio@hotmail.it");
            Cliente cliente3 = new Cliente("Vincenzo", "Villani", "VNN92E12B519A", new DateTime(1992, 8, 12), "indirizzo3", "3450083223", "vincenzo@hotmail.it");


            //ClientiController
            ClientiController clientiController = new ClientiController();

            //Test add
            clientiController.AddCliente(cliente1); clientiController.AddCliente(cliente2); clientiController.AddCliente(cliente3);
            //Console.Out.Write(clientiController.Gss.Clienti.ToString());
            //clientiController.AddCliente(cliente1); test sull'aggiunta di un cliente uguale


            //Test edit
            //Cliente cliente4 = new Cliente("Pasquale", "Presutti", "PRRPQL92E14B519M", new DateTime(1992, 5, 14), "3453090659", "yahoo@hotmail.it");
            //clientiController.EditCliente(cliente1, cliente4);
            //clientiController.EditCliente(cliente1, cliente1); test sulla non modifica
            //Console.Out.Write(clientiController.Gss.Clienti.ToString());

            //Test allclienti
            Console.Out.Write(clientiController.GetAllClienti().ToString());
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
            Console.Out.Write(impianti);
            #endregion
            
            //Application.Run(new Form());

            PrenotazioniController prenotazioni = new PrenotazioniController();
            ResortController resort = new ResortController();
            resort.Gss.Resort = new Resort("a", "a", "a", "a");
            Bungalow b1 = new Bungalow("44");
            Bungalow b2 = new Bungalow("45");
            Bungalow b3 = new Bungalow("46");
            Bungalow b4 = new Bungalow("56");
            Bungalow b5 = new Bungalow("34");
            Bungalow b6 = new Bungalow("35");
            Bungalow b7 = new Bungalow("24");
            Bungalow b8 = new Bungalow("57");

            Stanza s1 = new Stanza(4,4);
            Stanza s2 = new Stanza(4,5);
            Stanza s3 = new Stanza(4,6);
            Stanza s4 = new Stanza(5,6);
            Stanza s5 = new Stanza(3,4);
            Stanza s6 = new Stanza(3,5);
            Stanza s7 = new Stanza(2,4);
            Stanza s8 = new Stanza(5,7);

            b1.Add(s1);
            b2.Add(s2);
            b3.Add(s3);
            b4.Add(s4);
            b5.Add(s5);
            b6.Add(s6);
            b7.Add(s7);
            b8.Add(s8);

            resort.AddBungalow(b2);
            resort.AddBungalow(b1);
            resort.AddBungalow(b3);
            resort.AddBungalow(b4);
            resort.AddBungalow(b5);
            resort.AddBungalow(b6);
            resort.AddBungalow(b7);
            resort.AddBungalow(b8);


            /*resort.AddStanzaABungalow(b1, s1);
            resort.AddStanzaABungalow(b2, s2);
            resort.AddStanzaABungalow(b3, s3);
            resort.AddStanzaABungalow(b4, s4);
            resort.AddStanzaABungalow(b5, s5);
            resort.AddStanzaABungalow(b6, s6);
            resort.AddStanzaABungalow(b7, s7);
            resort.AddStanzaABungalow(b8, s8);*/

            PrenotazioneAttiva p1 = new PrenotazioneAttiva(1, 4, new DateTime(2014, 11, 26), new DateTime(2014, 11, 29), cliente1);
            p1.Bungalow = b1;

            prenotazioni.AddPrenotazione(p1);
     
            Bungalows b=prenotazioni.FindBungalowDisponibiliFor(new DateTime(2014,11, 21), new DateTime(2014,11,25),4);
            Console.Out.WriteLine(b);

            Periodo periodo1 = new Periodo(new DateTime(2014 / 12 / 1), new DateTime(2014 / 12 / 10));
            Periodo periodo2 = new Periodo(new DateTime(2014 / 12 / 3), new DateTime(2014 / 12 / 8));
            Periodo periodo3 = new Periodo(new DateTime(2014 / 12 / 4), new DateTime(2014 / 12 / 7));
            Periodo periodo4 = new Periodo(new DateTime(2014 / 12 / 5), new DateTime(2014 / 12 / 9));
            List<Periodo> periodi=new List<Periodo>();
            periodi.Add(periodo1);periodi.Add(periodo2);periodi.Add(periodo3);periodi.Add(periodo4);

            PeriodiProfiliController ppc=new PeriodiProfiliController();
            Console.Out.WriteLine(ppc.TryAddPeriodi(periodi));
            
        }
    }
}
