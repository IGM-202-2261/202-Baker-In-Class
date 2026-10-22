using UnityEngine;

public abstract class Agent : MonoBehaviour
{
    protected Vector3 velocity, acceleration, position, totalForce;

    public float maxSpeed = 5f, maxForce = 3f;

    protected Vector2 screenHalfSize;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screenHalfSize.y = Camera.main.orthographicSize;

        screenHalfSize.x = screenHalfSize.y * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        // Zero out Acceleration from last frame
        acceleration = Vector3.zero;

        // Calculate a new Steering force vector
        // Add Steering force to Acceleration
        acceleration += CalcSteering();

        //  Clamp forces
        acceleration = Vector3.ClampMagnitude(acceleration, maxForce);

        // Update Velocity with current Acceleration
        velocity += acceleration * Time.deltaTime;

        //  Move the agent with Velocity
        transform.position += velocity * Time.deltaTime;

    }

    protected abstract Vector3 CalcSteering();

    public Vector3 CalcFuturePosition(float time)
    {
        return transform.position + (velocity * time);
    }

    public Vector3 CheckBounds(float padding)
    {
        Vector3 force = Vector3.zero;

        //  Check if out of bounds
        if(transform.position.x < -screenHalfSize.x ||
            transform.position.x > screenHalfSize.x ||
            transform.position.y > screenHalfSize.y ||
            transform.position.y < -screenHalfSize.y)
        {
            force = Seek(Vector3.zero);
        }

        return force;
    }

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

    public Vector3 Seek(GameObject targetA)
    {
        return Seek(targetA.transform.position);
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
