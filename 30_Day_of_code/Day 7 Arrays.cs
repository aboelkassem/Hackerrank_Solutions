using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {



    static void Main(string[] args) {
        Console.ReadLine();

        var str = Console.ReadLine();
        var arr = str.Split(' ');

        Array.Reverse(arr);

        foreach (var num in arr)
        {
            Console.Write($"{num} ");
        }
    }
}
