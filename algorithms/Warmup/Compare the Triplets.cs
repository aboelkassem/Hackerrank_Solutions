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

    // Complete the compareTriplets function below.

    static List<int> compareTriplets(List<int> a, List<int> b) {

        int Alice = 0, Bob = 0;
        List<int> comparsionList = new List<int> { Alice, Bob };

        for (int i = 0; i < a.Count(); i++)
        {
            if (a[i] > b[i])
            {
                comparsionList [0]++;
            }
            else if (a[i] < b[i])
            {
                comparsionList [1]++;
            }
        }
        return comparsionList 

    }
}
