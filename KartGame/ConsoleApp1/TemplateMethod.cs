﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class AbstractDisplay
    {
        public abstract void Open();
        public abstract void Print();
        public abstract void Close();

        public void Display()
        {
            Open();
            for (int i = 0; i < 3; i++)
            {
                Print();
            }
            Close();
        }
    }
    public class CharDisplay : AbstractDisplay
    {
        char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        public override void Open()
        {
            Console.Write("***");
        }

        public override void Print()
        {
            Console.Write(ch);
        }

        public override void Close()
        {
            Console.WriteLine("***");
        }
    }
    public class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;
        public StringDisplay(string str)
        {
            this.str = str;
            this.width = str.Length;
        }
        void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine("|" + str + "|");
        }
        public override void Close()
        {
            PrintLine();
        }
    }
}