using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncAppearance : MonoBehaviour
{
    public Image rend;
    public BoxCollider colider;
    public float minimum = 1F, speed=1f;
    public float maximum = 2F;
    void OnMouseDown()
    {
        transform.localScale = new Vector3(speed* Time.deltaTime, speed * Time.deltaTime, 0.0f);
    }

}