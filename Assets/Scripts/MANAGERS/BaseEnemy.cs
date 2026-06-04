using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Tank>() != null)
        {
            Debug.Log("VICTORY");
        }
    }
}
