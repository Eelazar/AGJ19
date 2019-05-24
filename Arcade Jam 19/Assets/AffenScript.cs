using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffenScript : MonoBehaviour {
    private Rigidbody2D rb;
    public float Jumpvalue;
    public GameObject Fixpoints;
    public GameManager gm;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameManager>() ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "out")
        {
            Destroy(gameObject);
        }
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
            gm.alive -= 1;
            Destroy(goa[i].gameObject);
        }
        Destroy(GetComponentInParent<Transform>().gameObject);
    }
}
