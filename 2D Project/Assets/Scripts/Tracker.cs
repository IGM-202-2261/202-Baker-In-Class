using UnityEngine;

public class Tracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rBody;

        rBody = GetComponent<Rigidbody2D>();

        rBody.AddForce(Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        //transform.position = mousePos;
    }
}
