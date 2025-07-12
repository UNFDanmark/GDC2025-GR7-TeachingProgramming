using System;
using UnityEditor.PackageManager;
using UnityEngine;

public class AIEyes : MonoBehaviour
{
    bool hitSomething;
    RaycastHit hit;

    public float sightDistance;
    
    
    public GameObject bullet;
    public float bulletSpeed = 5f;
    public float cooldown = 0.5f;
    float cooldownLeft;

    public GameObject shootingPoint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitSomething = Physics.Raycast(transform.position, transform.forward, out hit, sightDistance);

        if (hitSomething)
        {
            if (hit.transform.CompareTag("Player"))
            {
                print("hi player");
                
                cooldownLeft -= Time.deltaTime;
                
                if(cooldownLeft <0)
                {
                    print("hello");
                    GameObject bulletClone = Instantiate(bullet, shootingPoint.transform.position, Quaternion.identity);
                    Rigidbody bulletrb = bulletClone.GetComponent<Rigidbody>();
                    bulletrb.linearVelocity = transform.forward * bulletSpeed;
            
                    cooldownLeft = cooldown;
                }
                
            }
            else
            {
                print("i cant see you");
            }
        }
        else
        {
            print("nothing");
        }
        
        

        
    }

    void OnDrawGizmos()
    {
        if (hitSomething && hit.transform.CompareTag("Player"))
        {
            print("test");
            
            Gizmos.color = Color.green;
            
        }
        else
        {
            Gizmos.color = Color.red;
        }
        Gizmos.DrawRay(transform.position, transform.forward * sightDistance);
    }
}

