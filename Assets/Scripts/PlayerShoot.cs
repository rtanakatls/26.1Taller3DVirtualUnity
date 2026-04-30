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
        if(shootInput.action.WasPressedThisFrame())
        {
            Vector3 shootDirection= new Vector3(playerMovement.LastDirection.x,0, playerMovement.LastDirection.y);
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.GetComponent<BulletMovement>().SetDirection(shootDirection);
        }
    }
}
