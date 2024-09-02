namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise64Tests
{
    [Test]
    public void Case1()
    {
        int[][] grid = [[1, 3, 1], [1, 5, 1], [4, 2, 1]];

        Exercise64.MinPathSum(grid).Should().Be(7);
    }

    [Test]
    public void Case2()
    {
        int[][] grid = [[1,2,3],[4,5,6]];

        Exercise64.MinPathSum(grid).Should().Be(12);
    }
    
    [Test]
    public void Case3()
    {
        int[][] grid =
        [
            [1, 1, 1, 5, 5],
            [5, 5, 1, 5, 5],
            [5, 1, 1, 5, 5],
            [5, 1, 5, 5, 5],
            [5, 1, 1, 1, 1],
        ];

        // влево перемещать нельзя по условию задачи (иначе ответ - 11)
        Exercise64.MinPathSum(grid).Should().Be(13);
    }
}