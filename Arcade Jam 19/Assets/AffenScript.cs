using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffenScript : MonoBehaviour {
    private Rigidbody2D rb;
    public float Jumpvalue;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Jump()
    {
        Debug.Log("whadh");
        rb.AddForce(Vector2.up*Jumpvalue);
    }

}
