using UnityEngine;

public class UnitObserver : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.OnUnitPurchased += OnUnitPurchased;
    }

    private void OnDisable()
    {
        GameManager.OnUnitPurchased -= OnUnitPurchased;
    }

    private void OnUnitPurchased(string unitName)
    {
        Debug.Log("Observer detected purchase: " + unitName);
    }
}
