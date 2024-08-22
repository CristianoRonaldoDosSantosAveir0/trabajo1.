public interface IconstruirE
{
    void edificio();
}
public interface IconstruirM
{
    void material();
}
public class construirCastillo : IconstruirE
{
    public void edificio()
    {
        Console.WriteLine("Este es un Castillo");
        Console.WriteLine("Este es una Torre");
        Console.WriteLine("Esto es una Muralla\n");
    }
}

public class Material : IconstruirM
{
    public void material()
    {
        Console.WriteLine("El materia es de Hormigón");
        Console.WriteLine("El materia es de Tela");
        Console.WriteLine("El materia es de Madera");
    }
}

public interface FabricaAbstract
{
    IconstruirE crearEdificio();
    IconstruirM crearMaterial();
}
public class fabricaTotal : FabricaAbstract
{
    public IconstruirE crearEdificio()
    {
        return new construirCastillo();
    }
    public IconstruirM crearMaterial()
    {
        return new Material();
    }
}



public class cliente
{
    private readonly IconstruirE _Tipo;
    private readonly IconstruirM _Material;

    public cliente(FabricaAbstract fabrica)
    {
        _Tipo = fabrica.crearEdificio();
        _Material = fabrica.crearMaterial();
    }
    public void ejecucion()
    {
        _Tipo.edificio();
        _Material.material();
    }
}





public class Programa
{
    public static void Main(string[] args)
    {
        FabricaAbstract edificio1 = new fabricaTotal();
        cliente cliente1 = new cliente(edificio1);
        cliente1.ejecucion();
    }
}