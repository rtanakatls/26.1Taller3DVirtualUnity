using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : Movement
{
    private Vector2 lastDirection;

    [SerializeField] private InputActionReference movementInput;

    public Vector2 LastDirection {  get { return lastDirection; } }

    private void Start()
    {
        lastDirection = new Vector2(0,1);
    }

    void Update()
    {
        Vector2 movement = movementInput.action.ReadValue<Vector2>();
        if(movement.magnitude > 0)
        {
            lastDirection = movement;
        }

        rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y, movement.y * speed);

    }
}
