using System;
using System.Security.Cryptography.X509Certificates;
class Program
    {
        public static void Main()
        {
            var newfile = "C:/Users/hitti/Downloads/input.txt";
            var readfile = File.ReadLines(newfile);
            double answer = 0;
            foreach (var line in readfile)
            {
                List<double>  myList = new List<double>();
                foreach (char letter in line)
                {
                    if (char.IsNumber(letter) == true)
                    {
                        double numericValue = char.GetNumericValue(letter);
                        myList.Add(numericValue);
                    }
                    else 
                    {
                        //code for if character is a letter and not a number
                    }
                }
                int size = myList.Count;
                if (size == 1)
                {
                    string combined = myList[0].ToString() + myList[0].ToString();
                    var finished = double.Parse(combined.ToString());
                    answer += finished;
                }
                else
                {
                    string combined = myList[0].ToString() + myList[size-1].ToString();
                    var finished = double.Parse(combined.ToString());
                    answer += finished;
                }

            }
            Console.WriteLine(answer);
        }
    }