using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab4
{
    class OneDimensionalArray
    {
        private readonly int length;
        private readonly int[] array;

        public OneDimensionalArray(int length) 
        {
            this.length = length;
            this.array = new int[length];
        }

        public int Length 
        {
            get => this.length;
        }

        public int this[int index] 
        {
            get 
            {
                if (index >= 0 && index < this.length)
                    return this.array[index];
                else 
                    throw new Exception("Індекс вийшов за межі масиву");
            }
            set 
            {
                if (!(index >= 0 && index < this.length))
                    throw new Exception("Індекс вийшов за межі масиву");
                else
                    this.array[index] = value;
            }
        }

        public int Min
        {
            get
            {
                if (length > 0) 
                {
                    int min = this.array[0];
                    for (int i = 0; i < this.length; i++)
                    {
                        if (this.array[i] < min)
                            min = this.array[i];
                    }
                    return min;
                }
                throw new Exception("Кількість елементів у масиві не може бути менша або рівна нулю");
            }
        }
    }
}
