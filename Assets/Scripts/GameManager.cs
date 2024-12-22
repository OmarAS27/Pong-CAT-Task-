using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;

    public Paddle playerPaddle;

    public Paddle computerPaddle;

    private int _playerScore;
    private int _computerScore;
    
    public void PlayerScore()
    {
        _playerScore ++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();

    }

    public void ComputerScore()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
        
    }
    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();

    }


}
