using System;

namespace SampleLibrary
{
    public class SampleClass
    {
        public string ToLowerInvariant(string text)
        {
            return text.ToLowerInvariant();
        }

        public string Inverse(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
