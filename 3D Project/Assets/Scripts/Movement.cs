using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Vector3 movementDir;
    public float moveSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardMovement = Vector3.zero, rightMovement = Vector3.zero;


        forwardMovement = transform.forward * (movementDir.y * Time.deltaTime * moveSpeed);

        rightMovement = transform.right * (movementDir.x * Time.deltaTime * moveSpeed);

        transform.position += forwardMovement + rightMovement;
        //transform.Translate(forwardMovement + rightMovement, Space.World);
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        movementDir = context.ReadValue<Vector2>();
    }
}
