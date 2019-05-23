using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sound : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string LadleHit = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        foreach (ContactPoint2D contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
          
        }
        Debug.Log(collision.relativeVelocity.magnitude);
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
