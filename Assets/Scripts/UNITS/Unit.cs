using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] protected float health = 100f;
    [SerializeField] protected float moveSpeed = 5f;

    public virtual void Move()
    {
        Debug.Log("Unit Moving");
    }

    public virtual void Attack()
    {
        Debug.Log("Unit Attacking");
    }

}
