using UnityEngine;

public class bulletscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float destroyTimer = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroyTimer -= Time.deltaTime;
        print(destroyTimer);
        if (destroyTimer <= 0.0)
        {
            print("a");
            GameObject.Destroy(gameObject);
        }
    }
}
