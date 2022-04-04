using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [SerializeField] GameObject balle;
    float radius = 1f;
    [SerializeField] int amountToSpawn;
    [SerializeField] int forceStrenght;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < amountToSpawn; i++)
            {
                float angle = i * Mathf.PI * 2f / amountToSpawn;
                Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 0 , Mathf.Sin(angle) * radius);
                GameObject go = Instantiate(balle, transform.position + newPos, Quaternion.identity);
                go.GetComponent<Rigidbody>().AddForce(newPos * forceStrenght);
                Destroy(go, 2f);

            }
        }
    }
}
