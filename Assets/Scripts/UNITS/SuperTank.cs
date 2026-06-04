using UnityEngine;

public class SuperTank : Tank
{
    private void Start()
    {
        Move();
        Attack();
    }

    public override void Move()
    {
        Debug.Log("Super Tank Moving");
    }

    public override void Attack()
    {
        Debug.Log("Super Tank Attacking");
    }
}
