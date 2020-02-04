using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float nextSpawn = 1f;
    
    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-4f, 4f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(coin, whereToSpawn, Quaternion.identity);
            SoundManager.instance.CoinPickClip();
        }
    }
}
