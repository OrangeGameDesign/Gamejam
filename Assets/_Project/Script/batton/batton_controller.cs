using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batton_controller : MonoBehaviour
{
    public Animator animBatton;
    
    public GameObject Gate;
    
    // Start is called before the first frame update
    void Start()
    {
        animBatton = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //batton ovládání brány
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animBatton.SetBool("animace_dolu", true);
            Gate.GetComponent<Animator>().SetTrigger("Open");
            Gate.GetComponent<Animator>().SetBool("gate_down", true);
            Gate.GetComponent<Animator>().SetBool("gate_down", false);
        }
         else if (collision.gameObject.tag == "Box")
        {
            animBatton.SetBool("animace_dolu", true);
            Gate.GetComponent<Animator>().SetTrigger("Open");
            Gate.GetComponent<Animator>().SetBool("gate_down", true);
        }


    }
}
