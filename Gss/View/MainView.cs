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

namespace Gss.View
{
    public partial class MainView : Form
    {
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
        private Color normalButtonColor = Color.FromKnownColor(KnownColor.LightGray);
        private Color selectedButtonColor = Color.FromArgb(54, 78, 102); //Color.FromKnownColor(KnownColor.MenuHighlight);
        private Color normalFontColor = Color.FromKnownColor(KnownColor.Black);
        private Color selectFontColor = Color.FromArgb(251, 251, 251);

        public MainView(PrenotazioniController prenotazioniController, ClientiController clientiController, ResortController resortController, PeriodiProfiliController periodiProfiliController)
        {
            this.clientiController = clientiController;
            this.resortController = resortController;
            this.prenotazioniController = prenotazioniController;
            this.periodiProfiliController = periodiProfiliController;

            InitializeComponent();


            selectRightTab(riepilogoGiornalieroTabButton);

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
        }

        private void riepilogoGiornalieroTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(riepilogoGiornalieroTabButton);
            riepilogoGiornalieroPanel.Refresh();
            tabControlWithoutHeader.SelectedTab = riepilogoGiornalieroTabPage;
        }

        private void gestionePrenotazioniTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestionePrenotazioniTabButton);
            gestionePrenotazioniPanel.Refresh();
            tabControlWithoutHeader.SelectedTab = gestionePrenotazioniTabPage;
        }

        private void gestioneClientiTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneClientiTabButton);
            gestioneClientiPanel.Refresh();
            tabControlWithoutHeader.SelectedTab = gestioneClientiTabPage;
        }

        private void gestioneResortTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneResortTabButton);
            gestioneResortPanel.Refresh();
            tabControlWithoutHeader.SelectedTab = gestioneResortTabPage;
        }

        private void gestioneProfiliTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneProfiliTabButton);
            gestioneProfiliPanel.Refresh();
            tabControlWithoutHeader.SelectedTab = gestioneProfiliTabPage;
        }

        private void gestionePeriodiTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestionePeriodiTabButton);
            gestionePeriodiPanel.Refresh();
            tabControlWithoutHeader.SelectedTab = gestionePeriodiTabPage;
        }

        private void gestioneIncassiTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneIncassiTabButton);
            gestioneIncassiPanel.Refresh();
            tabControlWithoutHeader.SelectedTab = gestioneIncassiTabPage;
        }

        private void selectRightTab(Button newSelectedButton)
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
