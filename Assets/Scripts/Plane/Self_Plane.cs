using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CustomMath
{

    public struct Self_Plane
    {
        #region Variables
        private Vec3 normal;
        private float distance;

        public Vec3 Normal { get { return normal.normalizedVec3; } }
        public float Distance { get { return distance; } }
        public Self_Plane flipped { get { return new Self_Plane(normal * -1, -distance); } }
        #endregion

        #region Constructors
        public Self_Plane(Vec3 inNormal, Vec3 inPoint)
        {
            normal = inNormal;
            distance = Vec3.Dot(inNormal, inPoint) / -normal.magnitude;
        }
        public Self_Plane(Vec3 inNormal, float d)
        {
            normal = inNormal;
            distance = d;
        }
        public Self_Plane(Vec3 a, Vec3 b, Vec3 c)
        {
            //https://math.stackexchange.com/questions/1034568/find-the-plane-a-triangle-lies-on
            normal = Vec3.Cross(b - a, c - a);
            Vec3 triangleCenter = (a + b + c) / 3;
            distance = Vec3.Dot(normal, triangleCenter) / -normal.magnitude;
        }
        #endregion
        #region Functions
        public static Self_Plane Translate(Self_Plane plane, Vec3 translation)
        {
            throw new NotImplementedException();
        }
        public Vec3 ClosestPointOnPlane(Vec3 point)
        {
            throw new NotImplementedException();
        }
        public void Flip()
        {
            normal *= -1;
            distance *= -1;
        }
        public float GetDistanceToPoint(Vec3 point)
        {
            throw new NotImplementedException();
        }
        public bool GetSide(Vec3 point)
        {
            throw new NotImplementedException();
        }
        public bool SameSide(Vec3 inPt0, Vec3 inPt1)
        {
            throw new NotImplementedException();
        }
        public void Set3Points(Vec3 a, Vec3 b, Vec3 c)
        {
            normal = Vec3.Cross(b - a, c - a);
            Vec3 triangleCenter = (a + b + c) / 3;
            distance = Vec3.Dot(normal, triangleCenter) / -normal.magnitude;
        }
        public void SetNormalAndPosition(Vec3 inNormal, Vec3 inPoint)
        {
            normal = inNormal;
            distance = Vec3.Dot(inNormal, inPoint) / -normal.magnitude;
        }
        public void Translate(Vec3 translation)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
