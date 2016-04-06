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

class Animal {
    public string AnimalName { get; set; }    
}
class Species : Animal {
    public string SpeciesName { get; set; }    
}
class Lion : Species {
    public string Noise { get; set; }
    public bool Exotic { get; set; }
    public int FiercenessLevel {get; set;}
}
class Tiger : Species {
    public string Noise { get; set; }
    public bool Exotic { get; set; }
    public int FiercenessLevel {get; set;}
}
class Bear : Species {
    public string Noise { get; set; }
    public bool Exotic { get; set; }
    public int FiercenessLevel {get; set;}
}
class Cheetah : Species {
    public string Noise { get; set; }
    public bool Exotic { get; set; }
    public int FiercenessLevel {get; set;}
}
Lion alex = new Lion();
alex.SpeciesName = "Panthera Leo";
alex.Noise = "roar";
alex.FiercenessLevel = 9;
alex.Exotic = false;
Console.WriteLine ("I have a Lion named Alex who makes a noise that sounds like {0}. I would 
rate his fierceness as a {1}.", alex.Noise, alex.FiercenessLevel);
I have a Lion named Alex who makes a noise that sounds like roar. I would rate his fierceness as a 9.