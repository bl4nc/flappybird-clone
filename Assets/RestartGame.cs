using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame()
    {
        GameOverScreen.showScreen = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    
}
