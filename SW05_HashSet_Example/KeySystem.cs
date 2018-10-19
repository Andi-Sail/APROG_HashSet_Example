using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW05_HashSet_Example
{
    class KeySystem
    {
        private HashSet<int> whiteList;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeySystem"/> class.
        /// </summary>
        public KeySystem()
        {
            this.whiteList = new HashSet<int>();
        }

        /// <summary>
        /// Registers the new key to the whitelist.
        /// </summary>
        /// <param name="key">The key.</param>
        public void RegisterNewKey(int key)
        {
            this.whiteList.Add(key);
        }

        /// <summary>
        /// Removes the key from the whitelist.
        /// </summary>
        /// <param name="key">The key.</param>
        public void RemoveKey(int key)
        {
            this.whiteList.Remove(key);
        }

        /// <summary>
        /// Tries the open door with the given key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>true if the key is valid, otherwise false</returns>
        public bool TryOpenDoor(int key)
        {
            if (this.whiteList.Contains(key))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks the group access.
        /// </summary>
        /// <param name="groupSet">The group set.</param>
        /// <returns>true if ALL members of the group are on the white list, otherwise false</returns>
        public bool CheckGroupAccess(HashSet<int> groupSet)
        {
            if (groupSet.IsSubsetOf(this.whiteList))
            {
                return true;
            }

            return false;
        }
    }
}
