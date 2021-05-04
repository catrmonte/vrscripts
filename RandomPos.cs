using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPos : MonoBehaviour
{
    public float xRange;
    public float zRange;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RePositionWithDelay());
    }

    IEnumerator RePositionWithDelay()
    {
        while (true)
        {
            SetRandomPosition();
            yield return new WaitForSeconds(5f);
        }
    }

    void SetRandomPosition()
    {
        float x = Random.Range(-xRange, xRange);
        float z = Random.Range(-zRange, zRange);

        Debug.Log("X,Z: " + x.ToString("F2") + ", " + z.ToString("F2"));

        transform.position = new Vector3(x, 0.0f, z);
    }
}
