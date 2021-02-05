using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform teleportStart;
    public GameObject thePlayer;
    public GameObject teleporter;
    private float tpBackTimer = 99999f;

    private void Update()
    {
        tpBackTimer -= Time.deltaTime;
        if (tpBackTimer <= 0f)
        {
            TeleportBack();
        }
        Debug.Log(tpBackTimer);
    }

    private void OnTriggerEnter(Collider other)
    {
        TeleportTo();
    }

    private void TeleportTo()
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        tpBackTimer = 3f;
    }

    private void TeleportBack()
    {
        thePlayer.transform.position = teleportStart.transform.position;
        Destroy(teleporter, 0.1f);
    }
}
