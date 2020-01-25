using System.Collections.Generic;
using UnityEngine;

namespace BaseLibrary.DataContainers
{
    public abstract class RuntimeCollection<T> : ScriptableObject
    {
        private List<T> Items = new List<T>();

        protected void Add(T t)
        {
            if (!Items.Contains(t))
            {
                Items.Add(t);

            }
          

        }
        protected void Remove(T t)
        {
            if (Items.Contains(t))
            {
                Items.Remove(t);

            }
           

        }
    }


}