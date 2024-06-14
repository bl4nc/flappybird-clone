using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoviment : MonoBehaviour
{
    public float speed = 1f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        leftMoviment();
    }

    void leftMoviment()
    {   
        if (!GameOverScreen.showScreen)
        {
            gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }
}
