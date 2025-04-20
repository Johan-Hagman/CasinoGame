namespace CasinoGame;

public interface IGame
{
    string Name { get; }        
    bool CanPlay();             
    void Play();   
}