
// État "Porte verrouillée"
public class PorteVerrouillee : IEtat
{
    public void Handle(Porte context)
    {
        Console.WriteLine("La porte est verrouillée");
    }
}
