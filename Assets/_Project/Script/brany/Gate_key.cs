using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gate_key : MonoBehaviour
{
    public GameObject Gate; // m��
    public GameObject Key; // kl��

    private bool hasKey = false;
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (hasKey)
            {
                Gate.GetComponent<Animator>().SetTrigger("Open"); // spust� animaci otev�en� m��e
                Destroy(Key); // zni�� kl��
            }
        }
        else if (other.gameObject.CompareTag("Key"))
        {
            hasKey = true; // hr�� sebral kl��
            Destroy(other.gameObject); // zni�� kl�� v hern�m sv�t�
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
