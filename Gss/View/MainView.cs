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
using Gss.View.MainViewPanel;
using Gss.View.Utility;

namespace Gss.View
{
    public partial class MainView : Form
    {
        //Fields

        //Controller
        private ClientiController clientiController;
        private ResortController resortController;
        private PrenotazioniController prenotazioniController;
        private PeriodiProfiliController periodiProfiliController;

        //Pannelli
        private RiepilogoGiornalieroPanel riepilogoGiornalieroPanel;
        private GestionePrenotazioniPanel gestionePrenotazioniPanel;
        private GestioneClientiPanel gestioneClientiPanel;
        private GestioneResortPanel gestioneResortPanel;
        private GestioneProfiliPanel gestioneProfiliPanel;
        private GestionePeriodiPanel gestionePeriodiPanel;
        private GestioneIncassiPanel gestioneIncassiPanel;

        //Impostazioni bottoni
        private Button previusSelectedButton = null;

        private Color normalButtonColor = ConfigAndUtility.normalButtonColor;
        private Color selectedButtonColor = ConfigAndUtility.selectedButtonColor;
        private Color normalFontColor = ConfigAndUtility.normalFontColor;
        private Color selectFontColor = ConfigAndUtility.selectFontColor;
        

        //Constructors

        public MainView(PrenotazioniController prenotazioniController, ClientiController clientiController, ResortController resortController, PeriodiProfiliController periodiProfiliController)
        {
            this.clientiController = clientiController;
            this.resortController = resortController;
            this.prenotazioniController = prenotazioniController;
            this.periodiProfiliController = periodiProfiliController;

            InitializeComponent();            

            //Creo e Aggiungo il pannello Riepilogo
            riepilogoGiornalieroPanel = new RiepilogoGiornalieroPanel(this.components, prenotazioniController);
            riepilogoGiornalieroTabPage.Controls.Add(riepilogoGiornalieroPanel);

            //Creo e Aggiungo il pannello Prenotazioni
            gestionePrenotazioniPanel = new GestionePrenotazioniPanel(this.components, prenotazioniController, clientiController, resortController);
            gestionePrenotazioniTabPage.Controls.Add(gestionePrenotazioniPanel);

            //Creo e Aggiungo il pannello Clienti
            gestioneClientiPanel = new GestioneClientiPanel(this.components, clientiController);
            gestioneClientiTabPage.Controls.Add(gestioneClientiPanel);

            //Creo e Aggiungo il pannello Resort
            gestioneResortPanel = new GestioneResortPanel(this.components,resortController);
            gestioneResortTabPage.Controls.Add(gestioneResortPanel);

            //Creo e Aggiungo il pannello Profili
            gestioneProfiliPanel = new GestioneProfiliPanel(this.components, periodiProfiliController, resortController);
            gestioneProfiliTabPage.Controls.Add(gestioneProfiliPanel);

            //Creo e Aggiungo il pannello Periodi
            gestionePeriodiPanel = new GestionePeriodiPanel(this.components,periodiProfiliController);
            gestionePeriodiTabPage.Controls.Add(gestionePeriodiPanel);

            //Creo e Aggiungo il pannello Incassi
            gestioneIncassiPanel = new GestioneIncassiPanel(this.components,prenotazioniController);
            gestioneIncassiTabPage.Controls.Add(gestioneIncassiPanel);


            //Imposto il pannello giusto
            if (!resortController.IsStagioneImpostata())
            {
                switchToPage(gestioneResortTabPage, gestioneResortTabButton);
            }
            else if (!resortController.IsStagioneIniziata())
            {
                switchToPage(gestionePrenotazioniTabPage, gestioneResortTabButton);
            }
            else
            {
                switchToPage(riepilogoGiornalieroTabPage, riepilogoGiornalieroTabButton);
            }
        }


        //Events

        private void riepilogoGiornalieroTabButton_Click(object sender, EventArgs e)
        {
            switchToPage(riepilogoGiornalieroTabPage, riepilogoGiornalieroTabButton);

            riepilogoGiornalieroPanel.Refresh();
        }

        private void gestionePrenotazioniTabButton_Click(object sender, EventArgs e)
        {
            switchToPage(gestionePrenotazioniTabPage, gestionePrenotazioniTabButton);

            gestionePrenotazioniPanel.Refresh();
        }

        private void gestioneClientiTabButton_Click(object sender, EventArgs e)
        {
            switchToPage(gestioneClientiTabPage, gestioneClientiTabButton);

            gestioneClientiPanel.Refresh();
        }

        private void gestioneResortTabButton_Click(object sender, EventArgs e)
        {
            switchToPage(gestioneResortTabPage, gestioneResortTabButton);

            gestioneResortPanel.Refresh();
        }

        private void gestioneProfiliTabButton_Click(object sender, EventArgs e)
        {
            switchToPage(gestioneProfiliTabPage, gestioneProfiliTabButton);

            gestioneProfiliPanel.Refresh();
        }

        private void gestionePeriodiTabButton_Click(object sender, EventArgs e)
        {
            switchToPage(gestionePeriodiTabPage, gestionePeriodiTabButton);

            gestionePeriodiPanel.Refresh();
        }

        private void gestioneIncassiTabButton_Click(object sender, EventArgs e)
        {
            switchToPage(gestioneIncassiTabPage, gestioneIncassiTabButton);

            gestioneIncassiPanel.Refresh();
        }


        //Private Utility Methods

        private void switchToPage(TabPage newTabPage, Button selectedButtonAssociated)
        {
            selectRightPanel(newTabPage);
            selectRightTabButton(selectedButtonAssociated);
        }


        private void selectRightPanel(TabPage tabPage)
        {
            tabControlWithoutHeader.SelectedTab = tabPage;
        }


        private void selectRightTabButton(Button newSelectedButton)
        {
            if (previusSelectedButton != null)
            {
                previusSelectedButton.BackColor = normalButtonColor;
                previusSelectedButton.ForeColor = normalFontColor;
                previusSelectedButton.FlatAppearance.MouseOverBackColor = normalButtonColor;
            }
            newSelectedButton.BackColor = selectedButtonColor;
            newSelectedButton.ForeColor = selectFontColor;
            newSelectedButton.FlatAppearance.MouseOverBackColor = selectedButtonColor;
            previusSelectedButton = newSelectedButton;
        }

    }
}
