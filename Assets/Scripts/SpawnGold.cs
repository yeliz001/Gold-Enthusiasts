using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGold : MonoBehaviour
{
    [SerializeField] private GameObject gold;

    void Start()
    {
        for (int i = 50; i <951 ; i+=150)
        {
            for (int j = 50; j < 951; j+=150)
            {
                Vector3 spawnPosition = new Vector3(i,50f,j);
                Instantiate(gold, spawnPosition,Quaternion.Euler(90f,0f,0f));
            }

        }
    }
}
