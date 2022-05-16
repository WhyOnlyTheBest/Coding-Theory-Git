using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] float speed;
    private GameObject Player;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector3 direction = Player.transform.position - transform.position;
        Vector3 velocity = direction * speed;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(velocity), speed * Time.deltaTime);
        transform.position += velocity * Time.deltaTime;

        if (time > 4)
        {
            Destroy(gameObject);
        }
    }
}
