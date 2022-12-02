namespace Day2;

public interface IMove
{
    MoveType Move { get; }
    int OutcomeofFight(MoveType opponentMove);
}