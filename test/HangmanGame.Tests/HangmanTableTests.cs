using Hangman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Tests
{
    public class HangmanTableTests
    {
        [Fact]
        public void BuildTable_ValidConfiguration_CreatesExpectedTable()
        {
            string word = "TEST";
            string title = "Hangman Game";
            var game = new Game(word);

            foreach (char c in word) game.GuessLetter(c);

            int width = 20;
            int spacing = 1;

            var table = HangmanTable.Build(word, title, game, width, spacing);

            Assert.NotNull(table);

            Assert.Equal(width, table.Width);
            Assert.Equal(spacing, table.Spacing);

            var tableOutput = table.Draw();
            Assert.Contains(title, tableOutput);
            Assert.Contains(word, tableOutput);
            Assert.Contains(game.Status, tableOutput);
        }

        [Fact]
        public void BuildTable_InvalidWidth_ThrowsException()
        {
            string word = "TEST";
            string title = "Hangman Game";
            var game = new Game(word);
            int width = -1;
            int spacing = 1;

            var table = Record.Exception(() => HangmanTable.Build(word, title, game, width, spacing));

            Assert.Null(table);
        }

    }
}
