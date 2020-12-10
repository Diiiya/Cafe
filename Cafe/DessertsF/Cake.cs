using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class Cake
    {
        private List<object> parts = new List<object>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public string GetParts()
        {
            string listOfParts = string.Empty;

            for (int i = 0; i < parts.Count; i++)
            {
                listOfParts += parts[i] + ", ";
            }

            listOfParts = listOfParts.Remove(listOfParts.Length - 2);

            return "Cake characteristics: " + listOfParts;
        }
    }
}
