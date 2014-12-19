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
        
        /* Intero rappresentante lo step attuale di configurazione: 
         * step 0 : impostazione info resort e date
         * step 1 : impostazione risorse
         * step 2 : impostazione profilo
         * step 3 : impostazione periodo
         * step 4 : attesa inizio stagione
         * step 5 : stadio finale, tutto ablitato
            
         * private int actualConfigurationStep = 0;
        */

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

                showHelpMessage();
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
            if (isPanelAccesible(4))
            {
                switchToPage(riepilogoGiornalieroTabPage, riepilogoGiornalieroTabButton);

                riepilogoGiornalieroPanel.Refresh();
            }
        }

        private void gestionePrenotazioniTabButton_Click(object sender, EventArgs e)
        {
            if (isPanelAccesible(4))
            {
                switchToPage(gestionePrenotazioniTabPage, gestionePrenotazioniTabButton);

                gestionePrenotazioniPanel.Refresh();
            }            
        }

        private void gestioneClientiTabButton_Click(object sender, EventArgs e)
        {
            //Sempre Accessibile

            switchToPage(gestioneClientiTabPage, gestioneClientiTabButton);

            gestioneClientiPanel.Refresh();
        }

        private void gestioneResortTabButton_Click(object sender, EventArgs e)
        {
            //Sempre Accessibile

            switchToPage(gestioneResortTabPage, gestioneResortTabButton);

            gestioneResortPanel.Refresh();
        }

        private void gestioneProfiliTabButton_Click(object sender, EventArgs e)
        {
            if (isPanelAccesible(2))
            {
                switchToPage(gestioneProfiliTabPage, gestioneProfiliTabButton);

                gestioneProfiliPanel.Refresh();
            }
        }

        private void gestionePeriodiTabButton_Click(object sender, EventArgs e)
        {
            if (isPanelAccesible(3))
            {
                switchToPage(gestionePeriodiTabPage, gestionePeriodiTabButton);

                gestionePeriodiPanel.Refresh();
            }
        }

        private void gestioneIncassiTabButton_Click(object sender, EventArgs e)
        {
            if (isPanelAccesible(4))
            {
                switchToPage(gestioneIncassiTabPage, gestioneIncassiTabButton);

                gestioneIncassiPanel.Refresh();
            }
        }


        //Private Utility Methods

        private void showHelpMessage()
        {
            StringBuilder message = new StringBuilder();

            message.Append("Benvenuto in Gelbison Super Sky!\n");
            message.Append("Per configurare correttamente il software è necessario innanzitutto impostare le info del resort ");
            message.Append("e le date di inizio e fine della stagione corrente. ");
            message.Append("Successivamente sarà possibile aggiungere una o più risorse al sistema in modo da poter essere successivamente prezzate. ");
            message.Append("A questo punto sarà necessario creare uno o più profili per poter impostare i periodi in modo corretto. ");
            message.Append("Una volta impostati anche quest'ultimi sara possibile iniziare ad usare il software con tutte le sue funzionalità abilitate.");

            MessageBox.Show(message.ToString());
        }

        private bool isPanelAccesible(int stepChiamante)
        {
            if (!resortController.IsStagioneImpostata() && stepChiamante != 0)
            {
                MessageBox.Show("Prima di continuare è necessario impostare le date della stagione! Inserisci le date per continuare.");
                return false;
            }
            else if (!resortController.thereIsAtLeastOneRisorsa() && stepChiamante != 1 && stepChiamante > 0)
            {
                MessageBox.Show("Prima di continuare è necessario inserire almeno una risorsa! Inserisci una o più risorse per continuare.");
                return false;
            }
            else if (!resortController.thereIsAtLeastOneProfilo() && stepChiamante != 2 && stepChiamante > 1)
            {
                MessageBox.Show("Prima di continuare è necessario impostare almeno un profilo! Inserisci uno o più profili per continuare.");
                return false;
            }
            else if (!resortController.thereIsAtLeastOnePeriodo() && stepChiamante != 3 && stepChiamante > 2)
            {
                MessageBox.Show("Prima di continuare è necessario impostare almeno un periodo! Inserisci uno o più periodi per continuare.");
                return false;
            }
            else if (!resortController.IsStagioneIniziata() && stepChiamante != 4 && stepChiamante > 3)
            {
                MessageBox.Show("La stagione non è ancora iniziata! Pannello non disponibile.");
                return false;
            }

            return true;
        }

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
