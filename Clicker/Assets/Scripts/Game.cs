using UnityEngine;
using UnityEngine.UI;
 
    public class Game : MonoBehaviour
{
    public Text scoreText;
    public GameObject pause;
    private int score;

    public void pause_showandhide ()
    {
        pause.SetActive(!pause.activeSelf); 
    }

    public void OnClick ()
    {
        score++;
        scoreText.text = score + " Point" ;

    }
}
