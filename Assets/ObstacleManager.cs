using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject GameObject;
    public float baseSpawnCooldown = 3f;
    float spawnCooldown;
    public float destroyCooldown = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        spawnCooldown = baseSpawnCooldown;
        spawnObstacles();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool spawn = checkCooldown();
        if (spawn && !GameOverScreen.showScreen)
        {
            spawnObstacles();
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


    void spawnObstacles()
    {
        Destroy(Instantiate(GameObject, new Vector3(5, Random.Range(0.1f, 4.25f), 0), Quaternion.identity),15);
    }

}
