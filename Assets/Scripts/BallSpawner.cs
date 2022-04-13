using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [SerializeField] GameObject balle;
    [SerializeField] public float radius = 1f;
    [SerializeField] public int amountToSpawn;
    [SerializeField] public int forceStrenght;
    [SerializeField] public float targetTime;
    [SerializeField] public float destroyTime ;

    private float remainingTime;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        remainingTime = targetTime;
    }

    void Update()
    {
        remainingTime -= Time.deltaTime;
        Debug.Log(remainingTime);

        if (remainingTime <= 0.0f)
        {
            LineSpawning();
        }
    }

    
    void LineSpawning()
    {
        if ((rb.velocity.sqrMagnitude != 0))
        {
            for (int i = 0; i < amountToSpawn; i++)
            {
                float angle = i * Mathf.PI * 2f / amountToSpawn;
                Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);
                GameObject go = Instantiate(balle, transform.position + newPos, Quaternion.identity);
                go.GetComponent<Rigidbody>().AddForce(newPos * forceStrenght);
                Destroy(go, destroyTime);
                remainingTime = targetTime;
            }
        }
    }
    
}
