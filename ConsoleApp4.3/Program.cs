using System;

var n = int.Parse(Console.ReadLine());

var res = "";

if (n < 0 || n > 100)
    res = "Unknown";
else if (n > 49)
    res = "50-100";
else if (n > 35)
    res = "36-49";
else if (n > 14)
    res = "15-35";
else res = "0-14";

Console.WriteLine(res);

