
using Lib.Interface;
using Models.Lib;

namespace Lib.Models
{
    public class EvalueteCheckProductPrice : ICheckProductPrice
    {
        public string CheckProductPrice(Product p)
        {
            if (p.Price > 100)
            {
                return "Expensive Product Price!";
            }
            else if (p.Price <= 100 && p.Price > 40)
            {
                return "Average Product Price!";
            }
            else
            {
                return "Cheap Product Price!";
            }
        }
    }
}
