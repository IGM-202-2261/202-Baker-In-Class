using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public AgentSO agentSO;

    public Agent prefab;

    public Agent clone;

    public int spawnCount = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agentSO.spawnManager = this;

        Spawn();
    }

    void Spawn()
    {
        agentSO.agents.Clear();

        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 spawnPos = new Vector2(0, 0);

            clone = Instantiate(prefab, spawnPos, Quaternion.identity);

            agentSO.agents.Add(clone);
        }

        ((TagPlayer)clone).currentState = PlayerState.It;
        agentSO.itPlayer = clone;
    }
}
