using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static event Action<string> OnUnitPurchased;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Debug.Log("Game Manager Created");
        PurchaseUnit("Tank");
    }

    public void PurchaseUnit(string unitName)
    {
        Debug.Log(unitName + " purchased");

        OnUnitPurchased?.Invoke(unitName);
    }

}
