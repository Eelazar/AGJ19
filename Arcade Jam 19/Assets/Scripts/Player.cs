using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject tool;
    public GameObject anchor;

    public Vector3 com;

    private Vector2 input;

    public float smoothStep;
    private float velocity;

    private bool moveLock;

    void Start()
    {
        player.GetComponent<Rigidbody2D>().centerOfMass = com;
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

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    moveLock = true;
        //}
        if (Input.GetKeyUp(KeyCode.Space))
        {
            moveLock = !moveLock;
        }
    }
    void Rotate()
    {
        if (!moveLock)
        {
            Vector3 pos = tool.transform.position;
            pos.x += input.x;
            pos.y += input.y;
            pos.z = 0;

            Vector3 dir = pos - tool.transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            tool.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else if(moveLock)
        {
            anchor.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;

            Vector3 pos = anchor.transform.position;
            pos.x += input.x;
            pos.y += input.y;
            pos.z = 0;

            Vector3 dir = pos - anchor.transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            anchor.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    //void Rotate()
    //{
    //    if (!moveLock)
    //    {
    //        Vector3 pos = transform.position;
    //        pos.x += input.x;
    //        pos.y += input.y;
    //        pos.z = 0;

    //        Vector3 dir = pos - transform.position;
    //        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

    //        arm.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    //    }
    //    else
    //    {
    //        transform.parent.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;

    //        Vector3 pos = transform.parent.transform.position;
    //        pos.x += -input.x;
    //        pos.y += -input.y;
    //        pos.z = 0;

    //        Vector3 dir = pos - transform.parent.transform.position;
    //        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

    //        transform.parent.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    //    }
    //}

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + com, 0.1F);
    }
}
