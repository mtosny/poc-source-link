namespace SampleExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleClassInstance = new SampleLibrary.SampleClass();
            sampleClassInstance.ToLowerInvariant("qwerty");
        }
    }
}
