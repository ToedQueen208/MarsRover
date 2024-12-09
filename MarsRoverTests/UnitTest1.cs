using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MarsRover;

namespace MarsRoverTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

          [Test]
        public void Test_InputPlateauNumbers()
        {
            InputParser parser = new InputParser();
            string testString = "5 5"; 

            var ans = parser.InputPlatau(testString).Length;
            int expected = new int[5,5].Length ; 
            //ans.Should().BeOfType<string[]>();
            ans.Should().Be(expected);
 

        }

        [Test]
        public void Test_InputPosition()
        {
            InputParser parser = new InputParser();
            string testString = "1 2 N";

            var ans = parser.InputPosition(testString);
            Position expected = new Position(1,2,CompassDirection.N);
            //ans.Should().BeOfType<string[]>();
            ans.x.Should().Be(1);
            ans.y.Should().Be(2);
            ans.facing.Should().Be(CompassDirection.N);

        }
        [Test]
        public void Test_InputPositionOutsideArray()
        {
            InputParser parser = new InputParser();
            string testString = "1 2 N";
            string testPlateau = "5 5";

            var plat = parser.InputPlatau(testPlateau);
            var ans = parser.InputPosition(testString);

            Position expected = new Position(1, 2, CompassDirection.N);
      


        }

        [Test]
        public void Test_InputInStructions()
        {
           //Assemble
            InputParser parser = new InputParser();
            string TestInp = "MRM";
            List<Instruction> expectedIns = new List<Instruction>();
            expectedIns.Add(Instruction.M);
            expectedIns.Add(Instruction.R);
            expectedIns.Add(Instruction.M);


            //Act
     
            var ans = parser.InputInstruction(TestInp);

            //Assert
            ans.Should().ContainInOrder(expectedIns)
                .And.HaveCount(expectedIns.Count);


        }
    }
}