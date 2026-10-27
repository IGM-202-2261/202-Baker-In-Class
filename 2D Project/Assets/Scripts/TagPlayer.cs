using UnityEngine;

public enum PlayerState
{
    NotIt,
    It,
    Counting
}

public class TagPlayer : Agent
{
    public GameObject target;

    public PlayerState currentState = PlayerState.NotIt;

    public float seekWeight = 1f, boundsWeight = 1f;

    public float tagRadius = 2f;

    protected override Vector3 CalcSteering()
    {
        totalForce = Vector3.zero;

        totalForce = new Vector3(Random.value, Random.value, 0);

        totalForce += CheckBounds(0f) * boundsWeight;

        switch (currentState)
        {
            case PlayerState.NotIt:
                totalForce += Flee(agentSO.itPlayer.transform.position);
                break;
            case PlayerState.It:
                target = FindNearest().gameObject;

                if(Vector3.Distance(transform.position, target.transform.position) <= tagRadius)
                {
                    currentState = PlayerState.NotIt;

                    target.GetComponent<TagPlayer>().currentState = PlayerState.It;
                    agentSO.itPlayer = target.GetComponent<TagPlayer>();
                }
                else
                {

                    totalForce += Seek(target.gameObject);
                }

                break;
            case PlayerState.Counting:
                velocity = Vector3.zero;
                break;
        }

        return totalForce;
    }
}
