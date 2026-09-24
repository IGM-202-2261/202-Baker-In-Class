using UnityEngine;
using UnityEngine.InputSystem;

public class MovementDemo : MonoBehaviour
{
    Vector3 movement;

    public float playerSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 velocity = playerSpeed * movement;
        transform.Translate(velocity * Time.fixedDeltaTime);
        
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerSpeed = 0;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.rebeccaPurple;

        //Gizmos.DrawWireSphere(transform.position, playerSpeed);

        Gizmos.DrawRay(transform.position, movement);
    }
}
