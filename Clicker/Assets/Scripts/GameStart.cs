using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public GameObject buttons;
    public Text GameName;
    public BoxCollider colider;
    public Image rend;

    private void OnMouseUpAsButton()
    {
        
        colider.enabled = true;
        
        rend.enabled = true;
        GameName.text = "0";
        buttons.GetComponent<SlidingButtons>().speed = -10f;
        buttons.GetComponent<SlidingButtons>().checkPos = -600f;
    }
}
