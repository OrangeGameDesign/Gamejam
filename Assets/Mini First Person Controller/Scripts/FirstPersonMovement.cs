using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;

    Rigidbody rigidbody;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();



    void Awake()
    {
        // Get the rigidbody on this.
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Update IsRunning from input.
        IsRunning = canRun && Input.GetKey(runningKey);

        // Get targetMovingSpeed.
        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Get targetVelocity from input.
        Vector2 targetVelocity =new Vector2( Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        // Apply movement.
        rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GateOne")
        {
            print("Ahoj");
            transform.position = new Vector3(31, 1, 14);

        }
        if (collision.gameObject.tag == "GateTwo")
        {
            print("Ahoj");
            transform.position = new Vector3(7, 1, 15);

        }
        if (collision.gameObject.tag == "GateThree")
        {
            print("Ahoj");
            transform.position = new Vector3(7.94f, 1.11f, 14.34f);
           
        }
        if (collision.gameObject.tag == "GateFour")
        {
            print("Ahoj");
            transform.position = new Vector3(18.85f, 1.08f, 3.21f);

        }




    }
}