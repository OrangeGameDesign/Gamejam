using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gate_key : MonoBehaviour
{
    public GameObject Gate; // møíž
    public GameObject Key; // klíè

    private bool hasKey = false;
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hasKey)
            {
                Gate.GetComponent<Animator>().SetTrigger("Open"); // spustí animaci otevøení møíže
                Destroy(Key); // znièí klíè
            }
        }
        else if (other.gameObject.CompareTag("Key"))
        {
            hasKey = true; // hráè sebral klíè
            Destroy(other.gameObject); // znièí klíè v herním svìtì
        }
    
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gate.GetComponent<Animator>().SetTrigger("Open");
            Destroy(gameObject);


        }

    }
}
