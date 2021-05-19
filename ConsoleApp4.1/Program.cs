using System;

var result = Console.ReadLine() switch
{
    "ясный" => "bright / clear",
    "солнечный" => "sunny",
    "теплый" => "warm",
    "прохладный" => "chilly",
    "облачный" => "cloudy",
    "холодный" => "cold",
    "луна" => "moon",
    "небо" => "sky",
    "звезда" => "star",
    "шторм" => "storm",
    "ветер" => "wind",
    _ => "такого слова нет",
};
Console.WriteLine(result);

