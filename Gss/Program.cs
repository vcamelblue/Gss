using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Model;
using Gss.Controller;

namespace Gss {
    static class Program {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            //Creo i clienti
            Clienti clienti = new Clienti();
            Cliente cliente1 = new Cliente("Pasquale", "Presutti", "PRRPQL92E14B519M", new DateTime(1992, 5, 14), "3453090659", "pasquale@hotmail.it");
            Cliente cliente2 = new Cliente("Antonio", "Benincasa", "BNSANT92E05B519C", new DateTime(1992, 7, 5), "3460093633", "antonio@hotmail.it");
            Cliente cliente3 = new Cliente("Vincenzo", "Villani", "VNN92E12B519A", new DateTime(1992, 8, 12), "3450083223", "vincenzo@hotmail.it");


            //ClientiController
            Controller.Controller clientiController = new ClientiController();
            clientiController.
        }
    }
}
