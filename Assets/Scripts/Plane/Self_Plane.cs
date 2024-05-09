using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CustomMath
{

    public struct Self_Plane
    {
        public Vec3 normal;
        public float distance;
        public Self_Plane flipped { get { throw new NotImplementedException(); } }

        public Self_Plane(Vec3 inNormal, Vec3 inPoint)
        {
            throw new NotImplementedException();
        }
        public Self_Plane(Vec3 inNormal, float d)
        {
            throw new NotImplementedException();
        }
        public Self_Plane(Vec3 a, Vec3 b, Vec3 c)
        {
            throw new NotImplementedException();
        }
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        public void SetNormalAndPosition(Vec3 inNormal, Vec3 inPoint)
        {
            throw new NotImplementedException();
        }
        public void Translate(Vec3 translation)
        {
            throw new NotImplementedException();
        }
    }
}
