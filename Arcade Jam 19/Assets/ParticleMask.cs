using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMask : MonoBehaviour
{
    public ParticleSystemRenderer psr;
    public SpriteMaskInteraction maskInteraction;

    void Start()
    {
        psr = GetComponent<ParticleSystemRenderer>();
    }

    void Update()
    {
        psr.maskInteraction = maskInteraction;
    }

    void OnGUI()
    {
      //  maskInteraction = (SpriteMaskInteraction)GUI.SelectionGrid(new Rect(25, 25, 900, 30), (int)maskInteraction, new GUIContent[] { new GUIContent("No Masking"), new GUIContent("Visible Inside Mask"), new GUIContent("Visible Outside Mask") }, 3);
    }
}
