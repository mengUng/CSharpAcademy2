

// Programme principal
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        // Initialisation de la porte en état fermé
        Porte porte = new Porte(new PorteFermee());
        Thread.Sleep(2000);

        // porte ouverte...
        porte.ChangerEtat(new PorteOuverte());
        Thread.Sleep(2000);

        // Porte fermée
        porte.ChangerEtat(new PorteFermee());
        Thread.Sleep(2000);

        // Porte verrouilée
        porte.ChangerEtat(new PorteVerrouillee());
        Thread.Sleep(2000);

        // Afficher l'historique des changements d'états 
        porte.AfficherEtatHistorique();
    }

}




