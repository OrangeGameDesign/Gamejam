using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GateController : MonoBehaviour
{
    public Transform gate;
    public Transform button;
    public Transform box;
    public Transform key;
    public float gateSpeed = 2f;
    public float buttonRange = 2f;

    public bool boxOnButton = false;
    public bool keyTaken = false;
    public bool gateOpen = false;

    void Update()
    {
        // zjist� vzd�lenost mezi hr��em a battonem
        float distanceToButton = Vector3.Distance(transform.position, button.position);

        // pokud je hr�� v dosahu battonu
        if (distanceToButton < buttonRange)
        {
            // pokud hr�� p�esunul krabici na batton
            if (boxOnButton)
            {
                // zjist� vzd�lenost mezi hr��em a krabic�
                float distanceToBox = Vector3.Distance(transform.position, box.position);

                // pokud je hr�� na battonu a z�rove� krabice stoj� na battonu
                if (distanceToBox < buttonRange)
                {
                    // m�� br�ny sjede dol�
                    gate.position -= Vector3.up * Time.deltaTime * gateSpeed;

                    // zji��uje, jestli hr�� dr�� kl��
                    if (keyTaken)
                    {
                        // br�na je otev�en�
                        gateOpen = true;
                    }
                }
                else
                {
                    // krabice nen� na battonu, tak�e m�� pojede zase nahoru
                    // gate.position += Vector3.up * Time.deltaTime * gateSpeed;
                }
            }
            else
            {
                // hr�� nestoj� na battonu, tak�e m�� pojede zase nahoru
                gate.position += Vector3.up * Time.deltaTime * gateSpeed;
            }
        }
        else
        {
            // hr�� je p��li� daleko od battonu, tak�e m�� pojede zase nahoru
            gate.position += Vector3.up * Time.deltaTime * gateSpeed;
        }

        // pokud hr�� sebere kl��
        if (Vector3.Distance(transform.position, key.position) < buttonRange)
        {
            // kl�� zmiz�
            key.gameObject.SetActive(false);

            // pokud je krabice na battonu, br�na se otev�e
            if (boxOnButton)
            {
                gate.position -= Vector3.up * Time.deltaTime * gateSpeed;
                gateOpen = true;
            }

            // kl�� je vzat�
            keyTaken = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // pokud hr�� p�ijde do kontaktu s krabic�
        if (other.gameObject.CompareTag("Box"))
        {
            // krabice je na battonu
            boxOnButton = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // pokud hr�� opust� krabici
        if (other.gameObject.CompareTag("Box"))
        {
            // krabice nen� na battonu
            boxOnButton = false;
        }
    }
}
