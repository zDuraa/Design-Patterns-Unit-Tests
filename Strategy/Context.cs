using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy _sortStrategy;

        public Context(IStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(IStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(List<int> list)
        {
            _sortStrategy.algorithm(list);
        }
    }
}
