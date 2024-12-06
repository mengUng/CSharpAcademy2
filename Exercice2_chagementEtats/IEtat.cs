
// Interface pour définir un état
public interface IEtat
{
    // Description de l'état de l'objet
    string GetDescriptionEtat();
    

    // Référence sur l'objet
    void Handle(Porte context);
}
