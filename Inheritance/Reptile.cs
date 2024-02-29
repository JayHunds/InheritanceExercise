using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance 
{
    public class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public bool LaysEggs { get; set; }
        public string SkinTexture { get; set; }
    }
}
