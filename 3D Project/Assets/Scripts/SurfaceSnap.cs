using UnityEngine;

public class SurfaceSnap : MonoBehaviour
{
    public LayerMask surfaceMask;

    public float castDist = 100f;

    public Ray castRay;

    RaycastHit surfaceHit;

    public float heightOffset;

    // Update is called once per frame
    void Update()
    {
        castRay.origin = transform.position + (Vector3.up *10);
        castRay.direction = Vector3.down;

        if(Physics.Raycast(castRay, out surfaceHit, castDist, surfaceMask))
        {
            Vector3 newPoint = surfaceHit.point;

            newPoint.y += heightOffset;

            transform.position = newPoint;
        }
    }
}
