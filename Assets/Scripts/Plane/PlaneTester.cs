using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;
public class PlaneTester : MonoBehaviour
{
    private Plane plane;
    private Self_Plane selfPlane;

    [SerializeField] private Vec3 normal = new Vec3(0, 1, 0);
    [SerializeField] private Vec3 position = new Vec3(0, 1, 0);

    [SerializeField] private GameObject planePrefab;
    [SerializeField] private Material planeMat;
    [SerializeField] private Material selfPlaneMat;
    private GameObject planeObject;
    private GameObject selfPlaneObject;
    private void Start()
    {
        plane = new Plane(normal, position);
        selfPlane = new Self_Plane(normal, position);

        Debug.Log($"Unity Plane distance is:{plane.distance}");
        Debug.Log($"Self Plane distance is:{selfPlane.Distance}");

        planeObject = Instantiate(planePrefab);
        selfPlaneObject = Instantiate(planePrefab);
        planeObject.GetComponent<MeshRenderer>().material = planeMat;
        selfPlaneObject.GetComponent<MeshRenderer>().material = selfPlaneMat;
    }
    private void Update()
    {
        plane.SetNormalAndPosition(normal, position);
        planeObject.transform.up = plane.normal;
        planeObject.transform.position = plane.distance * plane.normal;

        selfPlane.SetNormalAndPosition(normal, position);
        selfPlaneObject.transform.up = selfPlane.Normal;
        selfPlaneObject.transform.position = selfPlane.Distance * selfPlane.Normal;
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
