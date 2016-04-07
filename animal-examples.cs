//  EXAMPLE C# STUFF
class Animal {
    // Simple properties
    public double speed { get; set; }
    public string species { get; set; }
    public int legs { get; set; }
    // Public method that can be redefined by derived classes
    public virtual void walk () {
        Console.WriteLine("Animal class walk method");
        speed = speed + (0.1 * legs);
    }
}

class Lizard : Animal {
    // Adding additional properties to what is inherited from Animal
    public string scaleColor { get; set; }
    public bool camouflage { get; set; }
    // Redefining the base class implementation
    public override void walk () {
        Console.WriteLine("Lizard class walk method");
        speed = speed + (0.2 * legs);
    }
}



public class Squirrel 
{
  public string Noise {get; set;}
  public virtual string Transportation() {
    return "scurries";
  }
}
public class FlyingSquirrel : Squirrel 
{
  public bool FearOfCars {get; set;}
  public override string Transportation() {
    return "flies";
  }
}

Squirrel nutsy = new Squirrel();
FlyingSquirrel batman = new FlyingSquirrel();
Console.WriteLine(nutsy.Transportation());
Console.WriteLine(batman.Transportation());
scurries
flies


public void eat(string food) 
{
    _food = food;
    Console.WriteLine("Currently eating {0}", food);
}