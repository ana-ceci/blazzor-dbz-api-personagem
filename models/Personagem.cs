using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personagem.Models
{
    public class Personagem
{
    public string name { get; set; }
    public Origin origin { get; set; }
    public List<Transformation> transformations { get; set; }
}

public class Origin
{
    public string planet { get; set; }
}

public class Transformation
{
    public string name { get; set; }
}
}