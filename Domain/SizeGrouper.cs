using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class SizeGrouper
    {
        private readonly int _groupSize;
        public SizeGrouper(int groupSize)
        {
            _groupSize = groupSize;
        }

        public IList<IList<Site>> Group(IList<Site> sites)
        {
            var result = new List<IList<Site>>();
            int startIndex = 0;

            while (startIndex < sites.Count)
            {
                var group = sites.Skip(startIndex).Take(_groupSize).ToList();
                result.Add(group);

                startIndex += _groupSize;
            }

            return result;
        }

    }
}
