using UnityEngine;

[CreateAssetMenu(fileName = "ClientData", menuName = "Scriptable Objects/ClientData")]
public class ClientData : ScriptableObject
{
    public GameObject prefab;
    public string orderName;
}
