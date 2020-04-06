using FiguresLib.Figures;
using FiguresLib.Groups;
using NUnit.Framework;

namespace FiguresLibTests
{
    public class UnitTestGroups
    {
        [Test]
        public void Measure_SumItems_OnlyFigures()
        {
            FigureSquare square = new FigureSquare(3);
            FigureCircle circle = new FigureCircle(3);
            GroupSum groupSum = new GroupSum(); 
            
            groupSum.Add(square);
            groupSum.Add(circle);
            float measureItems = square.Measure() + circle.Measure();
            float measureGroup = groupSum.Measure();

            Assert.AreEqual(measureItems, measureGroup);
        }
        
        [Test]
        public void Measure_MultiplyItems_OnlyFigures()
        {
            FigureSquare square = new FigureSquare(3);
            FigureCircle circle = new FigureCircle(3);
            GroupMyltiply groupMyltiply = new GroupMyltiply(); 
            
            groupMyltiply.Add(square);
            groupMyltiply.Add(circle);
            float measureItems = square.Measure() * circle.Measure();
            float measureGroup = groupMyltiply.Measure();

            Assert.AreEqual(measureItems, measureGroup);
        }

        [Test]
        public void Measure_SumItems_FiguresAndOtherGroup()
        {
            FigureSquare square = new FigureSquare(3);
            FigureCircle circle = new FigureCircle(3);
            FigureTriangle triangle = new FigureTriangle(3, 4, 5);
            GroupSum groupSum = new GroupSum(); 
            GroupMyltiply groupMyltiply = new GroupMyltiply();
            
            groupMyltiply.Add(triangle);
            groupMyltiply.Add(square);
            groupSum.Add(groupMyltiply);
            groupSum.Add(circle);
            float measureItems = groupMyltiply.Measure() + circle.Measure();
            float measureGroup = groupSum.Measure();

            Assert.AreEqual(measureItems, measureGroup);
        }
        
        [Test]
        public void Measure_MultiplyItems_FiguresAndOtherGroup()
        {
            FigureSquare square = new FigureSquare(2);
            FigureCircle circle = new FigureCircle(2);
            FigureTriangle triangle = new FigureTriangle(3, 4, 5);
            GroupSum groupSum = new GroupSum(); 
            GroupMyltiply groupMyltiply = new GroupMyltiply();
            
            groupSum.Add(triangle);
            groupSum.Add(square);
            groupMyltiply.Add(groupSum);
            groupMyltiply.Add(circle);
            float measureItems = groupSum.Measure() * circle.Measure();
            float measureGroup = groupMyltiply.Measure();

            Assert.AreEqual(measureItems, measureGroup);
        }
    }
}