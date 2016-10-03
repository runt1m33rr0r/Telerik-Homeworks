namespace GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException("The index is too bit!");
                }

                if (index < 0)
                {
                    throw new IndexOutOfRangeException("The index can not be negative!");
                }

                return this.elements[index];
            }
        }

        public void Add(T element)
        {
            this.CheckAndIncreaseCapacity(this.count);

            if (this.count >= this.elements.Length)
            {
                throw new IndexOutOfRangeException("Index exceed the list capacity!");
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public void AddAtPosition(T element, int index)
        {
            this.CheckAndIncreaseCapacity(index);

            if (index < this.count)
            {
                for (int i = this.count; i > index; i--)
                {
                    this.elements[this.count] = this.elements[this.count - 1];
                }
            }

            this.elements[index] = element;

            this.count++;
        }

        public void RemoveAt(int index)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException("Such element does not exist!");
            }

            if (index < 0)
            {
                throw new IndexOutOfRangeException("The index can not be negative!");
            }

            if (index <= this.count)
            {
                for (int i = index; i < this.count - 1; i++)
                {
                    this.elements[index] = this.elements[index + 1];
                }
            }

            this.count--;
        }

        public void Clear()
        {
            this.count = 0;
        }

        public int Find(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (element.Equals(this.elements[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (min.CompareTo(this.elements[i]) > 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (max.CompareTo(this.elements[i]) < 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.count == 0)
            {
                return "no elements in list";
            }

            for (int i = 0; i < this.count; i++)
            {
                result.Append(string.Format("{0} ", this.elements[i]));
            }

            return result.ToString();
        }

        private void CheckAndIncreaseCapacity(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("The index can not be negative!");
            }

            if (index > this.elements.Length - 1)
            {
                T[] newElements = new T[this.elements.Length * 2];

                for (int i = 0; i < this.elements.Length; i++)
                {
                    newElements[i] = this.elements[i];
                }

                this.elements = newElements;
            }

            if (index > this.count)
            {
                throw new IndexOutOfRangeException(string.Format("Index should be not bigger than {0}!", this.count));
            }
        }
    }
}
