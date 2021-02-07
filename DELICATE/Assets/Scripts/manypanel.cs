using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class manypanel : MonoBehaviour
{
    // Drag & Drop your gameObjects here
    public GameObject[] GameObjectsList;
    private int shownGameObjectIndex = -1;

    public static int ColorCountPanel;

    private void Start()

    {

        for (int i = 0; i < GameObjectsList.Length; ++i)
            GameObjectsList[i].SetActive(false);
        SelectNextGameObject();
    }


    // Add this function as callback for your button's onClick event
    public void SelectNextGameObject()
    {
        int index = shownGameObjectIndex >= GameObjectsList.Length - 1 ? -1 : shownGameObjectIndex;
        SelectGameObject(index + 1);
    }
    public void SelectPreviousGameObject()
    {
        int index = shownGameObjectIndex <= 0 ? GameObjectsList.Length : shownGameObjectIndex;
        SelectGameObject(index - 1);
    }
    public void SelectGameObject(int index)
    {
        if (shownGameObjectIndex >= 0)
            GameObjectsList[shownGameObjectIndex].SetActive(false);
        shownGameObjectIndex = index;
        GameObjectsList[shownGameObjectIndex].SetActive(true);
    }

    private void OnTriggerEnter(Collider col)
    {

        Debug.Log("wordz1");

        if (col.gameObject.tag == "Player")
        {
            Debug.Log("wordz");
            SelectNextGameObject();

        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("wordz");
            SelectNextGameObject();

        }
    }
}