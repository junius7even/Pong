using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game manager keeps track of the state of things in the game
public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores() {
        _playerScore ++;
        this.ball.ResetPosition();
    }

    public void ComputerScores() {
        _computerScore ++ ;
        this.ball.ResetPosition();
    }

    
}
