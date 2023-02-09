using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace UniqueEmailAddresses
{
    public static class UniqueEmailAddresses
    {
        public static int NumberOfUniqueEmailAddresses(string[] emails)
        {
            List<String> emailsSet = new List<String>();

            foreach(var e in emails)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < e.Length; i++)
                {
                    if (e[i] == '.')
                    {
                        continue;
                    }
                    else if (e[i] == '+')
                    {
                        int idx = e.Length - 1;
                        while (e[idx] != '@')
                        {
                            idx--;
                        }
                        sb.Append(e.Substring(idx));
                        break;
                    }
                    else
                    {
                        sb.Append(e[i]);
                    }
                }
                emailsSet.Add(sb.ToString());
            }
            List<string> uniqemails = emailsSet.Distinct().ToList();
            return uniqemails.Count;
        }
    }
}