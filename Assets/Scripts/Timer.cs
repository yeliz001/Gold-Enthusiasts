using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    public float timer;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private GameObject TimeText;
    [SerializeField] private GameObject FinishPanel;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timeText.SetText("Time : " + (int)timer);       
        }

        if (timer <= 0)
        {
            TimeText.SetActive(false);
            FinishPanel.SetActive(true);
            Joystick.instance.movement = false;
        }
    }
    
}
