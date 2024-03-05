using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public static Collision instance;

    [SerializeField] private GameObject ScoreText;
    public TMP_Text scoreText;
    public int score=-1;


    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gold"))
        {
            score++;
            scoreText.SetText("Score : " + score);
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if (Timer.instance.timer <= 0)
        {
            ScoreText.SetActive(false);
        }
    }
}
