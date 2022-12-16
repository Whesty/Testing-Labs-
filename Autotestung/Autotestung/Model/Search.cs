using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Model
{
    internal class Search
    {
        public String SearchTest { get; private set; }
        public bool SearchTestErrors { get; private set; }

        public Search(String searchTest, bool searchTestErrors)
        {
            SearchTest = searchTest;
            SearchTestErrors = searchTestErrors;
        }
    }
}
