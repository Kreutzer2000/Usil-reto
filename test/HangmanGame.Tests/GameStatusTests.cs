using Xunit;
using Hangman;

public class GameStatusTests
{
    /// <summary>
    /// Verifica que el estado inicial del juego sea "jugando".
    /// </summary>
    [Fact]
    public void GameStatus_InitialStatus_IsPlaying()
    {
        var game = new Game("TEST");
        Assert.True(game.IsPlaying());
    }

    /// <summary>
    /// Asegura que el juego cambia a estado "no jugando" cuando se pierde (vidas a 0).
    /// </summary>
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

    /// <summary>
    /// Confirma que el juego termina con un estado de victoria al adivinar correctamente todas las letras.
    /// </summary>
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

    /// <summary>
    /// Verifica que el juego comienza con las vidas correctas y el mensaje de estado inicial.
    /// </summary>
    [Fact]
    public void GameStarts_Correctly()
    {
        var game = new Game("TEST");
        Assert.Equal(15, game.LivesRemaining());
        Assert.Equal("Press any letter to guess!", game.Status);
    }
}
