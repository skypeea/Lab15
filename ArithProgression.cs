using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class ArithProgression : ISeries
    {
        int startValue = 0;
        int step = 1;
        int currentValue;
        public int GetNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
            Console.WriteLine("Сброс. Стартовое значение: " + currentValue);
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
            Console.WriteLine("Стартовое значение: " + startValue);
        }
       public void setStep(int s)
        {
            step = s;
            Console.WriteLine("Шаг: " + step );
        }
    }
}
