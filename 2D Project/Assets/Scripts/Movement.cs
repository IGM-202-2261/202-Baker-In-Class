using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Vector2 movement;

    public float playerSpeed;

    // Update is called once per frame
    void Update()
    {
        //movement.x = Random.Range(-1f, 1f);
        //movement.y = Random.Range(-1f, 1f);

        float randValue = Random.value;

        if(randValue < .5)
        {
            movement = Vector2.up;
        }
        else if (randValue < (.5 + .2))
        {
            movement = Vector2.left;
        }
        else if(randValue < (.5 + .2 + .2))
        {
            movement = Vector2.right;
        }
        else
        {
            movement = Vector2.down;
        }

        transform.Translate(movement * Time.deltaTime * playerSpeed);
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        //movement = context.ReadValue<Vector2>();

        
    }
}
