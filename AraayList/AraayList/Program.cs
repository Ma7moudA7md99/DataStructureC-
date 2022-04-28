using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AraayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList grades = new ArrayList();
            Console.WriteLine("--------------Add Method---------------");
            grades.Add(100);
            grades.Add(84);
            int position;
            position = grades.Add(77);
            Console.WriteLine("The grade 77 was at position:" + position);
            Console.WriteLine("----------Calc Average---------------");
            int total = 0;
            double average = 0.0;
            foreach (object grade in grades)
                total += (int)grade;
            average = total / grades.Count;
            Console.WriteLine("The average grade is: " + average);
            // Console.WriteLine("------------Insert Method---------------");
            grades.Insert(1, 99);
            grades.Insert(3, 80);
            Console.WriteLine("------------Count & Capacity---------------");
            Console.WriteLine("The current capacity of grades is: " + grades.Capacity);
            Console.WriteLine("The number of grades in grades is: " + grades.Count);
            Console.WriteLine("------------Containes & Remove---------------");
            if (grades.Contains(54))
                grades.Remove(54);
            else
                Console.WriteLine("Object not in ArrayList");
            Console.WriteLine("------------RemoveAt Method---------------");
            int pos;
            pos = grades.IndexOf(77);
            grades.RemoveAt(pos); */
            Console.WriteLine("------------Names ArrayList---------------");
            ArrayList names = new ArrayList();
            names.Add("Mike");
            names.Add("Beate");
            names.Add("Raymond");
            names.Add("Bernica");
            names.Add("Jennifer");
            Console.WriteLine("The origine list of names: ");
            foreach (object name in names) 
                Console.WriteLine(name);
            Console.WriteLine();
            //************************
            string[] newNames = new string[] {"David", "Michael"};
            ArrayList moreNames = new ArrayList();
            moreNames.Add("Terrill");
            moreNames.Add("Donnie");
            moreNames.Add("Mayo");
            moreNames.Add("Clayton");
            moreNames.Add("Alisa");
            names.InsertRange(0, newNames);
            names.AddRange(moreNames);
            Console.WriteLine("The new list of names: ");
            foreach (object name in names)
                Console.WriteLine(name);
            
            ArrayList someNames = new ArrayList();
            someNames = names.GetRange(2, 4);
            Console.WriteLine("someNames sub-ArrayList: ");
            foreach (object name in someNames)
                Console.WriteLine(name);

            // ToArrat()
            object[] arrNames;
            arrNames = names.ToArray();
            Console.WriteLine("Names from an array: ");
            for (int i = 0; i < arrNames.GetUpperBound(0); i++)
                Console.WriteLine(arrNames[i]);
        }   

    }
}
