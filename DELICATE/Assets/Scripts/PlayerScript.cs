using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    //variables
    private int count;
    public TextMeshProUGUI countText;
 
    void Start()
    {
        SetCountText();
    }

    //Updates count text with current data, displays win text
    void SetCountText()
    {
        countText.text = "Letters: " + count.ToString();
    }

    //called when player enters a trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if the trigger is a pick up, update count and play sound
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;

            SetCountText();
        }

    }
}
