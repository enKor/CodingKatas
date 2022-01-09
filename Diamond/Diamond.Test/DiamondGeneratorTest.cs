using Xunit;

namespace Diamond.Test
{
    public class DiamondGeneratorTest
    {
        [Theory]
        [InlineData('D', @"   A
  B B
 C   C
D     D
 C   C
  B B
   A")]
        [InlineData('C', @"  A
 B B
C   C
 B B
  A")]
        [InlineData('A', "A")]
        public void CreateDiamondTest(char diamondType, string expectedResult)
        {
            var result = DiamondGenerator.CreateDiamond(diamondType);
            Assert.Equal(expectedResult, result);
        }
    }
}
