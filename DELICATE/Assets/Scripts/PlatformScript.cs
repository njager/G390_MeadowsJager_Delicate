using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject gameObject;
    public float timeToDestroy = 1f;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Exited!");
            Destroy(gameObject, timeToDestroy);
        }
    }
}
