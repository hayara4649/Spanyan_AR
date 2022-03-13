using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//spanyanにつけるやつ
public class Spanyan : MonoBehaviour
{
    [SerializeField] int spanyan_array;
    [SerializeField] bool isFounded;
    public GameManager gameManager;
    // [SerializeField] GameObject particle;

    Spanyan()
    {
        isFounded = false;
        // gameManager = GameObject.FindObjectOfType<GameManager>();
        // particleSystem = GetComponent<ParticleSystem>();
    }

    public void Found()
    {
        isFounded = true;
        // Instantiate(particle, transform.position, Quaternion.identity);
        gameManager.Array_update(spanyan_array);
    }
}
