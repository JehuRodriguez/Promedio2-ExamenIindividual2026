using UnityEngine;

public class AIUnitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject tankPrefab;
    [SerializeField] private GameObject superTankPrefab;

    [SerializeField] private Transform spawnPoint;

    [SerializeField] private float spawnInterval = 10f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnRandomUnit();
            timer = 0f;
        }
    }

    private void SpawnRandomUnit()
    {
        int randomNumber = Random.Range(0, 2);

        if (randomNumber == 0)
        {
            Debug.Log("AI Spawned Tank");
            Instantiate(tankPrefab, spawnPoint.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("AI Spawned SuperTank");
            Instantiate(superTankPrefab, spawnPoint.position, Quaternion.identity);
        }
    }

}
