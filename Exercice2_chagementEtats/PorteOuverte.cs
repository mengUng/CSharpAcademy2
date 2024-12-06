

// État "Porte ouverte"
public class PorteOuverte : IEtat
{
    private readonly string _descriptionEtat = "La porte est ouverte.";

    public void Handle(Porte context)
    {
        Console.WriteLine("La porte est ouverte.");
    }

    public string GetDescriptionEtat()
    {
        return _descriptionEtat;
    }
}
