using GuessNumber.Logic.Enums;

namespace GuessNumber.Logic;

public class Game
{

    private DateTime _startDate;
    private DateTime _endDate;
    public TimeSpan Duration
    {
        get { return _endDate - _startDate; }
    }

    private int _retryCounter;
    public int RetryCounter
    {
        get { return _retryCounter; }
    }

    private int _randomNumber;
    public Game(GameLevel gameLevel)
    {
        _randomNumber = new Random().Next(1, (int)gameLevel);
        _retryCounter = 0;
        _startDate = DateTime.Now;
    }
    public GameHint CheckGuessNumber (int guessNumber)
    {
        _retryCounter++;
        if (_randomNumber < guessNumber) 
        {
            return GameHint.Down;
        }
        else if (_randomNumber > guessNumber) 
        {
            return GameHint.Up;
        }
        else
        {
            _endDate = DateTime.Now;
            return GameHint.Correct;
        }
    }
}
