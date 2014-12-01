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
        private ClientiController clientiController;
        private ResortController resortController;
        private PrenotazioniController prenotazioniController;
        private PeriodiProfiliController periodiProfiliController;

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
            RiepilogoGiornalieroPanel riepilogoGiornalieroPanel = new RiepilogoGiornalieroPanel(this.components,prenotazioniController);
            riepilogoGiornalieroTabPage.Controls.Add(riepilogoGiornalieroPanel);

            //Creo e Aggiungo il pannello Prenotazioni
            GestionePrenotazioniPanel gestionePrenotazioniPanel = new GestionePrenotazioniPanel(this.components,prenotazioniController,clientiController,resortController);
            gestionePrenotazioniTabPage.Controls.Add(gestionePrenotazioniPanel);

            //Creo e Aggiungo il pannello Clienti
            GestioneClientiPanel gestioneClientiPanel = new GestioneClientiPanel(this.components,clientiController);
            gestioneClientiTabPage.Controls.Add(gestioneClientiPanel);

            //Creo e Aggiungo il pannello 

            //Creo e Aggiungo il pannello Profili
            GestioneProfili gestioneProfiliPanel = new GestioneProfili(this.components);
            gestioneProfiliTabPage.Controls.Add(gestioneProfiliPanel);

            //Creo e Aggiungo il pannello 

            //Creo e Aggiungo il pannello Incassi
            GestioneIncassi gestioneIncassiPanel = new GestioneIncassi(this.components);
            gestioneIncassiTabPage.Controls.Add(gestioneIncassiPanel);
        }

        private void riepilogoGiornalieroTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(riepilogoGiornalieroTabButton);
            tabControlWithoutHeader.SelectedTab = riepilogoGiornalieroTabPage;
        }

        private void gestionePrenotazioniTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestionePrenotazioniTabButton);
            tabControlWithoutHeader.SelectedTab = gestionePrenotazioniTabPage;
        }

        private void gestioneClientiTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneClientiTabButton);
            tabControlWithoutHeader.SelectedTab = gestioneClientiTabPage;
        }

        private void gestioneResortTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneResortTabButton);
            tabControlWithoutHeader.SelectedTab = gestioneResortTabPage;
        }

        private void gestioneProfiliTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneProfiliTabButton);
            tabControlWithoutHeader.SelectedTab = gestioneProfiliTabPage;
        }

        private void gestionePeriodiTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestionePeriodiTabButton);
            tabControlWithoutHeader.SelectedTab = gestionePeriodiTabPage;
        }

        private void gestioneIncassiTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(gestioneIncassiTabButton);
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
