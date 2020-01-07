using System.Collections.Generic;
using UnityEngine;

namespace BaseLibrary.Data
{
    public abstract class RuntimeCollection<T> : ScriptableObject
    {
        public List<T> Items = new List<T>();

        public void Add(T t)
        {
            if (!Items.Contains(t))
            {
                Items.Add(t);

            }
            else
            {

            }

        }
        public void Remove(T t)
        {
            if (Items.Contains(t))
            {
                Items.Remove(t);

            }
            else
            {


            }

        }
    }


}