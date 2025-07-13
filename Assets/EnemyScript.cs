using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent agent;
    GameObject playerTarget;

    public Animator Animator;
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Jeg er ond");
        playerTarget = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerTarget.transform.position);
        
        Animator.SetFloat("Speed", agent.velocity.magnitude);
        print("speed is " + agent.velocity.magnitude);
    }


    void OnCollisionEnter(Collision other)
    
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        
    }
}
