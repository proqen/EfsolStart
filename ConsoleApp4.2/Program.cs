using System;

var operand1 = 123.0;
var operand2 = 123.0;

var sign = Console.ReadLine();

var result = sign switch
{
    "+" => (operand1 + operand2).ToString(),
    "-" => (operand1 - operand2).ToString(),
    "*" => (operand1 * operand2).ToString(),
    "/" => operand2 == 0 ? "На ноль делить нельзя!" : (operand1 / operand2).ToString(),
    _ => "Error",
};

Console.WriteLine(result);