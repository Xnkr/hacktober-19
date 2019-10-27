using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerScoreText;
    public Text computerScoreText;

    public int playerScore;
    public int computerScore;

    public void IncScore(string colliderName){
        switch (colliderName)
        {
            case "Bound South":
                computerScore += 1;
                computerScoreText.text = "Computer: " + computerScore;
                break;
            case "Bound North":
                playerScore += 1;
                playerScoreText.text = "You: " + playerScore;
                break;
        }
    }
}
