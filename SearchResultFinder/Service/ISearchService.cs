using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchResultFinder.Service
{
    public interface ISearchService
    {
        string Search(string url, string keywords);
    }
}
