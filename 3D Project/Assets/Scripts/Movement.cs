using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Vector3 movementDir;
    public float moveSpeed = 5f;

    Vector3 forwardMovement = Vector3.zero, rightMovement = Vector3.zero;


    // Update is called once per frame
    void Update()
    {
        forwardMovement = transform.forward * moveSpeed * Time.deltaTime * movementDir.y;


        rightMovement = transform.right * movementDir.x * moveSpeed * Time.deltaTime;


        transform.position += (forwardMovement + rightMovement);
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        movementDir = context.ReadValue<Vector2>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;

        Gizmos.DrawRay(transform.position, forwardMovement * 1000f);
    }
}
