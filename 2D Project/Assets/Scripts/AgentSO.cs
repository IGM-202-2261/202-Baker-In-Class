using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AgentSO", order = 1)]
public class AgentSO : ScriptableObject
{
    public List<Agent> agents;

    public SpawnManager spawnManager;

}
