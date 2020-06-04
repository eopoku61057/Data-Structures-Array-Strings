/*
Given a list accounts, each element accounts[i] is a list of strings, where the first element accounts[i][0] is a name, 
and the rest of the elements are emails representing emails of the account.

Now, we would like to merge these accounts. Two accounts definitely belong to 
the same person if there is some email that is common to both accounts. Note that even if two accounts have the same name, t
hey may belong to different people as people could have the same name. A person can have any number of accounts initially, 
but all of their accounts definitely have the same name.

After merging the accounts, return the accounts in the following format: the first element of each account is the name, and 
the rest of the elements are emails in sorted order. The accounts themselves can be returned in any order.

Time Complexity: O(A \log A)
Space Complexity: O(A), the space used by our DSU structure.
 */

// NOTE: In progress, not fully done
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            DSU dsu = new DSU();
            Dictionary<string, string> emailToName = new Dictionary<string, string>();
            Dictionary<string, int> emailToID = new Dictionary<string, int>();
            int id = 0;
           
            foreach(var account in accounts)
            {
                string name = "";
                foreach(string email in account)
                {
                    if(name == "")
                    {
                        name = email;
                        continue;
                    }
                    emailToName.Add(email, name);
                    if(!emailToID.ContainsKey(email))
                    {
                        emailToID.Add(email, id++);
                    }
                    dsu.union(emailToID[email], emailToID[email]);
                }
            }

            Dictionary<int, List<string>> ans = new Dictionary<int, List<string>>();
            foreach (var email in emailToName.Keys)
            {
                int index = dsu.find(emailToID[email]);
                ans.Where(x => x.)
            }
            foreach  (List<string> component in ans.Values)
            {
                List.Enumerator(component);
                component.add(0, emailToName.get(component.get(0)));
            }
            return new ArrayList(ans.values());

        }
        public class DSU
        {
            public int[] parent;
            public DSU()
            {
                parent = new int[10001];
                for (int i = 0; i <= 10000; ++i)
                    parent[i] = i;
            }
            public int find(int x)
            {
                if (parent[x] != x) parent[x] = find(parent[x]);
                return parent[x];
            }
            public void union(int x, int y)
            {
                parent[find(x)] = find(y);
            }
        }
    }
}
