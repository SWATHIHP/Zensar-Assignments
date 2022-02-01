using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27thPrj
{
    class Authors
    {
        private string[] namesOfAuthor = new string[3];
        private string publisherName;
        //defining indexer
        public string this[int flag]
        {
            get
            {
                string temp = namesOfAuthor[flag];//or
                //return namesOfAuthor[flag];
                return temp;

            }
            set
            {
                namesOfAuthor[flag] = value;
            }
        }
        public string this[string flag]
        {
            get
            {
                string temp = namesOfAuthor[2];
                return temp;
            }

            set { namesOfAuthor[2] = value; }
        }
        public string this[float f]
        {
            get
            {
                string temp = namesOfAuthor[2];
                return temp;
            }

            set { namesOfAuthor[2] = value; }
        }
        //property declaration for publisher name
        public string Publisher
        {
            get { return publisherName; }
            set { publisherName = value; }
        }
    }
    class IndexersEg2
    {
        static void Main()
        {
            Authors authors = new Authors();
            authors[0] = "Paulo Coehlo";
            authors[1] = "Randy Pausch";
            authors[2] = "Jason Zaslow";
            authors.Publisher = "Royal Press";
            Console.WriteLine($"The three famous authors are{authors[0]},{authors[1]},{authors[2]} Publishing their novels through{authors.Publisher}");
            authors["0"] = "Felix Mallard";
            Console.WriteLine(authors["0"]);
            authors[1.0f] = "Felix Lee";
            Console.WriteLine(authors[1.2f]);
            Console.Read();
        }
    }
}
