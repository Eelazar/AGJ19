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
    public Transform Rechenpunkt;
    public Transform ObenLinks;
    public Transform Oben;
    public Transform ObenRechts;
    public Transform Rechts;
    public Transform UntenRechts;
    public Transform Unten;
    public Transform UntenLinks;
    public Transform Links;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        hj = GetComponent<HingeJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.magnitude >= maxtorgue)
        {
            rb.velocity = rb.velocity.normalized * maxtorgue;

        }
        if (Input.GetKeyDown("k"))
        {
            AffeMitWaffe.SendMessage("Jump");
        }
        
        if (Input.GetKeyDown("i"))
        {
            rb.AddForceAtPosition(new Vector2(Impactpoint.position.x - transform.position.x, Impactpoint.position.y - transform.position.x).normalized * impactAmount, new Vector2(Impactpoint.position.x,Impactpoint.position.y));
            
        }
        

        if (Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
            {
                rb.AddTorque(-torguevalue);
            }
            else rb.AddTorque(torguevalue);
        }
        if (Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
            {
                rb.AddTorque(-torguevalue);
            }
            else rb.AddTorque(torguevalue);
        }
        if (Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
                
            }
        if (Input.GetKey("d") && !Input.GetKey("w") && !Input.GetKey("s"))
        {
            if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
            {
                rb.AddTorque(torguevalue);
            }
            else rb.AddTorque(-torguevalue);
        }
        if (Input.GetKey("w") && Input.GetKey("d"))
        {
            if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
            {
                rb.AddTorque(torguevalue);
            }
            else rb.AddTorque(-torguevalue);
        }
        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
            {
                rb.AddTorque(torguevalue);
            }
            else rb.AddTorque(-torguevalue);
        }
        if (Input.GetKey("a") && Input.GetKey("s"))
        {
            if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
            {
                rb.AddTorque(-torguevalue);
            }
            else rb.AddTorque(torguevalue);
        }
        if (Input.GetKey("s") && Input.GetKey("d"))
        {
            if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
            {
                rb.AddTorque(-torguevalue);
            }
            else rb.AddTorque(torguevalue);
        }

    }
    
}
