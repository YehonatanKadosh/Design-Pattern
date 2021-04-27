using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Example of Composite is Humans
            // Each individual can get to the other using his children or parents
            Human Adam = new Human("Adam", null, null);
            Human Eve = new Human("Eve", null, null);
            Human Cain = new Human("Cain", Adam, Eve);
            Human Abel = new Human("Abel", Adam, Eve);
            Human Seth = new Human("Seth", Adam, Eve);
            Human Enoch = new Human("Enoch", Cain, null);
            Human Enos = new Human("Enos", Seth, null);
            Console.WriteLine(Seth.ToString());

            // Another example of composite is the FileSystem that allows you to move between Directories
            // this way you can go to every file from every directory 
            // going up "To the Parent directory" or down to the Childrens
            
            // Another example of composite is Xaml where it's built from UIElements
            // Every Element contained within the Form "parent" and they can get talk to each other
            // the Form have A Children property that allows them to interract one another
        }
    }
}
