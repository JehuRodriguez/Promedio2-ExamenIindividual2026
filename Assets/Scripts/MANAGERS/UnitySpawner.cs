using UnityEngine;

public class UnitySpawner : MonoBehaviour
{

    [SerializeField] private GameObject tankPrefab;
    [SerializeField] private GameObject superTankPrefab;
    [SerializeField] private GameObject helicopterPrefab;
    [SerializeField] private GameObject superPlanePrefab;

    [SerializeField] private Transform spawnPoint;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnUnit(tankPrefab);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpawnUnit(superTankPrefab);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SpawnUnit(helicopterPrefab);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SpawnUnit(superPlanePrefab);
        }
    }

    private void SpawnUnit(GameObject unitPrefab)
    {
        Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity);
    }
}
