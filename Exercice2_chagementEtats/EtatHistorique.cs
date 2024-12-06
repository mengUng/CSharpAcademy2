


// Classe pour stocker l'historique des transitions
public class EtatHistorique
{
    private readonly List<(DateTime, IEtat)> _transitions;

    public EtatHistorique()
    {
        _transitions = new List<(DateTime, IEtat)>();
    }

    public void AjouterHistorique(IEtat etat)
    {
        _transitions.Add((DateTime.Now, etat));
    }

    public void Afficher()
    {
        Console.WriteLine("Historique des états de la porte :");
        foreach (var (date, etat) in _transitions)
        {
            Console.WriteLine($"[{date:yyyy-MM-dd HH:mm:ss}][{etat.GetType().Name}] : {etat.GetDescriptionEtat()}" );
        }
    }
}
