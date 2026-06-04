using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    [SerializeField] private GameObject robotModel;
    [SerializeField] private GameObject vehicleModel;

    private bool isRobot = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TransformPlayer();
        }
    }

    private void TransformPlayer()
    {
        isRobot = !isRobot;

        robotModel.SetActive(isRobot);
        vehicleModel.SetActive(!isRobot);
    }

}
