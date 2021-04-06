using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data.NutritionModels
{
    public interface IDataRepository
    {
        Task<FoodGetResponse> GetFoodByName();
    }
}