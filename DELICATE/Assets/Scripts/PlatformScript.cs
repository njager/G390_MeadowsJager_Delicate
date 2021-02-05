using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject gameObject;
    private float timeToDestroy = 1f;

    private void Start()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        print("Exited!");
        Destroy(gameObject, timeToDestroy);
    }
}
