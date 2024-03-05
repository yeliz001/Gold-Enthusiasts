using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public static Joystick instance;

    private Vector2 firstPosition;
    private Vector2 mousePosition;
    private Vector2 currentPosition;
    public Vector2 distance;

    private float x;
    private float y;
    private float z;

    public bool movement=false;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        firstPosition = transform.position;
    }
    void Update()
    {
        mousePosition = Input.mousePosition;

        x = mousePosition.x - firstPosition.x;
        y = mousePosition.y - firstPosition.y;
        z = x * x + y * y;
        z = Mathf.Sqrt(z);


        if (Input.GetMouseButton(0) && z<50)
        {
            if (Timer.instance.timer > 0)
            {
            transform.position = mousePosition;
            }
            movement = true;
            currentPosition = transform.position;
            distance = currentPosition - firstPosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            movement = false;
            transform.position = firstPosition;
        }
    }
}
