using Hangman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Tests
{
    public class TableFactoryTests
    {
        [Fact]
        public void Build_WithValidConfig_CreatesTable()
        {
            // Setup configuration
            object[] row1Config = new object[] { new object[] { "Row 1, Cell 1", Cell.LeftAlign } };
            object[] row2Config = new object[] { new object[] { "Row 2, Cell 1", Cell.CentreAlign },
                                                 new object[] { "Row 2, Cell 2", Cell.RightAlign } };
            object[] config = new object[] { row1Config, row2Config };
            int width = 30;
            int spacing = 1;

            // Building the table
            var table = TableFactory.Build(config, width, spacing);

            // Asserts
            Assert.NotNull(table);
            Assert.Equal(2, table.Rows.Length); // There should be 2 rows
            Assert.Equal(width, table.Width);
            Assert.Equal(spacing, table.Spacing);
        }

        [Fact]
        public void BuildRow_WithValidConfig_CreatesRow()
        {
            // Row configuration
            object[] rowConfig = new object[] { new object[] { "Cell 1", Cell.LeftAlign },
                                                new object[] { "Cell 2", Cell.CentreAlign },
                                                new object[] { "Cell 3", Cell.RightAlign } };

            // Building the row
            var row = TableFactory.BuildRow(rowConfig);

            // Asserts
            Assert.NotNull(row);
            Assert.Equal(3, row.Cells.Length); // There should be 3 cells
        }

        [Fact]
        public void BuildCell_WithValidConfig_CreatesCell()
        {
            // Cell configuration
            string text = "Test Cell";
            int alignment = Cell.CentreAlign;

            // Building the cell
            var cell = TableFactory.BuildCell(new object[] { text, alignment });

            // Asserts
            Assert.NotNull(cell);
            Assert.Equal(text, cell.Text);
            Assert.Equal(alignment, cell.Align);
        }

        // More tests can be added here as needed
    }
}
