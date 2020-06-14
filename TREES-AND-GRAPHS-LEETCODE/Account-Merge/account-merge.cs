using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class NumMatrix
    {
        public class DSU
        {
            int[] parent;
            public DSU()
            {
                parent = new int[10001];
                for (int i = 0; i < 10001; i++)
                {
                    parent[i] = i;
                }
            }

            public int find(int x)
            {
                if (parent[x] != x)
                {
                    parent[x] = find(parent[x]);
                }
                return parent[x];
            }

            public void union(int x, int y)
            {
                parent[find(x)] = find(y);
            }
        }
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            DSU dsu = new DSU();
            var emailToName = new Dictionary<string, string>();
            var emailToID = new Dictionary<string, int>();
            int id = 0;
            foreach(IList<string> account in accounts)
            {
                string name = "";
                foreach (string email in account)
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
                    dsu.union(emailToID.GetValueOrDefault(account[1]), emailToID.GetValueOrDefault(email));
                }
            }

            var ans = new Dictionary<int, List<string>>();
            foreach ( string email in emailToName.Keys)
            {
                int index = dsu.find(emailToID.GetValueOrDefault(email));
                if (!ans.ContainsKey(index))
                {
                    var dd = new List<string>();
                    dd.Add(email);
                    ans.Add(index, dd);
                }
            }

            foreach (IList<string> component in ans.Values)
            {
                _ = component.OrderBy(x => x);
                component.Add(emailToName.GetValueOrDefault(component[0]));
            }

            // getting the return data
            IList<IList<string>> output = new List<IList<string>>();
            foreach (var d in ans.Values)
            {
                if (!output.Contains(d))
                {
                    output.Add(d);
                }
            }
            return output;
        }
    }
}
