

// État "Porte fermée"
using System.ComponentModel;

public class PorteFermee : IEtat
{
    private readonly string _descriptionEtat = "La porte est fermée.";

    public void Handle(Porte context)
    {
        Console.WriteLine("La porte est fermée.");
    }

    public string GetDescriptionEtat()
    {
        return _descriptionEtat;
    }
}
