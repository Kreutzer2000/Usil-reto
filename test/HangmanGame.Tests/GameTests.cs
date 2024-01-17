using Xunit;
using Hangman;

public class GameTests
{
    [Fact]
    public void GuessLetter_CorrectGuess_DoesNotDecreaseLives()
    {
        var game = new Game("TEST");
        int initialLives = game.LivesRemaining();

        game.GuessLetter('T');

        Assert.Equal(initialLives, game.LivesRemaining());
        Assert.Contains('T', game.GuessedLetters);
    }


    [Fact]
    public void GuessLetter_IncorrectGuess_DecreasesLives()
    {
        var game = new Game("TEST");
        int initialLives = game.LivesRemaining();

        game.GuessLetter('X');

        Assert.Equal(initialLives - 1, game.LivesRemaining());
        Assert.Contains('X', game.GuessedLetters);
    }

    
    [Fact]
    public void ShownWord_UpdatesAfterGuess()
    {
        var game = new Game("TEST");
        game.GuessLetter('T');
        Assert.Equal("T__T", game.ShownWord());
    }

    [Fact]
    public void IncorrectLetters_AccumulateOnWrongGuesses()
    {
        var game = new Game("TEST");
        game.GuessLetter('A');
        game.GuessLetter('B');
        Assert.Contains('A', game.IncorrectLetters());
        Assert.Contains('B', game.IncorrectLetters());
    }

    
    [Fact]
    public void GuessLetter_IgnoresForbiddenCharacters()
    {
        var game = new Game("TEST");
        int initialLives = game.LivesRemaining();

        game.GuessLetter('1');

        Assert.Equal(initialLives, game.LivesRemaining());
        Assert.DoesNotContain('1', game.GuessedLetters);
    }
}
