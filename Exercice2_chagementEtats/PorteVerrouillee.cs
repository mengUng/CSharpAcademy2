
// État "Porte verrouillée"
public class PorteVerrouillee : IEtat
{
    private readonly string _descriptionEtat = "La porte est verrouillée.";

    public void Handle(Porte context)
    {
        Console.WriteLine("La porte est verrouillée");
    }

    public string GetDescriptionEtat()
    {
        return _descriptionEtat;
    }
}
