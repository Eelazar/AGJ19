using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmdrehScript : MonoBehaviour {
    public Affenwerte affevalues;
    Rigidbody2D rb;
    HingeJoint2D hj;
    public float maxtorgue;
    public float torguevalue;
    public float boostAmount;
    private float boostlocal=1;
    public float mincol;
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
        maxtorgue = affevalues.Maxtorgue;
        torguevalue = affevalues.torgueValue;
        impactAmount = affevalues.Impactamount;
        mincol = 20;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.magnitude >= maxtorgue)
        {
            rb.velocity = rb.velocity.normalized * maxtorgue;

        }

        if (tag == "p1")
        {
           
            if (Input.GetKeyDown(KeyCode.Period))
            {
                AffeMitWaffe.SendMessage("Jump");
            }

            if (Input.GetKeyDown(KeyCode.Slash))
            {
                rb.AddForceAtPosition(new Vector2(Impactpoint.position.x - transform.position.x, Impactpoint.position.y - transform.position.x).normalized * impactAmount, new Vector2(Impactpoint.position.x, Impactpoint.position.y));

            }


            if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
            {
                if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
            {
                if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
            {
                if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);

            }
            if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
            {
                if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
            {
                if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
        }
        if (tag == "p2")
        {
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                AffeMitWaffe.SendMessage("Jump");
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                rb.AddForceAtPosition(new Vector2(Impactpoint.position.x - transform.position.x, Impactpoint.position.y - transform.position.x).normalized * impactAmount, new Vector2(Impactpoint.position.x, Impactpoint.position.y));

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
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
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
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
        }
        if (tag == "p3")
        {
            if (Input.GetKeyDown("g"))
            {
                AffeMitWaffe.SendMessage("Jump");
            }

            if (Input.GetKeyDown("h"))
            {
                rb.AddForceAtPosition(new Vector2(Impactpoint.position.x - transform.position.x, Impactpoint.position.y - transform.position.x).normalized * impactAmount, new Vector2(Impactpoint.position.x, Impactpoint.position.y));

            }


            if (Input.GetKey("i") && !Input.GetKey("j") && !Input.GetKey("l"))
            {
                if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey("j") && !Input.GetKey("i") && !Input.GetKey("k"))
            {
                if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey("k") && !Input.GetKey("j") && !Input.GetKey("l"))
            {
                if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);

            }
            if (Input.GetKey("l") && !Input.GetKey("i") && !Input.GetKey("k"))
            {
                if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
            if (Input.GetKey("i") && Input.GetKey("l"))
            {
                if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
            if (Input.GetKey("i") && Input.GetKey("j"))
            {
                if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey("j") && Input.GetKey("k"))
            {
                if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey("k") && Input.GetKey("l"))
            {
                if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
        }
        if (tag == "p4")
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                AffeMitWaffe.SendMessage("Jump");
            }

            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                rb.AddForceAtPosition(new Vector2(Impactpoint.position.x - transform.position.x, Impactpoint.position.y - transform.position.x).normalized * impactAmount, new Vector2(Impactpoint.position.x, Impactpoint.position.y));

            }


            if (Input.GetKey(KeyCode.Keypad8) && !Input.GetKey(KeyCode.Keypad4) && !Input.GetKey(KeyCode.Keypad6))
            {
                if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.Keypad4) && !Input.GetKey(KeyCode.Keypad8) && !Input.GetKey(KeyCode.Keypad5))
            {
                if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.Keypad5) && !Input.GetKey(KeyCode.Keypad4) && !Input.GetKey(KeyCode.Keypad6))
            {
                if ((Rechts.position - Rechenpunkt.position).magnitude >= (Links.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);

            }
            if (Input.GetKey(KeyCode.Keypad6) && !Input.GetKey(KeyCode.Keypad8) && !Input.GetKey(KeyCode.Keypad5))
            {
                if ((Oben.position - Rechenpunkt.position).magnitude >= (Unten.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
            if (Input.GetKey(KeyCode.Keypad8) && Input.GetKey(KeyCode.Keypad6))
            {
                if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
            if (Input.GetKey(KeyCode.Keypad8) && Input.GetKey(KeyCode.Keypad4))
            {
                if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.Keypad4) && Input.GetKey(KeyCode.Keypad5))
            {
                if ((ObenLinks.position - Rechenpunkt.position).magnitude >= (UntenRechts.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(-torguevalue);
                }
                else rb.AddTorque(torguevalue);
            }
            if (Input.GetKey(KeyCode.Keypad5) && Input.GetKey(KeyCode.Keypad6))
            {
                if ((ObenRechts.position - Rechenpunkt.position).magnitude >= (UntenLinks.position - Rechenpunkt.position).magnitude)
                {
                    rb.AddTorque(torguevalue);
                }
                else rb.AddTorque(-torguevalue);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.tag == "Affe2" || collision.transform.tag == "Affe3" || collision.transform.tag == "Affe4" || collision.transform.tag == "Affe1")
        {
            
            if (collision.relativeVelocity.magnitude > mincol)
            {
                Destroy(collision.gameObject);
            }
        }
        /*
        if (tag == "p1")
        {
            if (tag == "Player")
            {
                Debug.Log("Geilon");
                return;
            }
            if(collision.transform.tag == "Affe2" || collision.transform.tag == "Affe3" || collision.transform.tag == "Affe4" || collision.transform.tag=="Affe1")
            {
                if (collision.relativeVelocity.magnitude > mincol)
                {
                    Destroy(collision.gameObject);
                }
            }
        }
        if (tag == "p2")
        {
            if (collision.transform.tag == "Affe1" || collision.transform.tag == "Affe3" || collision.transform.tag == "Affe4")
            {
                if (collision.relativeVelocity.magnitude > mincol)
                {
                    Destroy(collision.gameObject);
                }
            }

        }
        if (tag == "p3")
        {
            if (collision.transform.tag == "Affe1" || collision.transform.tag == "Affe2" || collision.transform.tag == "Affe4")
            {
                if (collision.relativeVelocity.magnitude > mincol)
                {
                    Destroy(collision.gameObject);
                }
            }
        }
        if (tag == "p4")
        {
            if (collision.transform.tag == "Affe1" || collision.transform.tag == "Affe2" || collision.transform.tag == "Affe3")
            {
                if (collision.relativeVelocity.magnitude > mincol)
                {
                    Destroy(collision.gameObject);
                }
            }
            
     
    }
    */
    }
}
