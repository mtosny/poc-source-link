using System;

namespace SampleLibrary
{
    public class SampleClass
    {
        public string ToUpperInvariant(string text)
        {
            return text.ToUpperInvariant();
        }

        public string Inverse(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
