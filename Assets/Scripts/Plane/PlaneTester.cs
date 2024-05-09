using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;
public class PlaneTester : MonoBehaviour
{
    private Plane plane;
    private Self_Plane selfPlane;

    [SerializeField] private Vec3 normal = new Vec3(0, 1, 0);
    [SerializeField] private Vec3 position = new Vec3(0, 0, 0);

    [SerializeField] private GameObject planePrefab;
    private GameObject planeObject;
    private void Start()
    {

        plane = new Plane(normal, position);
        planeObject = Instantiate(planePrefab, transform);
        //selfPlane = new Self_Plane(normal, position);
    }
    private void Update()
    {
        plane.SetNormalAndPosition(normal,position);
        planeObject.transform.up = plane.normal;
    }
    private void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(plane.normal * plane.distance, (plane.normal * plane.distance) + plane.normal);
        }
    }
}
