namespace SampleOldExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleClassInstance = new SampleLibrary.SampleClass();
            var result = sampleClassInstance.ToLowerInvariant("qWertY");
        }
    }
}
