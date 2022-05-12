using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move(); // Abstraction
        Rotate(); // Abstraction
    }

    void Move()
    {

        // move up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed);
        }
        // move bacl
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed);
        }
    }
    void Rotate()
    {
        // rotate left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0,-1,0);
        }

        // rotate right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }

    }
}
