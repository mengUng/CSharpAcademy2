

// Programme principal
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        // Initialisation de la porte en état fermé
        Porte porte = new Porte(new PorteFermee());

        // porte ouverte...
        porte.ChangerEtat(new PorteOuverte());

        // Porte fermée
        porte.ChangerEtat(new PorteFermee());

        // Porte verrouilée
        porte.ChangerEtat(new PorteVerrouillee());

        // Afficher l'historique des changements d'états 
        porte.AfficherEtatHistorique();
    }

}




