using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramer : BadGuy // Polymorphism
{
    float speed = 0.5f;
    private CharacterController enemy;
    private PlayerScript player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerScript>();
        enemy = gameObject.GetComponent<CharacterController>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 direction = player.transform.position - transform.position;
            Vector3 velocity = direction * speed;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(velocity), speed * Time.deltaTime);
            enemy.Move(velocity * Time.deltaTime);
        }
        if (other.tag == "GoodGuy")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ram();
    }

    

}
