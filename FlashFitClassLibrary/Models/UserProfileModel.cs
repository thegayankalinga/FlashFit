using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashFitClassLibrary.Enumz;

namespace FlashFitClassLibrary.Models
{
    public class UserProfileModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public GenderTypeEnum Gender { get; set; }
        public double WeightInKiloGrams { get; set; }
        public double HeightInCentiMeter { get; set; }


    }
}
