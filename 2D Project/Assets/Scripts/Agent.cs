using UnityEngine;

public abstract class Agent : MonoBehaviour
{
    protected Vector3 position, velocity, acceleration;

    public float maxSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Zero out Acceleration from last frame
        acceleration = Vector3.zero;

        // Calculate a new Steering force vector
        //steeringForce = CalcSteering();

        // Add Steering force to Acceleration
        acceleration = CalcSteering();

        // Update Velocity with current Acceleration
        velocity += acceleration * Time.deltaTime;

        //  Move the agent with Velocity
        transform.position += velocity * Time.deltaTime;

    }

    protected abstract Vector3 CalcSteering();

    public Vector3 Seek(Vector3 targetPos)
    {
        // Calculate desired velocity
        Vector3 desiredVelocity = targetPos - transform.position;

        // Set desired = max speed
        desiredVelocity = desiredVelocity.normalized * maxSpeed;

        // Calculate seek steering force
        Vector3 seekingForce = desiredVelocity - velocity;

        // Return seek steering force
        return seekingForce;
    }

    public Vector3 Seek(GameObject target)
    {
        return Seek(target.transform.position);
    }

    public Vector3 Flee(Vector3 targetPos)
    {
        // Calculate desired velocity
        Vector3 desiredVelocity = transform.position - targetPos;

        // Set desired = max speed
        desiredVelocity = desiredVelocity.normalized * maxSpeed;

        // Calculate seek steering force
        Vector3 seekingForce = desiredVelocity - velocity;

        // Return seek steering force
        return seekingForce;
    }
}
