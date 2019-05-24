using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sound : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string LadleHit = "";

    public float minForce;
    private float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {/*
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Affe1" || collision.gameObject.tag == "Affe2"|| collision.gameObject.tag == "Affe3" || collision.gameObject.tag == "Affe4")
        {
            if (collision.relativeVelocity.magnitude > minForce)
            {
                damage = Mathf.Clamp(collision.relativeVelocity.magnitude,0,100);
                Debug.Log(damage);
                FMODUnity.RuntimeManager.PlayOneShot(Monkey);

                collision.gameObject.GetComponentInParent<AffenScript>().bananas -= damage;
            }
        }
        */
       // Debug.Log("collided");
        //foreach (ContactPoint2D contact in collision.contacts)
        //{
        //   // Debug.DrawRay(contact.point, contact.normal, Color.white);
          
        //}
       // Debug.Log(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude > 18)
        {
            FMODUnity.RuntimeManager.PlayOneShot(LadleHit);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
