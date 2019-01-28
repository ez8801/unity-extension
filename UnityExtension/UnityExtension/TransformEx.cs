using UnityEngine;

namespace UnityExtension
{
    /// <summary>
    /// Extension method defined for the UnityEngine.Transform class
    /// </summary>
    public static class TransformEx
    {
        /// <summary>
        /// 지정된 Transform의 Position X값을 설정합니다.
        /// </summary>
        public static void SetPositionX(this Transform t, float x)
        {
            if (t != null)
                t.position = new Vector3(x, t.position.y, t.position.z);
        }

        /// <summary>
        /// 지정된 Transform의 Position Y값을 설정합니다.
        /// </summary>
        public static void SetPositionY(this Transform t, float y)
        {
            if (t != null)
                t.position = new Vector3(t.position.x, y, t.position.z);
        }

        /// <summary>
        /// 지정된 Transform의 Position Z값을 설정합니다.
        /// </summary>
        public static void SetPositionZ(this Transform t, float z)
        {
            if (t != null)
                t.position = new Vector3(t.position.x, t.position.y, z);
        }

        /// <summary>
        /// 지정된 Transform의 Position X, Y값을 설정합니다.
        /// </summary>
        public static void SetPositionXY(this Transform t, float x, float y)
        {
            if (t != null)
                t.position = new Vector3(x, y, t.position.z);
        }

        /// <summary>
        /// 지정된 Transform의 Position Y, Z값을 설정합니다.
        /// </summary>
        public static void SetPositionYZ(this Transform t, float y, float z)
        {
            if (t != null)
                t.position = new Vector3(t.position.x, y, z);
        }

        /// <summary>
        /// 지정된 Transform의 Position X, Z값을 설정합니다.
        /// </summary>
        public static void SetPositionXZ(this Transform t, float x, float z)
        {
            if (t != null)
                t.position = new Vector3(x, t.position.y, z);
        }

        /// <summary>
        /// 지정된 Transform의 Position 값을 설정합니다.
        /// </summary>
        public static void SetPositionY(this Transform t, Transform source, float y)
        {
            if (t != null && source != null)
                SetPositionY(t, source.position, y);
        }

        public static void SetPositionY(this Transform t, Vector3 source, float y)
        {
            if (t != null && source != null)
                t.position = new Vector3(source.x, y, source.z);
        }
        
        /// <summary>
        /// 지정된 Transform의 LocalPosition X값을 설정합니다.
        /// </summary>
        public static void SetLocalPositionX(this Transform t, float x)
        {
            if (t != null)
                t.localPosition = new Vector3(x, t.localPosition.y, t.localPosition.z);
        }
        
        /// <summary>
        /// 지정된 Transform의 LocalPosition Y값을 설정합니다.
        /// </summary>
        public static void SetLocalPositionY(this Transform t, float y)
        {
            if (t != null)
                t.localPosition = new Vector3(t.localPosition.x, y, t.localPosition.z);
        }

        /// <summary>
        /// 지정된 Transform의 LocalPosition Z값을 설정합니다.
        /// </summary>
        public static void SetLocalPositionZ(this Transform t, float z)
        {
            if (t != null)
                t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, z);
        }


        /// <summary>
        /// 지정된 Transform의 LocalPosition X, Y값을 설정합니다.
        /// </summary>
        public static void SetLocalPositionXY(this Transform t, float x, float y)
        {
            if (t != null)
                t.localPosition = new Vector3(x, y, t.localPosition.z);
        }

        /// <summary>
        /// 지정된 Transform의 LocalPosition Y, Z값을 설정합니다.
        /// </summary>
        public static void SetLocalPositionYZ(this Transform t, float y, float z)
        {
            if (t != null)
                t.localPosition = new Vector3(t.localPosition.x, y, z);
        }

        /// <summary>
        /// 지정된 Transform의 LocalPosition X, Z값을 설정합니다.
        /// </summary>
        public static void SetLocalPositionXZ(this Transform t, float x, float z)
        {
            if (t != null)
                t.localPosition = new Vector3(x, t.localPosition.y, z);
        }

        public static void SetLocalPosition(this Transform t, Transform src)
        {
            if (t != null && src != null)
                t.localPosition = src.localPosition;
        }

        /// <summary>
        /// 지정된 Transform의 LocalScale X값을 설정합니다.
        /// </summary>
        public static void SetLocalScaleX(this Transform t, float x)
        {
            if (t != null)
                t.localScale = new Vector3(x, t.localScale.y, t.localScale.z);
        }

        /// <summary>
        /// 지정된 Transform의 LocalScale Y값을 설정합니다.
        /// </summary>
        public static void SetLocalScaleY(this Transform t, float y)
        {
            if (t != null)
                t.localScale = new Vector3(t.localScale.x, y, t.localScale.z);
        }

        /// <summary>
        /// 지정된 Transform의 LocalScale Z값을 설정합니다.
        /// </summary>
        public static void SetLocalScaleZ(this Transform t, float z)
        {
            if (t != null)
                t.localScale = new Vector3(t.localScale.x, t.localScale.y, z);
        }

        /// <summary>
        /// 지정된 Transform의 LocalScale X, Y값을 설정합니다.
        /// </summary>
        public static void SetLocalScaleXY(this Transform t, float x, float y)
        {
            if (t != null)
                t.localScale = new Vector3(x, y, t.localScale.z);
        }

        /// <summary>
        /// 지정된 Transform의 LocalScale X, Z값을 설정합니다.
        /// </summary>
        public static void SetLocalScaleXZ(this Transform t, float x, float z)
        {
            if (t != null)
                t.localScale = new Vector3(x, t.localScale.y, z);
        }

        /// <summary>
        /// 지정된 Transform을 활성화/비활성화 합니다.
        /// </summary>
        public static void SetActiveSafely(this Transform t, bool active)
        {
            if (t != null)
                t.gameObject.SetActive(active);
        }

        /// <summary>
        /// 지정된 Transform의 복사합니다.
        /// </summary>
        public static void Copy(this Transform target, Transform src)
        {
            if (target != null && src != null)
            {
                target.position = src.position;
                target.rotation = src.rotation;
                target.localScale = src.localScale;
            }
        }
        
        public static void AttachNode(this Transform t, Transform child)
        {
            if (child != null)
                child.parent = t;
        }

        public static void AttachIdentityNode(this Transform t, Transform child)
        {
            if (t != null && child != null)
            {
                child.parent = t;
                child.localPosition = Vector3.zero;
                child.localRotation = Quaternion.identity;
                child.localScale = Vector3.one;
            }
        }

        public static void Identify(this Transform t)
        {
            if (t != null)
            {
                t.localPosition = Vector3.zero;
                t.localRotation = Quaternion.identity;
                t.localScale = Vector3.one;
            }
        }
        
        public static string GetFullPath(this Transform t, Transform root = null)
        {
            if (t == root)
                return string.Empty;

            if (t != null)
            {
                string fullPath = t.name;
                Transform parent = t.parent;
                while (parent != root)
                {
                    if (parent == null)
                        break;

                    fullPath = StringEx.Format("{0}/{1}", parent.name, fullPath);
                    parent = parent.parent;
                }
                return fullPath;
            }
            return string.Empty;
        }
        
        public static Vector3 Direction(this Transform t, Transform target)
        {
            if (t != null && target != null)
                return t.position.Direction(target.position);
            return Vector3.zero;
        }

        public static Vector3 Direction(this Transform t, Vector3 targetPosition)
        {
            if (t != null)
                return t.position.Direction(targetPosition);
            return Vector3.zero;
        }

        public static float Distance(this Transform t, Transform target)
        {
            if (t != null && target != null)
                return t.position.Distance(target.position);
            return 0f;
        }
    }
}