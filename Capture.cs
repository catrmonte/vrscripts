using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capture : MonoBehaviour
{
    private bool inSights;
    public int score;
    public Text scoreText;
    public Text debugText;

    // Start is called before the first frame update
    void Start()
    {
        inSights = false;
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ghost")
        {
            inSights = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ghost")
        {
            inSights = false;
        }
    }

    public void CaptureGhost()
    {
        // check if zombie is in sights
        if (inSights)
        {
            score++;
        }
        else
        {
            score--;
        }

        scoreText.text = "Score: " + score;
    }
}
