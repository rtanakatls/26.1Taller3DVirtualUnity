using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private List<LevelPattern> levelPatterns;
    [SerializeField] private NavMeshSurface navMeshSurface;
    private LevelPattern currentPattern;
    private int seed;
    private int currentIndex;
    private void Awake()
    {
        seed= Random.Range(0, int.MaxValue);
        currentPattern=levelPatterns[seed % levelPatterns.Count];
        GenerateLevel();
    }

    private void GenerateLevel()
    {
        currentIndex =0;
        for(int i=0;i<10;i++)
        {
            GameObject obj = Instantiate(currentPattern.prefabPattern[currentIndex % currentPattern.prefabPattern.Count]);
            obj.transform.position = transform.position;
            transform.position += transform.forward * 10;
            currentIndex++;
        }
        navMeshSurface.BuildNavMesh();
    }

}
