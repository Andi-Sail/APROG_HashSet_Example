using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW05_HashSet_Example
{
    class Person
    {
        static private HashSet<int> existingKeys = new HashSet<int>();
        static private Random rnd = new Random();

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int SecretKey { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// assigns a new unique random key to the person and adds it to the existing keys
        /// </summary>
        /// <param name="firstname">The firstname.</param>
        /// <param name="lastname">The lastname.</param>
        public Person(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;

            do
            {
                this.SecretKey = rnd.Next();
            } while (existingKeys.Contains(this.SecretKey));

            existingKeys.Add(this.SecretKey);
        }
    }
}
