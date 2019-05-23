using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixpointsscript : MonoBehaviour
{
    public Transform Affe;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(Affe.position.x, Affe.position.y, Affe.position.z);
    }
}
