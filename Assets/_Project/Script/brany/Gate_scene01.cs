using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_scene01 : MonoBehaviour
{
    public Animator animGate;
    public Transform button;
    public Transform box;
    public float buttonRange = 0.5f;
    public float distanceToButton;

    // Start is called before the first frame update
    void Start()
    {
        // animGate = GameObject.FindGameObjectsWithTag("AnimationGate").GetComponent<Animator>();
        animGate = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        distanceToButton = Vector3.Distance(box.position, button.position);
        if (Input.GetKeyDown(KeyCode.R))
        {
            //animGate.ResetTrigger("Crouch");
            animGate.SetTrigger("Open");
            animGate.SetBool("gate_down", true);
            //transform.position = new Vector3(0, -0.0719f, 0);


        }
    }
}    
