

// Classe représentant la porte (le contexte)
public partial class Porte
{
    private IEtat _etatActuel;      // Etat actuel de la porte
    private EtatHistorique _historique;

    public Porte(IEtat initialState)
    {
        _etatActuel = initialState;
        _historique = new EtatHistorique();

        _historique.AjouterHistorique(_etatActuel.GetType().Name);

        Console.WriteLine($"État initial de la porte : {_etatActuel.GetType().Name}");
    }

    // Permet de changer l'état de la porte
    public void ChangerEtat(IEtat nouvelEtat)
    {
        _etatActuel = nouvelEtat;

        _historique.AjouterHistorique(_etatActuel.GetType().Name);
        _etatActuel.Handle(this);  // Appel de la classe concrète qui implémente l'interface IEtat

    }

    public void AfficherEtatHistorique()
    {
        _historique.Afficher();
    }
}
