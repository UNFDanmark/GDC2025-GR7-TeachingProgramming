using System;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float rotationSpeed = 2f;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotationSpeed);
    }
}
