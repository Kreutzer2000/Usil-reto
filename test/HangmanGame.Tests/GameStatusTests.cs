using Xunit;
using Hangman;

public class GameStatusTests
{
    [Fact]
    public void GameStatus_InitialStatus_IsPlaying()
    {
        var game = new Game("TEST");
        Assert.True(game.IsPlaying());
    }

    [Fact]
    public void GameStatus_LoseGame_IsNotPlaying()
    {
        var game = new Game("TEST");

        foreach (char c in "ABCDFGHIJKLMNOPQRUVWXYZ")
        {
            game.GuessLetter(c);
            if (!game.IsPlaying()) break;
        }

        Assert.False(game.IsPlaying());
        Assert.Equal("Game Over!", game.Status);
    }

    [Fact]
    public void WinGame_CorrectGuesses_CompletesGame()
    {
        var game = new Game("TEST");
        foreach (char c in "TEST".ToCharArray().Distinct())
        {
            game.GuessLetter(c);
        }

        Assert.False(game.IsPlaying());
        Assert.Equal("You Win!", game.Status);
    }

    [Fact]
    public void GameStarts_Correctly()
    {
        var game = new Game("TEST");
        Assert.Equal(15, game.LivesRemaining());
        Assert.Equal("Press any letter to guess!", game.Status);
    }
}
