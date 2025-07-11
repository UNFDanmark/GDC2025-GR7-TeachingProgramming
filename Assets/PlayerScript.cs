using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 10;
    public Rigidbody rb;
    public float Speed = 10;
    string navn = "Kasper";
    float weigth = 13.7f;
    bool erPåGdc = true;
    
    void Start()
    {
        int jegVirkerKunIStart = 10;
        print(health + jegVirkerKunIStart);
    }

    // Update is called once per frame
    void Update()
    {
        int jegVirkerKunIUpdate = 8;
        print(health + jegVirkerKunIUpdate);
    }
}
