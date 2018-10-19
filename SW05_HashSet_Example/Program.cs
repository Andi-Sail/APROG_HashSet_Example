using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW05_HashSet_Example
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //Init Persons
            Person richi = new Person("Richi", "Schönbächler");
            Person chuck = new Person("Chuck", "Norris");
            Person donald = new Person("Donald", "Trump");
            Person chris = new Person("Christian", "Jost");

            //Init Key System
            KeySystem hslu_TA = new KeySystem();
            //Register persons in the key system
            hslu_TA.RegisterNewKey(richi.SecretKey);
            hslu_TA.RegisterNewKey(chuck.SecretKey);
            hslu_TA.RegisterNewKey(chris.SecretKey);

            //check access for an individual person
            checkAccess(richi, hslu_TA);
            checkAccess(chuck, hslu_TA);
            checkAccess(donald, hslu_TA);
            checkAccess(chris, hslu_TA);

            Console.WriteLine();

            //Check acces for a group
            HashSet<int> swissGroup = new HashSet<int>();
            swissGroup.Add(richi.SecretKey);
            swissGroup.Add(chris.SecretKey);

            if (hslu_TA.CheckGroupAccess(swissGroup))
            {
                Console.WriteLine("The swiss group has access to HSLU");
            }
            else
            {
                Console.WriteLine("The swiss group has NO access to HSLU");
            }

            HashSet<int> americanGroup = new HashSet<int>();
            americanGroup.Add(chuck.SecretKey);
            americanGroup.Add(donald.SecretKey);

            if (hslu_TA.CheckGroupAccess(americanGroup))
            {
                Console.WriteLine("The american group has access to HSLU");
            }
            else
            {
                Console.WriteLine("The american group has NO access to HSLU");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Checks the access for the given person in the given system.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="s">The s.</param>
        static void checkAccess(Person p, KeySystem s)
        {
            if (s.TryOpenDoor(p.SecretKey))
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} can enter the door to HSLU");
            }
            else
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} can NOT enter the door to HSLU");
            }
        }
    }
}
