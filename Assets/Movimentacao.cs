using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    public float upSpeed = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Up()
    {
        
        if (Input.GetKey(KeyCode.Space) && !GameOverScreen.showScreen)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * upSpeed ,ForceMode2D.Impulse); 
        }
    }

    void DestroyObject()
    {
        if (GameOverScreen.showScreen)
        {
            Destroy(this.gameObject);
        }
    }


    

    // Update is called once per frame
    void Update()
    {   
        Up();
        DestroyObject();
    }
}
