using UnityEngine;

public class Tracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;

        //Debug.Log(mousePos);

        transform.position = mousePos;
    }
}
