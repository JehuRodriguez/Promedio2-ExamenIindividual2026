using UnityEngine;

public class Helicopter : Unit
{
    private void Start()
    {
        Move();
        Attack();
    }

    public override void Move()
    {
        Debug.Log("Helicopter Moving");
    }

    public override void Attack()
    {
        Debug.Log("Helicopter Attacking");
    }
}
