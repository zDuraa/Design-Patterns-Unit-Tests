using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public void algorithm(List<int> list)
        {
            QuickSort(list, 0, list.Count - 1);
            Console.WriteLine("List sorted using Quick Sort");
        }

        private void QuickSort(List<int> list, int left, int right)
        {
            int i = left, j = right;
            int pivot = list[(left + right) / 2];

            while (i <= j)
            {
                while (list[i] < pivot)
                    i++;

                while (list[j] > pivot)
                    j--;

                if (i <= j)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(list, left, j);

            if (i < right)
                QuickSort(list, i, right);
        }
    }
}
