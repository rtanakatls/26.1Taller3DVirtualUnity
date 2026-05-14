
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PerlinNoiseTest : MonoBehaviour
{
    [SerializeField] private List<GameObject> levelPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    float noise = Mathf.PerlinNoise((transform.position.x + i) / 100f, (transform.position.z + j )/ 100f);
                    if (noise < 0.5f)
                    {
                        Instantiate(levelPrefabs[0], new Vector3(transform.position.x + i * 10, 0, transform.position.z + j * 10), default);
                    }
                    else
                    {
                        Instantiate(levelPrefabs[1], new Vector3(transform.position.x + i * 10, 0, transform.position.z + j * 10), default);
                    }

                }
            }

        }
    }

}
