using UnityEngine;

namespace UnityExtension
{
    /// <summary>
    /// Extension method defined for the UnityEngine.GameObject class
    /// </summary>
    public static class GameObjectEx
    {
        public static void SetLocalPositionX(this GameObject go, float x)
        {
            if (go != null)
                go.transform.SetLocalPositionX(x);
        }

        /// <summary>
        /// 지정된 GameObject를 활성화/비활성화 합니다.
        /// </summary>
        public static void SetActiveSafely(this GameObject go, bool active)
        {
            if (go != null)
                go.SetActive(active);
        }

        /// <summary>
        /// 지정된 GameObject가 활성화되어 있는지 여부를 반환합니다.
        /// </summary>
        public static bool GetActiveInHierarchy(this GameObject gameObject)
        {
            return gameObject && gameObject.activeInHierarchy;
        }

        /// <summary>
        /// 지정된 GameObject가 활성화되어 있는지 여부를 반환합니다.
        /// </summary>
        public static bool GetActiveSelf(this GameObject gameObject)
        {
            return gameObject != null && gameObject.activeSelf;
        }

        private static T GetComponentsInChildren<T>(this GameObject go, string name) where T : Component
        {
            if (go == null || string.IsNullOrEmpty(name))
                return null;

            Transform[] children = go.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < children.Length; i++)
            {
                Transform child = children[i];
                if (child.name == name)
                    return child.GetComponent<T>();
            }

            return null;
        }

        public static void Bind<T>(this GameObject go
            , ref T target
            , string path
            , bool deepSearch = false) where T : Component
        {
            if (go == null || target != null)
                return;

            Transform t = go.transform.Find(path);
            if (t == null && deepSearch)
            {
                int index = path.IndexOf('/');
                if (index != -1)
                {
                    string name = path.Substring(index + 1);
                    t = GetComponentsInChildren<Transform>(go, name);
                }
                else
                    t = GetComponentsInChildren<Transform>(go, path);
            }

            if (t != null)
                target = t.GetComponent<T>();
            else
            {
                Debug.LogWarning(StringEx.Concat("Assertion failed: ", path));
            }
        }

        public static void Bind(this GameObject go
            , ref GameObject target
            , string path
            , bool deepSearch = false)
        {
            if (go == null || target != null)
                return;

            Transform t = go.transform.Find(path);
            if (t == null && deepSearch)
            {
                int index = path.IndexOf('/');
                if (index != -1)
                {
                    string name = path.Substring(index + 1);
                    t = GetComponentsInChildren<Transform>(go, name);
                }
                else
                    t = GetComponentsInChildren<Transform>(go, path);
            }

            if (t != null)
                target = t.gameObject;
            else
            {
                Debug.LogWarning(StringEx.Concat("Assertion failed: ", path));
            }
        }
    }
}
