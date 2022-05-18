using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    public GameObject m_Projectile;
    public Transform m_SpawnTransform;
    private float time = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move(); // Abstraction
        Rotate(); // Abstraction
        Shoot(); // Abstraction
        time += Time.deltaTime;
    }

    void Move()
    {

        // move up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed);
        }
        // move back
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

    void Shoot()
    {
        if (time > 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation);
                time = 0;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BadGuy")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
