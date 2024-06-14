using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed = 2f;
    public float baseSpawnCooldown = 3f;
    float spawnCooldown;
    public GameObject GameObject;

    // Start is called before the first frame update
    void Start()
    {
        spawnGround();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveObjectLeft();
        bool spawn = checkCooldown();
        if (spawn)
        {
            spawnGround();
        }
    }


    void moveObjectLeft()
    {
        if (!GameOverScreen.showScreen && gameObject)
        {
            gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }

    bool checkCooldown()
    {
        if (spawnCooldown > 0)
        {
            spawnCooldown -= Time.deltaTime;
            return false;
        }
        spawnCooldown = baseSpawnCooldown;
        return true;
    }

    void spawnGround()
    {
        if (GameObject)
        {
            Destroy(Instantiate(GameObject, new Vector3(0, -4.15f, 0), Quaternion.identity), 5);
        }
    }

}
