

// État "Porte fermée"
public class PorteFermee : IEtat
{
    public void Handle(Porte context)
    {
        Console.WriteLine("La porte est fermée.");
    }
}
