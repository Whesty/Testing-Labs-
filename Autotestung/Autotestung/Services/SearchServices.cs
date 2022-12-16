using Autotestung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Services
{
    internal static class SearchServices
    {
        private static String SearchTest = "Туфли";
        private static String SearchTestErrors = "вчсапмиртоль";
        
        public static Search WithSearchFromProperty()
        {
            return new Search(SearchTest, false);
        }
        public static Search WithSearchErrorsFromProperty()
        {
            return new Search(SearchTestErrors, true);
        }
        public static Search WithEmptySearch()
        {
            return new Search("", true);
        }
    }
}
