using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Komodo_Cars
{
public class _06_Komodo_Cars_Repository
    {
        private List<Car_Comparisons> _electricList = new List<Car_Comparisons>();
        private List<Car_Comparisons> _hybridList = new List<Car_Comparisons>();
        private List<Car_Comparisons> _gasList = new List<Car_Comparisons>();


        public void AddCarToList(Car_Comparisons car, List<Car_Comparisons> list)
        {
            list.Add(car);
        }
        public void RemoveCarFromList(Car_Comparisons car, List<Car_Comparisons> list)
        {
            list.Remove(car);
        }
        public List<Car_Comparisons>GetElectricList()
        {
            return _electricList;

        }
        public List<Car_Comparisons> GetHybridList()
        {
            return _hybridList;
        }
        public List<Car_Comparisons> GetGasList()
        {
            return _gasList;
        }


        
    }
}
