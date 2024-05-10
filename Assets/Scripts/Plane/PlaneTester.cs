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
    [Space]
    [SerializeField] private float distance = 0;

    [Header("Set with three points")]
    [SerializeField] private Vec3 a;
    [SerializeField] private Vec3 b;
    [SerializeField] private Vec3 c;
    [Space]
    [SerializeField] private Vec3 translation;
    [SerializeField] private Vec3 point;


    [Header("Visuals")]
    [SerializeField] private GameObject planePrefab;
    [SerializeField] private Material planeMat;
    [SerializeField] private Material selfPlaneMat;
    [SerializeField] private Transform pointVisual;
    private GameObject planeObject;
    private GameObject selfPlaneObject;
    private void Start()
    {
        plane = new Plane(a, b, c);
        selfPlane = new Self_Plane(a, b, c);

        Debug.Log($"Unity Plane distance is:{plane.distance}");
        Debug.Log($"Self Plane distance is:{selfPlane.Distance}");

        planeObject = Instantiate(planePrefab);
        selfPlaneObject = Instantiate(planePrefab);
        planeObject.GetComponent<MeshRenderer>().material = planeMat;
        selfPlaneObject.GetComponent<MeshRenderer>().material = selfPlaneMat;
    }
    private void Update()
    {
        plane = Plane.Translate(plane, translation);
        planeObject.transform.up = plane.normal;
        planeObject.transform.position = plane.distance * plane.normal;

        selfPlane = Self_Plane.Translate(selfPlane, translation);
        selfPlaneObject.transform.up = selfPlane.Normal;
        selfPlaneObject.transform.position = selfPlane.Distance * selfPlane.Normal;
        //Debug.Log($"Unity Plane distance is:{plane.distance}");
        //Debug.Log($"Self Plane distance is:{selfPlane.Distance}");

        pointVisual.position = point;
        Debug.Log($"Unity distance to point: {plane.GetDistanceToPoint(point)}");
        Debug.Log($"Self plane distance to point: {selfPlane.GetDistanceToPoint(point)}");
    }
    private void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(plane.normal * (plane.distance + 0.1f), (plane.normal * (plane.distance + 0.1f)) + plane.normal);
            Gizmos.color = Color.red;
            Gizmos.DrawLine(selfPlane.Normal * selfPlane.Distance, (selfPlane.Normal * selfPlane.Distance) + selfPlane.Normal);
        }
    }
}
