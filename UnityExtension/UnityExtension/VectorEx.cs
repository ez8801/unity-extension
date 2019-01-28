using UnityEngine;

namespace UnityExtension
{
    /// <summary>
    /// Extension method defined for the UnityEngine.Vector3 class
    /// </summary>
    public static class VectorEx
    {
        public static Vector3 Direction(this Vector3 source, Vector3 target)
        {
            return (target - source).normalized;
        }

        public static Vector3 XZ(this Vector3 v)
        {
            return new Vector3(v.x, 0f, v.z);
        }

        public static float Distance(this Vector3 v, Vector3 target)
        {
            Vector3 dir = target - v;
            return dir.magnitude;
        }

        public static float DistanceXZ(this Vector3 v, Vector3 target)
        {
            Vector3 dir = target.XZ() - v.XZ();
            return dir.magnitude;
        }
    }
}
