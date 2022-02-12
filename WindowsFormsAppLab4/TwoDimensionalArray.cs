using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab4
{
    class TwoDimensionalArray
    {
        private readonly int[,] array;
        private readonly int row;
        private readonly int col;

        public TwoDimensionalArray(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.array = new int[row, col];
        }

        public int Row 
        {
            get => this.row; 
        }
        public int Col 
        {
            get => this.col;
        }

        public int this[int i, int j] 
        {
            get 
            {
                if ((i >= 0 && i < this.row) && (j >= 0 && j <= this.col))
                    return this.array[i, j];
                throw new Exception("Індекс вийшов за межі масиву");
            }
            set 
            {
                if ((i >= 0 && i < this.row) && (j >= 0 && j <= this.col))
                    this.array[i, j] = value;
                else
                    throw new Exception("Індекс вийшов за межі масиву");
            }
        }

        public int NumberWorkshopWithMinAmount 
        {
            get 
            {
                int min_sum=0, number=0;
                for (int i = 0; i < this.row; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < this.col; j++)
                    {
                        sum += this.array[i, j];
                    }
                    if (i == 0)
                    {
                        min_sum = sum;
                        number = i;
                    }
                    else 
                    {
                        if(sum<min_sum)
                        {
                            min_sum = sum;
                            number = i;
                        }
                    }
                }
                return number + 1;
            }
        }
    }
}
