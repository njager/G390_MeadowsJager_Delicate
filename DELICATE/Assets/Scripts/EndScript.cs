using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {

        Debug.Log("End");

        if (col.gameObject.tag == "Player")
        {

            float endTimer = 5f;
            endTimer -= Time.deltaTime;
            if(endTimer <= 0f )
            {
                Application.Quit();
            }


        }
    }
}
