using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineModifier : MonoBehaviour
{
    private void Start()
    {
        GameObject lineRadius = GameObject.Find("BallSpawner");
        BallSpawner ballSpawner = lineRadius.GetComponent<BallSpawner>();
        ballSpawner.radius = 1;
        ballSpawner.amountToSpawn = 16;
        ballSpawner.forceStrenght = 1500;
    }





    private void OnCollisionStay(Collision collision)
    {
        GameObject lineRadius = GameObject.Find("BallSpawner");
        BallSpawner ballSpawner = lineRadius.GetComponent<BallSpawner>();

        if (collision.gameObject.tag == "Stone")
        {
            Debug.Log("truc");
            ballSpawner.radius = 1;
            ballSpawner.amountToSpawn = 16;
            ballSpawner.forceStrenght = 1500;
        }

        if (collision.gameObject.tag == "Water")
        {
            Debug.Log("truc2");
            ballSpawner.radius = 3;
            ballSpawner.amountToSpawn = 8;
            ballSpawner.forceStrenght = 500;
        }
    }
}
