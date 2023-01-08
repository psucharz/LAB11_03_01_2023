using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11_03_01_2023
{
    public class Triple<T> where T : IComparable<T>
    {
        public Triple(T a, T b, T c)
        {
            A = a;
            B = b;
            C = c;
        }

        public T A
        { get; set; }
        public T B
        { get; set; }
        public T C
        { get; set; }

        public override string ToString()
        {
            return $"({A} , {B} , {C})";
        }

        public T this[int index]
        {
            get
            {
                if (index == 0)
                    return A;
                else if (index == 1)
                    return B;
                else if (index == 2)
                    return C;
                else
                    throw new IndexOutOfRangeException($"No element in {this.GetType()} with given index");
            }
            set
            {
                if (index == 0)
                    A = value;
                else if (index == 1)
                    B = value;
                else if (index == 2)
                    C = value;
                else
                    throw new IndexOutOfRangeException($"No element in {this.GetType()} with given index");
            }
        }

        public void Sort()
        {
            if (A.CompareTo(B) > 0)
                (B, A) = (A, B);
            if (B.CompareTo(C) > 0)
                (C, B) = (B, C);
            if (A.CompareTo(C) > 0)
                (C, A) = (A, C);
        }
    }
}
