using UnityEngine;

public class SurfaceSnapper : MonoBehaviour
{
    public LayerMask surfaceMask;

    public float raycastDist = 100f;

    public Ray castRay;

    public float heightOffest;

    RaycastHit surfaceHit;

    // Update is called once per frame
    void Update()
    {
        castRay.direction = Vector3.down;
        castRay.origin = transform.position + (Vector3.up * 10);

        if(Physics.Raycast(castRay, out surfaceHit, raycastDist, surfaceMask))
        {
            Vector3 newPoint = surfaceHit.point;

            newPoint.y += heightOffest;

            transform.position = newPoint;
        }
    }
}
