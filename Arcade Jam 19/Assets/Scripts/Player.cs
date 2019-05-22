using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject arm;

    public Vector3 com;

    private Vector2 input;

    public float smoothStep;
    private float velocity;

    private bool moveLock;

    void Start()
    {
        arm = transform.GetChild(0).gameObject;

        GetComponent<Rigidbody2D>().centerOfMass = com;
    }


    void Update()
    {
        GetInput();
        
    }

    void FixedUpdate()
    {
        Rotate();
    }

    void GetInput()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveLock = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            moveLock = false;
        }
    }

    void Rotate()
    {
        if (!moveLock)
        {
            Vector3 pos = transform.position;
            pos.x += input.x;
            pos.y += input.y;
            pos.z = 0;

            Vector3 dir = pos - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            arm.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            arm.transform.GetChild(0).GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;

            Vector3 pos = transform.position;
            pos.x += input.x;
            pos.y += input.y;
            pos.z = 0;

            Vector3 dir = pos - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            transform.RotateAround(arm.transform.GetChild(0).position, Vector3.forward, angle);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + com, 0.1F);
    }
}
