using System;
using Library;
using Library.Figures;
using Library.Groups;
using Microsoft.VisualBasic.CompilerServices;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            FigureCircle fc = new FigureCircle(1);
            FigureSquare fs = new FigureSquare(3);
            FigureTriangle ft = new FigureTriangle(3, 4, 5);
            
            Group gr = new Group();
            gr.Add(fs);
            
            Console.WriteLine(fc.Measure());
            Console.WriteLine(fs.Measure());
            Console.WriteLine(ft.Measure());
            
            Console.WriteLine(gr.Measure());
            
            group.Add(fc);
            group.Add(fs);
            group.Add(ft);
            group.Add(gr);
            
            
            Console.WriteLine(group.Measure());


        }
    }
}