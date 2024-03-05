using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FinishPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text winText;

    public void Update()
    {
        if(Collision.instance.score == 48)
        {
            winText.SetText("YOU WÝN");
            Timer.instance.timer = 0;
        }
        else
        {
            winText.SetText("GAME OVER\nSCORE:"+ Collision.instance.score);
        }

    }
    

}
