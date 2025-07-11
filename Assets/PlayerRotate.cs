using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public InputAction moveAction;
    public float rotationSpeed = 1;
    
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float rotateInput = moveAction.ReadValue<float>();
        
        transform.Rotate(0,rotateInput * rotationSpeed,0);
            
    }
}
