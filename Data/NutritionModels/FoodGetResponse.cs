using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace backend.Data.NutritionModels
{
    public class FoodGetResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<String> Nutrients { get; set; }
    }
}