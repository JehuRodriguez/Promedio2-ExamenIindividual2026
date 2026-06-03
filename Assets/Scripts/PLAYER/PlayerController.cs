using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 100f;

    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    private void Update()
    {
        Move();
        Rotate();

    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * mouseX, rotationSpeed * Time.deltaTime);
    }





}
