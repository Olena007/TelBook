using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelBook.Models
{
    internal class Aphabeth
    {
        public List<char> alphabethru = new List<char>();

        public List<char> alphabethen = new List<char>();

        public List<int> nums = new List<int>();

        public List<char> FillAlphabethEN()
        {
            char ch;
            for (int i = 65; i < 91; i++)
            {
                ch = System.Convert.ToChar(i);
                this.alphabethen.Add(ch);
            }
            return this.alphabethen;
        }

        public List<char> FillAlphabethRU()
        {
            for (char i = 'А'; i <= 'Я'; i++)
            {
                this.alphabethru.Add(i);
            }
            return this.alphabethru;
            //char ch;
            //for (int i = 128; i < 160; i++)
            //{
            //    ch = System.Convert.ToChar(i);
            //    this.alphabeth.Add(ch);
            //}
            //return this.alphabeth;
        }

        public List<int> FillNum()
        {
            int num;

            for (int i = 0; i < 10; i++)
            {
                num = i;
                this.nums.Add(num);
            }

            return this.nums;
        }
    }
}
