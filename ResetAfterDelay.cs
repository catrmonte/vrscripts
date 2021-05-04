using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAfterDelay : MonoBehaviour
{
    public float delaySeconds = 5f;
    private Vector3 startPosition;
    public Transform startLocation;
    public GameObject ballPrefab;

    public GameObject splashEffectPrefab;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        if (startLocation == null)  
        {
            startLocation = GameObject.Find("BallLocation").transform;
        }
    }

    public void Reset()
    {
        StartCoroutine(AfterDelay());
    }

    IEnumerator AfterDelay()
    {
        yield return new WaitForSeconds(delaySeconds);
        //transform.position = startPosition;
        //GameObject ball = Instantiate(ballPrefab, startLocation);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cauldron")
        {
            GameObject effect = Instantiate(splashEffectPrefab, transform.position, transform.rotation);
            Destroy(effect, 1f);
            transform.position += new Vector3(0, -10, 0);
        }
        Destroy(this, 10f);
    }
}
