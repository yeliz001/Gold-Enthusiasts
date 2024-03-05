using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 newPosition;
    private Vector3 currentPlayerPosition;
    [SerializeField] private float speed;


    // Update is called once per frame
    void Update()
    {
        if (Joystick.instance.movement==true)
        {
            newPosition.x = Joystick.instance.distance.x * speed * Time.deltaTime;
            newPosition.z = Joystick.instance.distance.y * speed * Time.deltaTime;
            newPosition.y = 0;

            transform.position += newPosition;

            currentPlayerPosition = transform.position;
            currentPlayerPosition.x = Mathf.Clamp(currentPlayerPosition.x, 0, 1000);
            currentPlayerPosition.z = Mathf.Clamp(currentPlayerPosition.z, 0, 1000);
            transform.position = currentPlayerPosition;
        }       
    }
}
