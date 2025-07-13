using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 3;
    Rigidbody rb;
    public float speed = 10;

    public Animator Animator;

    public InputAction moveAction;

    public GameObject gameOverScreen;

    public InputAction restartAction;

    public  TextMeshProUGUI TextMeshProUGUI;
    
    void Start()
    {
        moveAction.Enable();

        restartAction.Enable();
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int jegVirkerKunIUpdate = 8;
        //print(health + jegVirkerKunIUpdate);

        if(speed > 18)
        {
            //print("Du er hurtig");
        }
        else
        {
            //print("Du er ikke så hurtig");
        }

        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        Vector3 newVelocity = rb.linearVelocity;

        newVelocity.x = moveInput.x * speed;
        newVelocity.z = moveInput.y * speed;

        rb.linearVelocity = newVelocity;
        
        Animator.SetFloat("Speed", rb.linearVelocity.magnitude);

        if (restartAction.WasPressedThisFrame())
        {
            SceneManager.LoadScene("kage");
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
            
            TextMeshProUGUI.SetText("Health: " + health + "/3");
        }

        if (health <= 0)
        {
            gameOverScreen.SetActive(true);
        }
    }
}
