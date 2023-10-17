// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

int[] prices = { 7,6,4,3,1};

int maxProf = 0;
int minPrice = prices[0];

foreach (int price in prices)
{
    int[] charKep = { minPrice, price };
    minPrice = charKep.Min();
    int prof = price - minPrice;
    maxProf = Math.Max(maxProf, prof);  
    Console.WriteLine("minPrice: " + minPrice + " " + "maxProf: " + maxProf + " " + "prof: " + prof);
}