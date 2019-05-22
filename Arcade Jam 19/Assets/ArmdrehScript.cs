using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmdrehScript : MonoBehaviour {
    Rigidbody2D rb;
    HingeJoint2D hj;
    public float maxtorgue;
    public float torguevalue;
    public float boostAmount;
    private float boostlocal=1;
    public float impactAmount;
    public Transform Impactpoint;
    public GameObject AffeMitWaffe;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        hj = GetComponent<HingeJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.magnitude >= maxtorgue)
        {
            Debug.Log(rb.velocity);
            rb.velocity = rb.velocity.normalized * maxtorgue;

        }
        if (Input.GetKeyDown("k"))
        {
            AffeMitWaffe.SendMessage("Jump");
        }
        
        if (Input.GetKeyDown("i"))
        {
            rb.AddForceAtPosition(new Vector2(-transform.localPosition.x * impactAmount,- transform.localPosition.y * impactAmount), new Vector2(Impactpoint.position.x, Impactpoint.position.y));
            
        }
        

        if (Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f>=270f || f <= 90)
            {
                rb.AddTorque(torguevalue * boostlocal);

            }
            if (f >= 90f && f <= 270f)
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }

        }
        if (Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            float f = kuerzen();
            if (f <= 180)
            {
                rb.AddTorque(torguevalue * boostlocal);

            }
            if ( f>= 180 )
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }
        }
        if (Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f >= 270f || f <= 90)
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }
            if (f >= 90f && f <= 270f)
            {
                rb.AddTorque(torguevalue * boostlocal);

            }

        }
        if (Input.GetKey("d") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            float f = kuerzen();
            if (f <= 180)
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }
            if (f >= 180)
            {
                rb.AddTorque(torguevalue * boostlocal);

            }
        }
        if (Input.GetKey("w") && Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f >= 45f && f <= 225f)
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }
            if (f <= 45f || f >= 225f)
            {
                rb.AddTorque(torguevalue * boostlocal);

            }
        }
        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            float f = kuerzen();
            if (f >= 135f && f <= 315f)
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }
            if (f <= 135f || f >= 315f)
            {
                rb.AddTorque(torguevalue * boostlocal);

            }
        }
        if (Input.GetKey("a") && Input.GetKey("s"))
        {
            float f = kuerzen();
            if (f <= 225f && f>=45f)
            {
                rb.AddTorque(torguevalue * boostlocal);

            }
            if (f >= 225 || f <= 45)
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }
        }
        if (Input.GetKey("s") && Input.GetKey("d"))
        {
            float f = kuerzen();
            if (f <= 135f || f >= 315f)
            {
                rb.AddTorque(-torguevalue * boostlocal);

            }
            else 
              rb.AddTorque(torguevalue * boostlocal);

            
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
