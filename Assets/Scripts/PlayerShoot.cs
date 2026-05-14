using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    private PlayerMovement playerMovement;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private InputActionReference shootInput;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (shootInput.action.WasCompletedThisFrame())
        {
            Vector3 shootDirection = playerMovement.LastDirection;
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(shootDirection);

        }
    }

}
