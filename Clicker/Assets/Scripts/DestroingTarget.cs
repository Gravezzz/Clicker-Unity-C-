using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroingTarget : MonoBehaviour
{
    private BoxCollider colider;
    public Image rend;
    void Start()
    {
        colider = GetComponent<BoxCollider>();
        colider.enabled = false;
        rend = GetComponent<Image>();
        rend.enabled=false;
    }

}
