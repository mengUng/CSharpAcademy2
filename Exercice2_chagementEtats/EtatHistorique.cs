


// Classe pour stocker l'historique des transitions
public class EtatHistorique
{
    private readonly List<(DateTime Date, string Etat)> _transitions;

    public EtatHistorique()
    {
        _transitions = new List<(DateTime, string)>();
    }

    public void AjouterHistorique(string etat)
    {
        _transitions.Add((DateTime.Now, etat));
    }

    public void Afficher()
    {
        Console.WriteLine("Historique des états de la porte :");
        foreach (var (date, etat) in _transitions)
        {
            Console.WriteLine($"[{date:yyyy-MM-dd HH:mm:ss}] État : {etat}");
        }
    }
}
