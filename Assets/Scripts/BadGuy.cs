using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    private PlayerScript player;
    [SerializeField] float speed;
    private CharacterController enemy;
    [SerializeField] GameObject Bullet;
    [SerializeField] private float time;
    public GameObject m_Projectile;
    public Transform m_SpawnTransform;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerScript>();
        enemy = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
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
    }

    public void Shoot()
    {
            Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation);
            time = 0;
    }

    public void Ram()
    {
        speed = 3;
    }
}
