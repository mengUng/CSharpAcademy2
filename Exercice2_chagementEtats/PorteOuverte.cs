

// État "Porte ouverte"
public class PorteOuverte : IEtat
{
    public void Handle(Porte context)
    {
        Console.WriteLine("La porte est ouverte.");
    }
}
