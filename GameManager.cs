using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballLoc;
    public float delaySeconds = 5f;

    private void Start()
    {
        InvokeRepeating("SpawnBall", delaySeconds, delaySeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBall()
    {
        //yield return new WaitForSeconds(delaySeconds);
        GameObject ball = Instantiate(ballPrefab, ballLoc);
    }
}
