using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroytimed : MonoBehaviour
{
    public float destroyDelay = 6f;

    void Start()
    {
        Invoke("DestroySelf", destroyDelay);
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }
}
