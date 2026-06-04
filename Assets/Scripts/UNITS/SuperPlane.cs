using UnityEngine;

public class SuperPlane : Unit
{
    private void Start()
    {
        Move();
        Attack();
    }

    public override void Move()
    {
        Debug.Log("Super Plane Moving");
    }

    public override void Attack()
    {
        Debug.Log("Super Plane Attacking");
    }
}
