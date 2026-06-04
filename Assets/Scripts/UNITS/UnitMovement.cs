using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;

    private Transform target;

    private void Start()
    {
        target = GameObject.Find("BaseEnemy").transform;
    }

    private void Update()
    {
        if (target == null)
            return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            moveSpeed * Time.deltaTime);
    }




}
