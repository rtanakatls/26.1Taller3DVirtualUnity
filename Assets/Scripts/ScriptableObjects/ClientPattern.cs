using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ClientPattern", menuName = "Scriptable Objects/ClientPattern")]
public class ClientPattern : ScriptableObject
{
    public List<ClientData> clientDataList;
}
