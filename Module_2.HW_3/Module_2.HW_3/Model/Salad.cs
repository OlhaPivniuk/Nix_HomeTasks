using Module_2.HW_3.Interface;
using Module_2.HW_3.Breaker;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_2.HW_3.Model
{
    public class Salad : IReadFiles, IWriteToFiles
    {
        List<Vegetable> _salad = new List<Vegetable>();
        internal List<Vegetable> _Salad { get => _salad; set => _salad = value; }
        public void ReadingFile(string fileName)
        {
            string str;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    string[] words = LineBreaker.WordsArr(' ', str, 0);
                    _Salad.Add(new Vegetable(words[0], words[1], words[2], words[3]));
                }
            }
        }
        public override string ToString()
        {
            string str = String.Empty;
            foreach (var element in _Salad)
            {
                str += element.ToString() + "\r\n";
            }
            return str;
        }
        public void WriteToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(ToString());
                writer.WriteLine("Calories in salad: " + СountСalories());
            }
        }
        public int СountСalories()
        {
            int _caloricity = 0;
            foreach (Vegetable vegatable in _Salad)
            {
                _caloricity += vegatable.Caloricity;
            }
            return _caloricity;
        }
    }
}
