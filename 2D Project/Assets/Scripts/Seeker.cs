using UnityEngine;

public class Seeker : Agent
{
    public GameObject target;

    public float seekWeight, boundsWeight;

    protected override Vector3 CalcSteering()
    {
        target = FindNearest().gameObject;

        totalForce = new Vector3(Random.value, Random.value, 0);

        totalForce += Seek(target) * seekWeight;

        totalForce += CheckBounds(0f) * boundsWeight;

        return totalForce; 
    }
}
