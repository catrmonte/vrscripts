using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandInCauldron : MonoBehaviour
{
    public GameObject splashEffectPrefab;
    public Collider opening;
    public Transform away;

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ingredient")
        {
            GameObject effect = Instantiate(splashEffectPrefab, opening.transform.position, opening.transform.rotation);
            Destroy(effect, 1f);
        }
        gameObject.transform.position = away.position;
        Destroy(gameObject, 10f);
    }*/
}
