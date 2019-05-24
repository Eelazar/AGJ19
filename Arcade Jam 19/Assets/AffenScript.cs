using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffenScript : MonoBehaviour {
    private Rigidbody2D rb;
    public float Jumpvalue;
    public GameObject Fixpoints;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Jump()
    {

        rb.AddForce(Vector2.up*Jumpvalue);
    }
    private void OnDestroy()
    {
        Destroy(Fixpoints.gameObject);
        Transform[] goa=GetComponentsInChildren<Transform>();
        for(int i = 0; i<goa.Length; i++)
        {
            Destroy(goa[i].gameObject);
        }
        Destroy(GetComponentInParent<Transform>().gameObject);
    }
}
