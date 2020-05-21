﻿/*
https://www.codewars.com/kata/592fd8f752ee71ac7e00008a/csharp

7 kyu
Covfefe

Your are given a string. You must replace the word(s) coverage by covfefe, however, 
if you don't find the word coverage in the string, you must add covfefe at the end of the string with a leading space.

For the languages where the string is not immutable (such as ruby), 
don't modify the given string, otherwise this will break the test cases.
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataCovfefe
    {
        public static string Covfefe(string tweet)
        {
            return tweet.Contains("coverage") ? tweet.Replace("coverage", "covfefe") : $"{tweet} covfefe";
        }
    }
}