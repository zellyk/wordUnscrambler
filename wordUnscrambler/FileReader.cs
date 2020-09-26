using System.IO;

namespace wordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            // Implement this uusing info from the slides.
            string[] words;

            words = File.ReadAllLines(filename);


            return words;
        }

    }
}
