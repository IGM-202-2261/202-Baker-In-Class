using UnityEngine;

public class Seeker : Agent
{
    public GameObject target;

    public float seekWeight, boundsWeight;

    protected override Vector3 CalcSteering()
    {
        totalForce = Vector3.zero;

        totalForce += Seek(target) * seekWeight;

        totalForce += CheckBounds(0f) * boundsWeight;

        return totalForce;
    }
}
