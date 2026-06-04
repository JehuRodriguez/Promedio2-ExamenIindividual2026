using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float attackDistance = 2f;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position,target.position);

        if (distance > attackDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position,target.position,moveSpeed * Time.deltaTime);
        }
        else
        {
            Debug.Log("Enemy Attacking");
        }
    }
}
