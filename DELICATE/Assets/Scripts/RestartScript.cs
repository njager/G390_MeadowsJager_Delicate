using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider col)
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

}
