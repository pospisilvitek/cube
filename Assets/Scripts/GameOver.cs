using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameOverText;
    public GameManager gameManager;
    void Update()
    {
        if (gameManager.gameHasEnded == true)
        { 
            gameOverText.text = "GAME OVER";
        }
    }
}

