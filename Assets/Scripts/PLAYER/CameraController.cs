using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 100f;

    private float verticalRotation = 0f;

    private void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");

        verticalRotation -= mouseY * mouseSensitivity * Time.deltaTime;

        verticalRotation = Mathf.Clamp(verticalRotation, -30f, 60f);

        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
