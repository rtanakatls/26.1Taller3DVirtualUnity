using UnityEngine;

public class BulletMovement : Movement
{
    private Vector3 direction;

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }

    void Update()
    {
        rb.linearVelocity = speed * direction;
    }
}
