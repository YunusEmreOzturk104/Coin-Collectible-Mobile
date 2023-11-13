using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCoin : MonoBehaviour
{
    public GameObject objectToSpawn; // Sahneye eklemek istedi�iniz nesne (�rne�in bir top)
    public Vector3 spawnAreaCenter; // Nesnenin rastgele spawn yap�laca�� alan�n merkezi
    public Vector2 spawnAreaSize;   // Nesnenin rastgele spawn yap�laca�� alan�n boyutlar�
    public float spawnInterval = 5f; // Yeni nesne spawn aral��� (saniye)

    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnRandomObject();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnRandomObject()
    {
        // Rastgele bir spawn noktas� hesaplan�yor
        float randomX = Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2);
        float randomZ = Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2);
        Vector3 spawnPosition = spawnAreaCenter + new Vector3(randomX, 0, randomZ);

        // Nesne olu�turulup spawn yap�l�yor
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
