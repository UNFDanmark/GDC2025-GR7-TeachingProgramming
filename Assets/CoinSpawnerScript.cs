using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public GameObject coin;

    public float spawnCooldown = 2f;

    float currentSpawnTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpawnTime -= Time.deltaTime;

        if (currentSpawnTime <= 0)
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.x += Random.Range(-5, 5);
            spawnPosition.z += Random.Range(-5, 5);
            spawnPosition.y += 1;
            
            Instantiate(coin, spawnPosition, coin.transform.rotation);
            
            
            
            currentSpawnTime = spawnCooldown;
        }
    }
}
