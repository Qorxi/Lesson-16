using System;
using System.Collections.Generic;
using System.Xml;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List class

            //List<string> listCollection = new List<string>();
            //listCollection.Add("c#");
            //listCollection.Add("java");
            //listCollection.Add("python");
            //listCollection.Add("c++");


            //Console.WriteLine("--------------- List all elements -------------");
            //foreach (var item in listCollection)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("----------------- Remove method ------------");
            //if (listCollection.Remove("python"))
            //{
            //    Console.WriteLine("python is removed in list");
            //}


            //listCollection.RemoveAt(1);

            //Console.WriteLine("-------------- Insert method after removeAt method  -------------");
            //listCollection.Insert(1, "new java");
            //foreach (var item in listCollection)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("---------- Find method ---------");
            //var strFind = listCollection.Find(item => item.Length == 2);
            //Console.WriteLine(strFind);

            //Console.WriteLine("--------  FindAll method -------------");
            //var findAll = listCollection.FindAll(item => item.Length > 2);

            //foreach (var item in findAll)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("------------- FindLast --------");
            //var findLast = listCollection.FindLast(item => item.EndsWith("on"));
            //Console.WriteLine(findLast);


            //Console.WriteLine("----------- Index of ------------");
            //var index = listCollection.IndexOf("c#");
            //Console.WriteLine(index);

            #endregion

            #region      HashSet class

            //HashSet<string> hashString = new HashSet<string>();
            
            //hashString.Add("man");
            //hashString.Add("woman");
            //hashString.Add("chield");
            //hashString.Add("grandfather");
            //hashString.Add("grandmother");


            //Console.WriteLine("------------ HashSet element ----------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}


            //hashString.ExceptWith(new string[] { "man", "chield", "father" });

            //Console.WriteLine("----------- Element removed except method ------------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}

            //hashString.IntersectWith(new string[] { "woman", "grandfather" });
            //Console.WriteLine("---------- Intersect ------------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}


            //hashString.UnionWith(new string[] { "mark", "hanry", "spar" });

            //Console.WriteLine("---------------- Union method --------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);         
            //}

            //Console.WriteLine("------------ IsProperSubsetof ------------");
            //if (hashString.IsProperSubsetOf(new string[] { "mark", "hanry" }))
            //{
            //    Console.WriteLine("Is propersubset of");
            //}
            //else
            //{ Console.WriteLine("Is not propersubset of"); }


            //Console.WriteLine("---------- IsProperSupersetof -----------");
            //if (hashString.IsProperSupersetOf(new string[] { "mark"}))
            //{
            //    Console.WriteLine("Mark string is supersut of hashstring");
            //}

            //Console.WriteLine("------------- Overlaps method ---------------");
            //if (hashString.Overlaps(new string[] { "fath", "pen", "small", "grandfather" }))
            //{
            //    Console.WriteLine("overlaps method is find");
            //}


            //Console.WriteLine("------------------ Symmetric except method -------------");
            //hashString.SymmetricExceptWith(new string[] { "father", "grandfather", "new symmetric element" });


            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}


            Console.WriteLine();


            #endregion

            #region     SortedSet class

            //SortedSet<string> hashString = new SortedSet<string>();

            //hashString.Add("man");
            //hashString.Add("woman");
            //hashString.Add("chield");
            //hashString.Add("grandfather");
            //hashString.Add("grandmother");


            //Console.WriteLine("------------ SortedSet element ----------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}


            //hashString.ExceptWith(new string[] { "man", "chield", "father" });

            //Console.WriteLine("----------- Element removed except method ------------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}

            //hashString.IntersectWith(new string[] { "woman", "grandfather" });
            //Console.WriteLine("---------- Intersect ------------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}


            //hashString.UnionWith(new string[] { "mark", "hanry", "spar" });

            //Console.WriteLine("---------------- Union method --------");
            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("------------ IsProperSubsetof ------------");
            //if (hashString.IsProperSubsetOf(new string[] { "mark", "hanry" }))
            //{
            //    Console.WriteLine("Is propersubset of");
            //}
            //else
            //{ Console.WriteLine("Is not propersubset of"); }


            //Console.WriteLine("---------- IsProperSupersetof -----------");
            //if (hashString.IsProperSupersetOf(new string[] { "mark" }))
            //{
            //    Console.WriteLine("Mark string is supersut of hashstring");
            //}

            //Console.WriteLine("------------- Overlaps method ---------------");
            //if (hashString.Overlaps(new string[] { "fath", "pen", "small", "grandfather" }))
            //{
            //    Console.WriteLine("overlaps method is find");
            //}


            //Console.WriteLine("------------------ Symmetric except method -------------");
            //hashString.SymmetricExceptWith(new string[] { "father", "grandfather", "new symmetric element" });


            //foreach (var item in hashString)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region      Dictionary class

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //dictionary.Add(1, "c#");
            //dictionary.Add(2, "scala");
            //dictionary.Add(3, "cobol");
            //dictionary.Add(4, "pascal");
            //dictionary.Add(5, "delphi");

            //Console.WriteLine("------------- dictionary class elements ------------");
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}


            //Console.WriteLine("------------- dictionary tryad method ----------");
            //if (dictionary.TryAdd(5, "beshinci"))
            //{
            //    dictionary.Add(5, "beshinci");
            //}
            //else
            //{
            //    Console.WriteLine("Element is found");
            //}

            //Console.WriteLine("--------------- dictionary collection values -----------------");
            //var values = dictionary.Values;

            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------- dictionary before trim ------------");
            //Console.WriteLine(dictionary.Count);
            //dictionary.TrimExcess(5);
            //Console.WriteLine("----------------- dictionary after trim ----------");
            //Console.WriteLine(dictionary.Count);


            #endregion

            var result = BasicOperation(36, 9);

            Console.WriteLine("Cemi : " + result.Item1);
            Console.WriteLine("Minusu : " + result.Item2);
            Console.WriteLine("Bolmesi : " + result.Item3);
            Console.WriteLine("Vurmasi : " + result.Item4);
           

            Console.ReadKey();
        }

        static Tuple<int, int, double, int> BasicOperation(int number1, int number2)
        {
            return Tuple.Create(number1 + number2, number1 - number2, (double)number1 / number2, number2 * number1);
        }
    }
}

