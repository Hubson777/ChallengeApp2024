﻿using ChallengeApp2024;

var employee = new Employee("Hubert", "Głos", 28);
employee.AddGrade("2");
employee.AddGrade(10);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWitFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("Statystyki w pętli foreach");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("Statystyki w pętli For");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("Statystyki w pętli Do While");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("Statystyki w pętli While");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");