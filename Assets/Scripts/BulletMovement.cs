using UnityEngine;

public class BulletMovement : Movement
{
    [SerializeField] private Vector3 direction;

    private void Update()
    {
        rb.linearVelocity = direction * speed;
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection.normalized;
    }

}
