using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawn : MonoBehaviour
{
    public Image rend;
    public BoxCollider colider;
    public GameObject Target;
    public Text GameName;

    public int X, Y, score=0;

    private void OnMouseUp()
    {
        int XPos, YPos;
        X = Random.Range(-2, 2);
        XPos = X;
        Y = Random.Range(-4, 3);
        YPos = Y;
        Target.transform.position = new Vector3(XPos, YPos, 0);

        score++;
        GameName.text = score + " Point";

    }

}