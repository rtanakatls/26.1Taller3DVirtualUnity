using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : Movement
{
    private Vector3 lastDirection;
    [SerializeField] private InputActionReference movementInput;

    public Vector3 LastDirection { get => lastDirection;}

    private void Start()
    {
        lastDirection= transform.forward;
    }

    void Update()
    {
        Vector2 direction = movementInput.action.ReadValue<Vector2>();

        if (direction.magnitude > 0)
        {
            lastDirection = new Vector3(direction.normalized.x, 0, direction.normalized.y);
        }

        rb.linearVelocity = new Vector3(speed * direction.x, rb.linearVelocity.y, speed * direction.y);
    }
}
