using UnityEngine;

public class SurfaceAlignment : MonoBehaviour
{
    public LayerMask surfaceMask;

    public float raycastDist = 100f;

    public Ray castRay;

    RaycastHit surfaceHit;

    // Update is called once per frame
    void Update()
    {
        castRay.direction = Vector3.down;
        castRay.origin = transform.position + (Vector3.up * 10);

        if (Physics.Raycast(castRay, out surfaceHit, raycastDist, surfaceMask))
        {
            Vector3 surfaceForard = Vector3.Cross(transform.right, surfaceHit.normal);

            transform.rotation = Quaternion.LookRotation(surfaceForard, surfaceHit.normal);
        }
    }
}
