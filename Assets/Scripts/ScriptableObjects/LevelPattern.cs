using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelPattern", menuName = "Scriptable Objects/LevelPattern")]
public class LevelPattern : ScriptableObject
{
    public List<GameObject> prefabPattern;
}
