//          ZOOLANDIA - ZOO ANIMALS etc.
          
// ANIMAL CLASS
class Animal 
{
    public string AnimalName { get; set; }    
}


// GENUS : URSUS (BEARS)
class Ursus : Animal
{
    public string GenusName { get; set; }
}

// SPECIES
class Ursus Maritimus : Ursus 
{
    public string SpeciesName { get; set; }    
}
class Ailuropoda melanoleuca : Ursus 
{
    public string SpeciesName { get; set; }    
}
class Ursus thibetanus : Ursus 
{
    public string SpeciesName { get; set; }    
}
class Ursus Arctos : Ursus 
{
    public string SpeciesName { get; set; }    
}



// GENUS : PANTHERA (BIG CATS)
class Panthera : Animal
{
    public string GenusName { get; set; }
}

// SPECIES
class Panthera tigris : Panthera 
{
    public string SpeciesName { get; set; }    
}
class Panthera leo : Panthera 
{
    public string SpeciesName { get; set; }    
}
class Panthera uncia : Panthera 
{
    public string SpeciesName { get; set; }    
}
class Panthera onca : Panthera 
{
    public string SpeciesName { get; set; }    
}



// GENUS: VULPES (FOXES)
class Vulpes : Animal
{
    public string GenusName { get; set; }
}

// SPECIES
class V. lagopus : Vulpes 
{
    public string SpeciesName { get; set; }    
}
class V. bengalensis : Vulpes 
{
    public string SpeciesName { get; set; }    
}
class V. zerda : Vulpes 
{
    public string SpeciesName { get; set; }    
}
class V. vulpes : Vulpes 
{
    public string SpeciesName { get; set; }    
}
class Panthera tigris : Vulpes 
{
    public string SpeciesName { get; set; }    
}



// GENUS: IGUANA (IGUANA)
class Iguana : Animal
{
    public string GenusName { get; set; }
}

// SPECIES
class I. iguana : Iguana 
{
    public string SpeciesName { get; set; }    
}



// GENUS: AFROGECKO (GECKO)
class Afrogecko : Animal
{
    public string GenusName { get; set; }
}

// SPECIES
class A. porphyreus : Afrogecko 
{
    public string SpeciesName { get; set; }    
}



// GENUS: PYTHON (PYTHON)
class Python : Animal
{
    public string GenusName { get; set; }
}

// SPECIES
class P. molurus : Python 
{
    public string SpeciesName { get; set; }    
}




class Lion : Species 
{
    public string Noise { get; set; }
    public bool Exotic { get; set; }
    public int FiercenessLevel {get; set;}
}
class Tiger : Species 
{
    public string Noise { get; set; }
    public bool Exotic { get; set; }
    public int FiercenessLevel {get; set;}
}
class Bear : Species 
{
    public string Noise { get; set; }
    public bool Exotic { get; set; }
    public int FiercenessLevel {get; set;}
}
class UrsusMaritimus : 


Lion alex = new Lion();
alex.SpeciesName = "Panthera Leo";
alex.Noise = "roar";
alex.FiercenessLevel = 9;
alex.Exotic = false;
Console.WriteLine ("I have a Lion named Alex who makes a noise that sounds like {0}. I would 
rate his fierceness as a {1}.", alex.Noise, alex.FiercenessLevel);
I have a Lion named Alex who makes a noise that sounds like roar. I would rate his fierceness as a 9.
