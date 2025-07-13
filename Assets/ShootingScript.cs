using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject bullet;
    public float bulletSpeed = 5f;
    
    public InputAction shoot;

    AudioSource audioSource;
    
    public float cooldown = 0.5f;
    float cooldownLeft;

    public Animator Animator;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        shoot.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        cooldownLeft -= Time.deltaTime;
        
        if (shoot.WasPressedThisFrame() && cooldownLeft <= 0)
        {
            GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody bulletrb = bulletClone.GetComponent<Rigidbody>();
            bulletrb.linearVelocity = transform.forward * bulletSpeed;

            audioSource.Play();
            audioSource.pitch = Random.Range(0.5f, 1.5f);
            
            
            
            cooldownLeft = cooldown;
            Animator.SetTrigger("Shoot");
            
        }
    }
}
