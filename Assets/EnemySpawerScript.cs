using UnityEngine;

public class EnemySpawerScript : MonoBehaviour
{
    public GameObject enemy;

    public float spawnCooldown = 2f;

    float currentSpawnTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            
            Instantiate(enemy, spawnPosition, Quaternion.identity);
            currentSpawnTime = spawnCooldown;
        }
        
        
    }
}
