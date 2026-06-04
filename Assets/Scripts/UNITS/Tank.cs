using UnityEngine;

public class Tank : Unit,IDamageable
{

    public void TakeDamage(float damage)
    {
        health -= damage;

        Debug.Log("Tank Health: " + health);
    }

    private void Start()
    {
        Move();
        Attack();

        TakeDamage(20);
    }


    public override void Move()
    {
        Debug.Log("Tank Moving");
    }

    public override void Attack()
    {
        Debug.Log("Tank Attacking");
    }

}
