using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public Transform teleportDestination; // Transformace mÌsta, kam chceme hr·Ëe teleportovat
    public GameObject player;
    public Transform transf;

    // Objekt, na kter˝ musÌ hr·Ë narazit pro teleportaci
    public GameObject teleportTrigger;
    /*
    // Kontrola, zda-li je hr·Ë v dosahu pro teleportaci
    private bool CanTeleport(Collider other)
    {
        // Kontrola, zda-li se hr·Ë dotkl teleportTrigger
        return (other.gameObject == teleportTrigger);
    }

    // Funkce pro teleportaci hr·Ëe na mÌsto teleportDestination
    private void Teleport()
    {
        transform.position = teleportDestination.position;
    }

    // Kontrola, zda-li hr·Ë narazil na objekt teleportTrigger
    private void OnTriggerEnter(Collider other)
    {
        if (CanTeleport(other))
        {
            Teleport();
        }
    }

    // Kontrola, zda-li hr·Ë opustil objekt teleportTrigger
    private void OnTriggerExit(Collider other)
    {
        if (CanTeleport(other))
        {
            Teleport();
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Ahoj");
           // player.transform.position = new Vector3(8, 1, 20);
           // transf = transform.position(new Vector3(8, 1, 20));
        }
        
    }

}
