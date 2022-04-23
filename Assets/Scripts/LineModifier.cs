using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineModifier : MonoBehaviour
{
    [SerializeField] private AudioSource dirtSound;
    [SerializeField] private AudioSource WaterSound;
    [SerializeField] private AudioSource stoneSound;



    private void Start()
    {
        BallSpawner ballSpawner = GetComponent<BallSpawner>();
        ballSpawner.radius = 1;
        ballSpawner.amountToSpawn = 16;
        ballSpawner.forceStrenght = 1500;
    }





    private void OnCollisionStay(Collision collision)
    {
        BallSpawner ballSpawner = GetComponent<BallSpawner>();

        if (collision.gameObject.tag == "Stone")
        {
            Debug.Log("truc");
            ballSpawner.radius = 1;
            ballSpawner.amountToSpawn = 16;
            ballSpawner.forceStrenght = 1500;
            ballSpawner.targetTime = 1;
            ballSpawner.destroyTime = 1f;

            ballSpawner.audioPlay = stoneSound;
        }

        if (collision.gameObject.tag == "Dirt")
        {
            Debug.Log("truc2");
            ballSpawner.radius = 3;
            ballSpawner.amountToSpawn = 8;
            ballSpawner.forceStrenght = 500;
            ballSpawner.targetTime = 1;
            ballSpawner.destroyTime = 0.5f;

            ballSpawner.audioPlay = dirtSound;
        }

        if (collision.gameObject.tag == "Water")
        {
            Debug.Log("truc2");
            ballSpawner.radius = 0.2f;
            ballSpawner.amountToSpawn = 16;
            ballSpawner.forceStrenght = 200;
            ballSpawner.targetTime = 1;
            ballSpawner.destroyTime = 3f;

            ballSpawner.audioPlay = WaterSound;
        }
    }
}
