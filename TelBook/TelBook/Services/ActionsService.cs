using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelBook.Services
{
    internal class ActionsService<T>
    {
        public void Compare(Dictionary<int, string> dictionary, List<T> list)
        {
            if (dictionary != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int count = 0;

                    foreach (string item in dictionary.Values)
                    {
                        string ch = list[i].ToString();

                        if (item.StartsWith(ch))
                        {
                            if (count == 0)
                            {
                                Console.WriteLine(list[i]);
                                count++;
                            }

                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void Tag(Dictionary<int, string> dictionary, List<T> list)
        {
            Console.WriteLine("#");

            if (dictionary != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    foreach (string item in dictionary.Values)
                    {
                        if (item.StartsWith(Convert.ToChar(list[i])))
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void CompareEn(Dictionary<int, string> dictionary)
        {
            Models.Aphabeth alphabeth = new Models.Aphabeth();
            List<char> en = new List<char>();
            en = alphabeth.FillAlphabethEN();

            if (dictionary != null)
            {
                for (int i = 0; i < en.Count; i++)
                {
                    int count = 0;

                    foreach (string item in dictionary.Values)
                    {
                        if (item.StartsWith(en[i]))
                        {
                            if (count == 0)
                            {
                                Console.WriteLine(en[i]);
                                count++;
                            }

                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void CompareRu(Dictionary<int, string> dictionary)
        {
            Models.Aphabeth alphabeth = new Models.Aphabeth();
            List<char> en = new List<char>();
            en = alphabeth.FillAlphabethRU();

            if (dictionary != null)
            {
                for (int i = 0; i < en.Count; i++)
                {
                    int count = 0;

                    foreach (string item in dictionary.Values)
                    {
                        if (item.StartsWith(en[i]))
                        {
                            if (count == 0)
                            {
                                Console.WriteLine(en[i]);
                                count++;
                            }

                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void CompareNUM(Dictionary<int, string> dictionary)
        {
            Models.Aphabeth alphabeth = new Models.Aphabeth();
            List<int> num = new List<int>();
            num = alphabeth.FillNum();

            if (dictionary != null)
            {
                for (int i = 0; i < num.Count; i++)
                {
                    int count = 0;

                    foreach (string item in dictionary.Values)
                    {
                        string ch = num[i].ToString();
                        if (item.StartsWith(ch))
                        {
                            if (count == 0)
                            {
                                Console.WriteLine(ch);
                                count++;
                            }

                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void TagEN(Dictionary<int, string> dictionary)
        {
            Models.Aphabeth alphabeth = new Models.Aphabeth();
            List<char> en = new List<char>();
            en = alphabeth.FillAlphabethEN();

            Console.WriteLine("#");

            if (dictionary != null)
            {
                for (int i = 0; i < en.Count; i++)
                {
                    foreach (string item in dictionary.Values)
                    {
                        if (item.StartsWith(en[i]))
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        public void TagRU(Dictionary<int, string> dictionary)
        {
            Models.Aphabeth alphabeth = new Models.Aphabeth();
            List<char> en = new List<char>();
            en = alphabeth.FillAlphabethRU();

            Console.WriteLine("#");

            if (dictionary != null)
            {
                for (int i = 0; i < en.Count; i++)
                {
                    foreach (string item in dictionary.Values)
                    {
                        if (item.StartsWith(en[i]))
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}
