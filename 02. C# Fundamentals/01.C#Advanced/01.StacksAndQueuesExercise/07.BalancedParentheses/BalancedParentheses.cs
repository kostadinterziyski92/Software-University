﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            char[] openParentheses = new char[] { '{', '[', '(' };

            for (int i = 0; i < input.Length; i++)
            {
                if (openParentheses.Contains(input[i]))
                {
                    stack.Push(input[i]);
                }

                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (input[i])
                    {
                        case '}':
                            if (stack.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (stack.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (stack.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
