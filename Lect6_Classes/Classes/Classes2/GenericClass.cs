using System;
using System.Collections.Generic;

namespace Classes2
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        private List<T> elements;

        public GenericList(int capacity = 4)
        {
            this.elements = new List<T>(capacity);
        }

        public void AddElement(List<T> elements, T elem)
        {
            elements.Add(elem);
        }
        public void AccessElemByIndex(List<T> elements, T elem)
        {
            elements.IndexOf(elem);
        }

        public void RemoveElemByIndex(List<T> elements, T elem)
        {
            elements.Remove(elem);
        }

        public void InsertElemAtPosition(List<T> elements, T elem, int position)
        {
            elements.Insert(position, elem);
        }

        public void ClearTheList(List<T> elements)
        {
            elements.Clear();
        }

        public void FindElementByValue(List<T> elements, T elem)
        {
            elements.IndexOf(elem);
        }
        public override string ToString()
        {
            return string.Join(", ",elements.ToArray());
        }
       
    }
}
