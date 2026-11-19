using UnityEngine;

public class SurfaceAlignment : MonoBehaviour
{
    public LayerMask surfaceMask;

    public float castDist = 100f;

    public Ray castRay;

    RaycastHit surfaceHit;

    // Update is called once per frame
    void Update()
    {
        castRay.origin = transform.position + (Vector3.up * 10);
        castRay.direction = Vector3.down;

        if (Physics.Raycast(castRay, out surfaceHit, castDist, surfaceMask))
        {
            Vector3 surfaceForward = Vector3.Cross(transform.right, surfaceHit.normal);

            transform.rotation = Quaternion.LookRotation(surfaceForward, surfaceHit.normal);
        }
    }
}
