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
        // zjistÌ vzd·lenost mezi hr·Ëem a battonem
        float distanceToButton = Vector3.Distance(transform.position, button.position);

        // pokud je hr·Ë v dosahu battonu
        if (distanceToButton < buttonRange)
        {
            // pokud hr·Ë p¯esunul krabici na batton
            if (boxOnButton)
            {
                // zjistÌ vzd·lenost mezi hr·Ëem a krabicÌ
                float distanceToBox = Vector3.Distance(transform.position, box.position);

                // pokud je hr·Ë na battonu a z·roveÚ krabice stojÌ na battonu
                if (distanceToBox < buttonRange)
                {
                    // m¯Ìû br·ny sjede dol˘
                    gate.position -= Vector3.up * Time.deltaTime * gateSpeed;

                    // zjiöùuje, jestli hr·Ë drûÌ klÌË
                    if (keyTaken)
                    {
                        // br·na je otev¯en·
                        gateOpen = true;
                    }
                }
                else
                {
                    // krabice nenÌ na battonu, takûe m¯Ìû pojede zase nahoru
                    // gate.position += Vector3.up * Time.deltaTime * gateSpeed;
                }
            }
            else
            {
                // hr·Ë nestojÌ na battonu, takûe m¯Ìû pojede zase nahoru
                gate.position += Vector3.up * Time.deltaTime * gateSpeed;
            }
        }
        else
        {
            // hr·Ë je p¯Ìliö daleko od battonu, takûe m¯Ìû pojede zase nahoru
            gate.position += Vector3.up * Time.deltaTime * gateSpeed;
        }

        // pokud hr·Ë sebere klÌË
        if (Vector3.Distance(transform.position, key.position) < buttonRange)
        {
            // klÌË zmizÌ
            key.gameObject.SetActive(false);

            // pokud je krabice na battonu, br·na se otev¯e
            if (boxOnButton)
            {
                gate.position -= Vector3.up * Time.deltaTime * gateSpeed;
                gateOpen = true;
            }

            // klÌË je vzat˝
            keyTaken = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // pokud hr·Ë p¯ijde do kontaktu s krabicÌ
        if (other.gameObject.CompareTag("Box"))
        {
            // krabice je na battonu
            boxOnButton = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // pokud hr·Ë opustÌ krabici
        if (other.gameObject.CompareTag("Box"))
        {
            // krabice nenÌ na battonu
            boxOnButton = false;
        }
    }
}
