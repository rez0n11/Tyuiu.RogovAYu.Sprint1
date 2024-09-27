using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RogovAYu.Sprint1.Task1.V19.Lib
{
    public class DataService : ISprint1Task1V19
    {
        public double Calculate(double x, double y)
        {
            return (x +y*10)/(x*y);
        }
    }
}
