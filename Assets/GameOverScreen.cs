using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{

    public static bool showScreen = false;
    public Transform gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        showGameOver();
    }

    void showGameOver()
    {
        gameOverScreen.gameObject.SetActive(showScreen);       
    }
}
