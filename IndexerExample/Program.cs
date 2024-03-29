﻿using System;

namespace IndexerExample
{
    class Program
    {
        static void DayExample()
        {
            var days = new DayCollection();

            var dayShortName = "Пн";
            var dayFoolName = "Понедельник";
            
            var dayNumberShortName = days[dayShortName];
            var dayNumberFoolName = days[dayFoolName];

            Console.WriteLine($"Номер дня:");
            Console.WriteLine($"\"{dayShortName}\" - {dayNumberShortName}");
            Console.WriteLine($"\"{dayFoolName}\" - {dayNumberFoolName}");
        }

        static void LinesExample()
        {
            var lines = new LinesCollection();
            lines.Add("iPhone");
            lines.Add("Samsung");

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            
            // Пример ошибочной строки
            // Console.WriteLine(lines[2]);
        }

        static void DocumentMotionsExample()
        {
            var doc = new Document();
            doc.Motions.Add("Движение 1");
            doc.Motions.Add("Движение 2");
            
            Console.WriteLine($"Движений в документе \"{doc.Number}\": {doc.Motions.Count}");
        }
        
        static void Main(string[] args)
        {
            DayExample();
            LinesExample();
            DocumentMotionsExample();
            
            Console.ReadLine();
        }
    }
}