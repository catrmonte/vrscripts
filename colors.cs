using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colors : MonoBehaviour
{
    public Color redcolor;
    public Color bluecolor;
    public GameObject ground;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != ground)
        {
            other.gameObject.transform.GetComponent<Renderer>().material.color = redcolor;
        }

        transform.GetComponent<Renderer>().material.color = bluecolor;

        /*if (other.gameObject.CompareTag("RedPaddle"))
        {
            Debug.Log("It's ALIVE and red");
            transform.GetComponent<Renderer>().material.color = redcolor;
        }

        if (other.gameObject.CompareTag("BluePaddle"))
        {
            Debug.Log("It's ALIVE and blue");
            transform.GetComponent<Renderer>().material.color = bluecolor;
        }*/
    }
}
