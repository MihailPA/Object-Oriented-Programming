//Problem 3. Range Exceptions
//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;

namespace _03.RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
         where T : IComparable<T>
    {
        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }

        public T End { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format("Value is out of the  range [{0} - {1}]", this.Start, this.End);
            }
        }
    }
}
