using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public Transform teleportDestination; // Transformace m�sta, kam chceme hr��e teleportovat
    public GameObject player;
    public Transform transf;

    // Objekt, na kter� mus� hr�� narazit pro teleportaci
    public GameObject teleportTrigger;
    /*
    // Kontrola, zda-li je hr�� v dosahu pro teleportaci
    private bool CanTeleport(Collider other)
    {
        // Kontrola, zda-li se hr�� dotkl teleportTrigger
        return (other.gameObject == teleportTrigger);
    }

    // Funkce pro teleportaci hr��e na m�sto teleportDestination
    private void Teleport()
    {
        transform.position = teleportDestination.position;
    }

    // Kontrola, zda-li hr�� narazil na objekt teleportTrigger
    private void OnTriggerEnter(Collider other)
    {
        if (CanTeleport(other))
        {
            Teleport();
        }
    }

    // Kontrola, zda-li hr�� opustil objekt teleportTrigger
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
