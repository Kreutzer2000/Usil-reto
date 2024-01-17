using Xunit;
using Hangman;

public class RowTests
{
    [Fact]
    public void Row_Draw_SingleCellLeftAligned()
    {
        var cells = new Cell[] { new Cell("Left") };
        var row = new Row(cells);

        string expectedOutput = "Left";
        Assert.Equal(expectedOutput, row.Draw(20));
    }


    [Fact]
    public void Row_Draw_SingleCellRightAligned()
    {
        var cell = new Cell("Right", Cell.RightAlign);
        var row = new Row(new Cell[] { cell });
        int width = 20;
        string expectedOutput = CalculateRightAlignedOutput(cell, width);

        Assert.Equal(expectedOutput, row.Draw(width));
    }


    private string CalculateRightAlignedOutput(Cell cell, int width)
    {
        return new string(' ', width - cell.Length()) + cell.Text;
    }
}
