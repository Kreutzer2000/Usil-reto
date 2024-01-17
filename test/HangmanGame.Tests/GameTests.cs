using Xunit;
using Hangman;

public class GameTests
{
    /// <summary>
    /// Comprueba que adivinar una letra correcta no reduce las vidas.
    /// </summary>
    [Fact]
    public void GuessLetter_CorrectGuess_DoesNotDecreaseLives()
    {
        var game = new Game("TEST");
        int initialLives = game.LivesRemaining();

        game.GuessLetter('T');

        Assert.Equal(initialLives, game.LivesRemaining());
        Assert.Contains('T', game.GuessedLetters);
    }

    /// <summary>
    /// Asegura que adivinar una letra incorrecta reduce las vidas.
    /// </summary>
    [Fact]
    public void GuessLetter_IncorrectGuess_DecreasesLives()
    {
        var game = new Game("TEST");
        int initialLives = game.LivesRemaining();

        game.GuessLetter('X');

        Assert.Equal(initialLives - 1, game.LivesRemaining());
        Assert.Contains('X', game.GuessedLetters);
    }

    /// <summary>
    /// Verifica que la palabra mostrada se actualiza correctamente tras cada adivinanza.
    /// </summary>
    [Fact]
    public void ShownWord_UpdatesAfterGuess()
    {
        var game = new Game("TEST");
        game.GuessLetter('T');
        Assert.Equal("T__T", game.ShownWord());
    }

    /// <summary>
    /// Confirma que las letras incorrectas se acumulan correctamente.
    /// </summary>
    [Fact]
    public void IncorrectLetters_AccumulateOnWrongGuesses()
    {
        var game = new Game("TEST");
        game.GuessLetter('A');
        game.GuessLetter('B');
        Assert.Contains('A', game.IncorrectLetters());
        Assert.Contains('B', game.IncorrectLetters());
    }

    /// <summary>
    /// Comprueba que los caracteres prohibidos son ignorados y no afectan las vidas ni se añaden a las letras adivinadas.
    /// </summary>
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
