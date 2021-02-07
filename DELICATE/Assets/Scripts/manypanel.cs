using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class manypanel : MonoBehaviour
{
    // Drag & Drop your gameObjects here
    public GameObject[] GameObjectsList;
    private int shownGameObjectIndex = -1;
    SpriteRenderer m_SpriteRenderer;
    public static int ColorCountPanel;

    private void Start()

    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
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

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (true)
        {
            if (ColorCountPanel <= 3)
            {


                if (col.gameObject.tag == "red crayon")
                {
                    //Debug.Log("redyes");
                    // m_SpriteRenderer.color = Color.red;
                    //Image img = GameObject.Find("Text1").GetComponent<Image>();
                    // img.color = new Color(1, 0, 0, 1);
                    m_SpriteRenderer.color = new Color(1, 0, 0, 1);
                    SelectNextGameObject();
                    ColorCountPanel++;
                }
                else if (col.gameObject.tag == "green crayon")
                {
                    //Debug.Log("greenyes");
                    //m_SpriteRenderer.color = Color.green;
                    // Image img = GameObject.Find("Text1").GetComponent<Image>();
                    // img.color = new Color(0, 1, 0, 1);
                    m_SpriteRenderer.color = new Color(0, 1, 0, 1);
                    SelectNextGameObject();
                    ColorCountPanel++;
                }
                else if (col.gameObject.tag == "orange crayon")
                {
                    //Image img = GameObject.Find("Text1").GetComponent<Image>();
                    // img.color = new Color(1, 0.75f, 0, 1);
                    m_SpriteRenderer.color = new Color(1, 0.75f, 0, 1);
                    SelectNextGameObject();
                    ColorCountPanel++;
                }
                else if (col.gameObject.tag == "yellow crayon")
                {
                    // Image img = GameObject.Find("Text1").GetComponent<Image>();
                    // img.color = new Color(1, 1, 0, 1);
                    m_SpriteRenderer.color = new Color(1, 1, 0, 1);
                    SelectNextGameObject();
                    ColorCountPanel++;
                }
                else if (col.gameObject.tag == "blue crayon")
                {
                    // Image img = GameObject.Find("Text1").GetComponent<Image>();
                    // img.color = new Color(0, 0, 1, 1);
                    m_SpriteRenderer.color = new Color(0, 0, 1, 1);
                    SelectNextGameObject();
                    ColorCountPanel++;
                }
                else if (col.gameObject.tag == "purple crayon")
                {
                    //Image img = GameObject.Find("Text1").GetComponent<Image>();
                    //img.color = new Color(0.5f, 0, 1, 1);
                    m_SpriteRenderer.color = new Color(0.5f, 0, 1, 1);
                    SelectNextGameObject();
                    ColorCountPanel++;
                }
                else if (col.gameObject.tag == "black crayon")
                {
                    //Image img = GameObject.Find("Text1").GetComponent<Image>();
                    //img.color = new Color(0, 0, 0, 1);
                    m_SpriteRenderer.color = new Color(0, 0, 0, 1);
                    SelectNextGameObject();
                    ColorCountPanel++;
                }

               
            }
        }
    }
}