using UnityEngine;
using System;

public class UnitCalculator : MonoBehaviour
{
    private void Start()
    {
        Func<int, int, int> CalculateTotalCost = (a, b) => a + b;

        int totalCost = CalculateTotalCost(100, 200);

        Debug.Log("Total Cost: " + totalCost);
    }


}
