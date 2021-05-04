using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookMoveTo : MonoBehaviour
{
    public GameObject ground;
    private Transform camera;

    public Transform infoBubble;
    private Text infoText;

    public GameObject redShroom;
    public GameObject blueShroom;
    public GameObject purpleShroom;
    public GameObject yellowShroom;

    public Color redColor;
    public Color blueColor;
    public Color purpleColor;
    public Color yellowColor;

    private Color currentColor;

    private void Start()
    {
        camera = Camera.main.transform;
        currentColor = redColor;

        if (infoBubble != null)
        {
            infoText = GetComponentInChildren<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray;
        RaycastHit[] hits;
        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100f);

        ray = new Ray(camera.position, camera.rotation * Vector3.forward);

        hits = Physics.RaycastAll(ray);

        for (int i=0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            hitObject = hit.collider.gameObject;
            
            // if it's the ground, move to that point
            if (hitObject == ground)
            {
                if (infoBubble != null)
                {
                    infoText.text = "X: " + hit.point.x.ToString("F2") + ", Z: " + hit.point.z.ToString("F2");
                    infoBubble.LookAt(camera.position);
                    infoBubble.Rotate(0, 180f, 0);
                }
                transform.position = hit.point;
            }
            // if its the red shroom, color is red
            /*else if (hitObject == redShroom)
            {
                currentColor = redColor;
            }
            // if its the blue shroom, color is blue
            else if (hitObject == blueShroom)
            {
                currentColor = blueColor;
            }
            // if its the purple shroom, color is purple
            else if (hitObject == purpleShroom)
            {
                currentColor = purpleColor;
            }
            // if its the yellow shroom, color is yellow
            else if (hitObject == yellowShroom)
            {
                currentColor = yellowColor;
            }
            else
            {
                hitObject.transform.GetComponent<Renderer>().material.color = currentColor;
            }*/
        }
    }
}
