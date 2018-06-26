using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;
    public float minHeightForDeath;
    public GameObject player;

    void Update()
    {
        if (player.transform.position.y < minHeightForDeath)
            player.transform.position = spawnPoint.position;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deadly")) 


        {
            player.transform.position = spawnPoint.position;
        }


       
    }
}

