using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    //public variable to implement via inspector
    public Transform teleportTarget;
    public Transform teleportStart;
    public GameObject thePlayer;
    public GameObject teleporter;

    //private variables 
    private float tpBackTimer = 99999f; //is super long so that it won't get ticked down just by playing

    //called every frame
    private void Update()
    {
        tpBackTimer -= Time.deltaTime;
        //after the timer is set to its real timer, the above time decrease will cause it to hit 0 then teleport player back
        if (tpBackTimer <= 0f)
        {
            TeleportBack();
        }
    }

    //called when player enters the teleport pad
    private void OnTriggerEnter(Collider other)
    {
        TeleportTo();
    }

    //teleports the player to the transform position of the teleport target then sets back timer
    private void TeleportTo()
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        tpBackTimer = 5f;
    }

    //teleports player back to starting location and deletes the whole teleporter to avoid infinite teleporting freezing player
    private void TeleportBack()
    {
        thePlayer.transform.position = teleportStart.transform.position;
        Destroy(teleporter, 0.1f);
    }
}
