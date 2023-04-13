using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prazdna_deska_batton : MonoBehaviour
{
    public Animator animBatton;

    public GameObject Gate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Box"))
        {
            animBatton.GetComponent<Animator>().SetBool("animace_dolu", true);
            Gate.GetComponent<Animator>().SetTrigger("Open");
            Gate.GetComponent<Animator>().SetBool("gate_down", true);

        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        animBatton.GetComponent<Animator>().SetBool("animace_dolu", false);
        Gate.GetComponent<Animator>().SetBool("gate_down", false);
    }
}
