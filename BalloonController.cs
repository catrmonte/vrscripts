using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public GameObject balloonPrefab;
    private GameObject balloon;
    private Rigidbody rb;

    public float floatStrength = 20.0f;
    public float growRate = 1.5f;

    // Update is called once per frame
    void Update()
    {
        if (balloon != null)
        {
            GrowBalloon();
        }
    }

    public void CreateBalloon(GameObject parentHand)
    {
        balloon = Instantiate(balloonPrefab, parentHand.transform);
        balloon.transform.localScale = new Vector3(.1f, .1f, .1f);
        rb = balloon.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    public void ReleaseBalloon()
    {
        rb.isKinematic = false;
        balloon.transform.parent = null;
        balloon.GetComponent<Rigidbody>().AddForce(Vector3.up * floatStrength);
        GameObject.Destroy(balloon, 10f);
        balloon = null;
    }

    public void GrowBalloon()
    {
        float growThisFrame = growRate * Time.deltaTime;
        Vector3 changeScale = balloon.transform.localScale * growThisFrame;
        balloon.transform.localScale += changeScale;
    }
}
