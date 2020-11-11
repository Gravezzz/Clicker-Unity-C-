using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingButtons : MonoBehaviour
{
    public float speed = 7f, checkPos = 0;
    private RectTransform rec;

    void Start()
    {
        rec = GetComponent <RectTransform> ();
    }
    private void Update()
    {
        if(rec.offsetMin.y != checkPos)
        {
            rec.offsetMin += new Vector2(rec.offsetMin.x, speed);
            rec.offsetMax += new Vector2(rec.offsetMax.x, speed);
        }
              
    }
}
 