using UnityEngine;

public class AirDefense : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;

    private Transform enemy;

    private void Start()
    {
        GameObject enemyObject = GameObject.Find("Enemy");

        if (enemyObject != null)
        {
            enemy = enemyObject.transform;
        }
    }

    private void Update()
    {
        if (enemy == null)
            return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            enemy.position,
            moveSpeed * Time.deltaTime);
    }

}
