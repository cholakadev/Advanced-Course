namespace GenericSwapMethod
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericSwap<T>
    {
        public List<T> Data { get; set; }

        public GenericSwap()
        {
            this.Data = new List<T>();
        }

        public void Swap(int index1, int index2)
        {
            T tempValue = this.Data[index1];
            this.Data[index1] = this.Data[index2];
            this.Data[index2] = tempValue;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var value in Data)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }
    }
}
