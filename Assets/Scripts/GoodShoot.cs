using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodShoot : MonoBehaviour
{
    private float m_Speed = 1000f;   // this is the projectile's speed
    private float m_Lifespan = 3f; // this is the projectile's lifespan (in seconds)

    /// <summary>
    /// Private fields
    /// </summary>
    private Rigidbody m_Rigidbody;

    /// <summary>
    /// Message that is called when the script instance is being loaded
    /// </summary>
    void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Message that is called before the first frame update
    /// </summary>
    void Start()
    {
        m_Rigidbody.AddForce(m_Rigidbody.transform.forward * m_Speed);
        Destroy(gameObject, m_Lifespan);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BadGuy")
        {
            Destroy(gameObject);
        }
    }
}
