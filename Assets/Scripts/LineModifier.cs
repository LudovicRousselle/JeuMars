using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineModifier : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            Debug.Log("truc");
        }

        if (collision.gameObject.tag == "Water")
        {
            Debug.Log("truc2");
        }
    }
}
