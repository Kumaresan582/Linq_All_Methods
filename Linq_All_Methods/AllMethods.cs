namespace Linq_All_Methods
{
    public class English2German
    {
        public string NumberWords { get; set; }
        public int Number { get; set; }
    }

    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Person
    {
        public int LanguageId { get; set; }
        public string FirstName { get; set; }
    }

    public class Car
    {
        public string Name { get; set; }
        public int HorsePower { get; set; }
    }

    public class Persons
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class AllMethods
    {
        public static void Aggregate_Simple()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }

        public static void Aggregate_Seed()
        {
            var scores = new int[] { 85, 90, 95 };

            var totalScore = scores.Aggregate(50, (seed, score) => seed + score);

            Console.WriteLine("\nTotal score of the student with a seed of 50:");
            Console.WriteLine(totalScore);
        }

        public static void Average()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("\nAverage is:");
            Console.WriteLine(result);
        }

        public static void _Count()
        {
            string[] names = { "Ram", "Sam", "Ravi", "Ranjith", "Hari" };

            var result = names.Count();

            Console.WriteLine("\nCounting names gives:");
            Console.WriteLine(result);
        }

        public static void _Max()
        {
            int[] number = { 3, 34, 5, 12, 67, 43, 23, 89 };
            var result = number.Max();
            Console.WriteLine("\nThe Highest is ");
            Console.WriteLine(result);
        }

        public static void _Min()
        {
            int[] number = { 51, 4, 8, 51, 218, 5, 4, 78 };
            var result = number.Min();
            Console.WriteLine("\nThe Lowest is ");
            Console.WriteLine(result);
        }

        public static void _Sum()
        {
            int[] number = { 45, 21, 78, 65, 23, 84, 23, 12, 78 };
            var result = number.Min();
            Console.WriteLine("\nThe Sum is ");
            Console.WriteLine(result);
        }

        public static void simple_AsEnumerable()
        {
            string[] names = { "Kishore", "Vijay", "Ajith", "Sridhar" };
            var result = names.AsEnumerable();
            Console.WriteLine("\nIEnumerable Collection");
            foreach (var name in result)
                Console.WriteLine(name);
        }

        public static void simple_Cast()
        {
            List<string> Vegetable = new List<string> { "Carrot", "Beans", "Tomato", "LadysFinger" };
            var result = Vegetable.Cast<string>();
            Console.WriteLine("\nList of vegetables casted to a simple string array:");
            foreach (var name in result)
                Console.WriteLine(name);
        }

        public static void Sample_OfType()
        {
            object[] objects = { "Kavin", 31, 5.02, null, "Chandru" };
            var result = objects.OfType<string>();
            Console.WriteLine("\nObjects being of type string have the values:");
            foreach (string str in result)
                Console.WriteLine(str);
        }

        public static void Sample_ToDictionary()
        {
            English2German[] english2German =
            {
                new English2German { NumberWords = "One", Number = 1 },
                new English2German { NumberWords = "Two", Number = 2 },
                new English2German { NumberWords = "Three", Number = 3 },
            };
            var result = english2German.ToDictionary(k => k.NumberWords, v => v.Number);
            Console.WriteLine("\nValues inserted into dictionary:");
            foreach (KeyValuePair<string, int> dic in result)
                Console.WriteLine("Number Words {0} is {1} in number", dic.Key, dic.Value);
        }

        public static void Sample_ToDictionary_Conditional()
        {
            int[] numbers = { 45, 87, 51, 84, 62, 81, 49, 151, 42, 35 };
            var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");
            Console.WriteLine("\nNumbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
        }

        public static void Sample_ToLookup()
        {
            string[] words = { "one", "two", "three", "four", "five", "six", "seven" };
            var result = words.ToLookup(w => w.Length);
            Console.WriteLine("\nToLookup:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Elements with a length of {0}:", i);
                foreach (string word in result[i])
                    Console.WriteLine(word);
            }
        }

        public static void Sample_ElementAt()
        {
            string[] words = { "One", "Two", "Three" };
            var result = words.ElementAt(2);
            var resultIndex1 = words.ElementAtOrDefault(1);
            var resultIndex10 = words.ElementAtOrDefault(10);
            Console.WriteLine("\nElementAt:");
            Console.WriteLine("Element at index 1 in the array is:");
            Console.WriteLine(result);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }

        public static void Sample_FirstOrDefault()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };
            string[] empty = { };
            var result = countries.First(c => c.Length == 6);
            var result1 = countries.FirstOrDefault();
            var resultEmpty = empty.FirstOrDefault();

            Console.WriteLine("\nFirstOrDefault:");
            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(result);

            Console.WriteLine("First element in the countries array contains:");
            Console.WriteLine(result1);

            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }

        public static void Sample_LastOrDefault_Conditional()
        {
            string[] words = { "one", "two", "three" };
            string[] empty = { };

            var result = words.LastOrDefault(w => w.Length == 3);

            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            var result1 = words.LastOrDefault();

            var resultEmpty = empty.LastOrDefault();

            Console.WriteLine("\nLastOrDefault:");
            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result1);

            Console.WriteLine("Last element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);
        }

        public static void Sample_SingleOrDefault()
        {
            string[] names1 = { "Sabesan" };
            string[] names3 = { "Karthi", "Kishore", "Radha" };
            string[] empty = { };
            var result1 = names1.SingleOrDefault();
            var resultEmpty = empty.SingleOrDefault();

            Console.WriteLine("\nSingleOrDefault:");
            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty == null);

            try
            {
                var result3 = names3.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Sample_DefaultIfEmpty()
        {
            string[] emptyStr = { };
            int[] emptyInt = { };
            string[] words = { "one", "two", "three" };

            var resultStr = emptyStr.DefaultIfEmpty();
            var resultInt = emptyInt.DefaultIfEmpty();
            var resultWords = words.DefaultIfEmpty();

            Console.WriteLine("\nDefaultIfEmpty:");
            Console.WriteLine("resultStr has one element with a value of null:");
            Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);

            Console.WriteLine("resultInt has one element with a value of 0:");
            Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);

            Console.WriteLine("resultWords has same content as words array:");
            Console.WriteLine(resultWords.SequenceEqual(words));
        }

        public static void Sample_Range()
        {
            var result = Enumerable.Range(0, 10);

            Console.WriteLine("\nRange:");
            Console.WriteLine("Counting from 0 to 9:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        public static void Sample_GroupBy()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35 };
            var result = numbers.GroupBy(n => (n % 10 == 0));

            Console.WriteLine("GroupBy has created two groups:");
            foreach (IGrouping<bool, int> group in result)
            {
                if (group.Key == true)
                    Console.WriteLine("Divisible by 10");
                else
                    Console.WriteLine("Not Divisible by 10");

                foreach (int number in group)
                    Console.WriteLine(number);
            }
        }

        public static void Sample_GroupJoin()
        {
            Language[] languages = new Language[]
            {
                new Language {Id = 1, Name = "English"},
                new Language {Id = 2, Name = "Tamil"}
            };

            Person[] persons = new Person[]
            {
                new Person { LanguageId = 1, FirstName = "Tom" },
                new Person { LanguageId = 1, FirstName = "Sandy" },
                new Person { LanguageId = 2, FirstName = "Amir" },
                new Person { LanguageId = 2, FirstName = "Sekar" },
            };

            var result = languages.GroupJoin(persons, lang => lang.Id, pers => pers.LanguageId,
                (lang, ps) => new { Key = lang.Name, Persons = ps });

            Console.WriteLine("\nGroup-joined list of people speaking either English or Tamil:");
            foreach (var language in result)
            {
                Console.WriteLine("Persons speaking {0}:", language.Key);

                foreach (var person in language.Persons)
                {
                    Console.WriteLine(person.FirstName);
                }
            }
        }

        public static void Sample_Join()
        {
            string[] warmCountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiobia" };
            string[] europeanCountries = { "Denmark", "Germany", "Italy", "Portugal", "Spain" };

            var result = warmCountries.Join(europeanCountries, warm => warm, european => european, (warm, european) => warm);

            Console.WriteLine("\nJoined countries which are both warm and Europan:");
            foreach (var country in result)
                Console.WriteLine(country);
        }

        public static void Sample_OrderBy()
        {
            var dates = new DateTime[] {
                new DateTime(2023, 2, 15),
                new DateTime(2023, 3, 25),
                new DateTime(2023, 1, 5)
            };
            var result = dates.OrderBy(d => d);

            Console.WriteLine("\nOrdered list of dates:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }

        public static void Sample_OrderBy_Objects()
        {
            Car[] cars =
            {
                new Car { Name = "Toyato", HorsePower = 75 },
                new Car { Name = "BMW", HorsePower = 215 },
                new Car { Name = "Aadi", HorsePower = 145 },
            };
            var result = cars.OrderBy(c => c.HorsePower);

            Console.WriteLine("\nOrdered list of cars by horsepower:");
            foreach (Car car in result)
                Console.WriteLine("{0}: {1} horses", car.Name, car.HorsePower);
        }

        public static void Sample_OrderByDescending()
        {
            string[] names = { "Choto", "Ben", "Jack" };
            var result = names.OrderByDescending(n => n);

            Console.WriteLine("\nDescending ordered list of names:");
            foreach (string name in result)
                Console.WriteLine(name);
        }

        public static void Sample_ThenBy()
        {
            string[] district = { "Chennai", "Coimbatore", "Selam", "Erode", "Thirupur", "Dharmapuri" };

            var result = district.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("\nThenBy:");
            Console.WriteLine("Ordered list of district, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }

        public static void Sample_ThenByDescending()
        {
            var dates = new DateTime[] {
                new DateTime(2023, 3, 1),
                new DateTime(2021, 7, 1),
                new DateTime(2023, 5, 1),
                new DateTime(2023, 1, 1),
                new DateTime(2020, 7, 1)
            };
            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("\nList of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("dd MM yyyy"));
        }

        public static void Sample_Zip()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 10, 11, 12 };
            var result = numbers1.Zip(numbers2, (a, b) => (a * b));

            Console.WriteLine("\nUsing Zip to combine two arrays into one (1*10, 2*11, 3*12):");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        public static void Sample_SkipWhile()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };
            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("\nSkipWhile:");
            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
        }

        public static void Sample_TakeWhile()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 5);

            Console.WriteLine("\nTakeWhile");
            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        public static void Sample_select()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var rr = numbers.Select((num, Index) => new
            {
                Num = num,
                Index = Index
            }).Where(x => x.Num % 2 != 0).Select(data => new
            {
                Num = data.Num,
                Index = data.Index
            });
            foreach (var number in rr)
                Console.WriteLine(number);
        }

        public static void Sample_SelectMany()
        {
            string[] fruits = { "Grape", "Orange", "Apple" };
            int[] amounts = { 1, 2, 3 };
            var result = fruits.SelectMany(f => amounts, (f, a) => new
            {
                Fruit = f,
                Amount = a
            });

            Console.WriteLine("\nSelectMany:");
            Console.WriteLine("Selecting all values from each array, and mixing them:");
            foreach (var o in result)
                Console.WriteLine(o.Fruit + ", " + o.Amount);
        }

        public static void Sample_All_Any()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };
            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("\nAll:");
            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);

            var result1 = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("\nAny:");
            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result1);
        }

        public static void Sample_Contains()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            var result = numbers.Contains(5);

            Console.WriteLine("\nContains:");
            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }

        public static void Sample_Where_Objects()
        {
            Persons[] persons = {
                new Persons { Name = "Jack", Age = 25 },
                new Persons { Name = "Ben", Age = 43 },
                new Persons { Name = "Naruto", Age = 31 }
            };
            var result = persons.Where(p => p.Age >= 30);

            Console.WriteLine("Finding persons who are 30 years old or older:");
            foreach (Persons person in result)
                Console.WriteLine("{0}: {1} years old", person.Name, person.Age);
        }
    }
}