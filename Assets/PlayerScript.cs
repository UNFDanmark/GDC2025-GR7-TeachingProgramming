using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 10;
    Rigidbody rb;
    public float speed = 10;

    public InputAction moveAction;
    
    void Start()
    {
        moveAction.Enable();
        
        int jegVirkerKunIStart = 10;
        print(health + jegVirkerKunIStart);
        
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

    }
}
