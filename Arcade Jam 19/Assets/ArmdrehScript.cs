using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmdrehScript : MonoBehaviour {
    Rigidbody2D rb;
    HingeJoint2D hj;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        hj = GetComponent<HingeJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {

        
        if (Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f>=270f || f <= 90)
            {
                rb.AddTorque(2500f);

            }
            if (f >= 90f && f <= 270f)
            {
                rb.AddTorque(-2500f);

            }

        }
        if (Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            float f = kuerzen();
            if (f <= 180)
            {
                rb.AddTorque(2500f);

            }
            if ( f>= 180 )
            {
                rb.AddTorque(-2500f);

            }
        }
        if (Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f >= 270f || f <= 90)
            {
                rb.AddTorque(-2500f);

            }
            if (f >= 90f && f <= 270f)
            {
                rb.AddTorque(2500f);

            }

        }
        if (Input.GetKey("d") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            float f = kuerzen();
            if (f <= 180)
            {
                rb.AddTorque(-2500f);

            }
            if (f >= 180)
            {
                rb.AddTorque(2500f);

            }
        }
        if (Input.GetKey("w") && Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f >= 45f && f <= 225f)
            {
                rb.AddTorque(-2500f);

            }
            if (f <= 45f || f >= 225f)
            {
                rb.AddTorque(2500f);

            }
        }
        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            float f = kuerzen();
            if (f >= 135f && f <= 315f)
            {
                rb.AddTorque(-2500f);

            }
            if (f <= 135f || f >= 315f)
            {
                rb.AddTorque(2500f);

            }
        }
        if (Input.GetKey("a") && Input.GetKey("s"))
        {
            float f = kuerzen();
            if (f <= 225f && f>=45f)
            {
                rb.AddTorque(2500f);

            }
            if (f >= 225 || f <= 45)
            {
                rb.AddTorque(-2500f);

            }
        }
        if (Input.GetKey("s") && Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f <= 135f || f >= 315f)
            {
                rb.AddTorque(-2500f);

            }
            else 
              rb.AddTorque(2500f);

            
        }

    }
    float kuerzen()
    {
        float f = transform.rotation.eulerAngles.z;
        if (f < 0) f *= -1;
        while (f > 360) f -= 360;
        return f;
    }
}
