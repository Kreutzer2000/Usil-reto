using Xunit;
using Hangman;

public class CellTests
{
    [Fact]
    public void Cell_CreationWithText_CorrectAlignment()
    {
        var cell = new Cell("Test");
        Assert.Equal(Cell.LeftAlign, cell.Align);
    }

    [Fact]
    public void Cell_CreationWithTextAndAlignment_CorrectAlignment()
    {
        var cell = new Cell("Test", Cell.CentreAlign);
        Assert.Equal(Cell.CentreAlign, cell.Align);
    }

    [Fact]
    public void Cell_LeftMargin_CalculatedCorrectly()
    {
        var cell = new Cell("Test", Cell.CentreAlign);
        Assert.Equal(3, cell.LeftMargin(10)); // (10 - "Test".Length) / 2
    }

    [Fact]
    public void Cell_Length_ReturnsCorrectLength()
    {
        var cell = new Cell("Test\nLine2");
        Assert.Equal(5, cell.Length()); // "Line2".Length
    }

    [Fact]
    public void Cell_Height_ReturnsCorrectNumberOfLines()
    {
        var cell = new Cell("Test\nLine2");
        Assert.Equal(2, cell.Height());
    }

    [Fact]
    public void Cell_LineAtIndex_ReturnsCorrectLine()
    {
        var cell = new Cell("Line1\nLine2");
        Assert.Equal("Line2", cell.LineAtIndex(1));
    }

    [Fact]
    public void Cell_LineAtIndex_OutOfRange_ReturnsEmptyString()
    {
        var cell = new Cell("SingleLine");
        Assert.Equal("", cell.LineAtIndex(1)); // No existe línea en índice 1
    }

    [Fact]
    public void Cell_LeftMargin_DefaultCase()
    {
        var cell = new Cell("Test");
        // Forzamos un valor de alineación no válido para entrar en el caso 'default'
        cell.Align = -1;
        Assert.Equal(-1, cell.LeftMargin(10));
    }
}
