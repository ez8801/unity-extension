using UnityEngine;

namespace UnityExtension
{
    /// <summary>
    /// Extension method defined for the UnityEngine.Component class
    /// </summary>
    public static class ComponentEx
    {
        /// <summary>
        /// 지정된 Component를 활성화/비활성화 합니다.
        /// </summary>
        public static void SetActiveSafely(this Component comp, bool active)
        {
            if (comp != null)
                comp.gameObject.SetActive(active);
        }

        /// <summary>
        /// 지정된 Component가 활성화되어 있는지 여부를 반환합니다.
        /// </summary>
        public static bool GetActiveInHierarchy(this Component comp)
        {
            return comp && comp.gameObject.activeInHierarchy;
        }

        /// <summary>
        /// 지정된 Component가 활성화되어 있는지 여부를 반환합니다.
        /// </summary>
        public static bool GetActiveSelf(this Component comp)
        {
            return comp != null && comp.gameObject.activeSelf;
        }

        private static T GetComponentsInChildren<T>(this Component component, string name) where T : Component
        {
            if (component == null || string.IsNullOrEmpty(name))
                return null;

            Transform[] children = component.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < children.Length; i++)
            {
                Transform child = children[i];
                if (child.name == name)
                    return child.GetComponent<T>();
            }

            return null;
        }

        public static void Bind<T>(this Component component
            , ref T target
            , string path
            , bool deepSearch = false) where T : Component
        {
            if (component == null || target != null)
                return;

            Transform t = component.transform.Find(path);
            if (t == null && deepSearch)
            {
                int index = path.IndexOf('/');
                if (index != -1)
                {
                    string name = path.Substring(index + 1);
                    t = GetComponentsInChildren<Transform>(component, name);
                }
                else
                    t = GetComponentsInChildren<Transform>(component, path);
            }

            if (t != null)
                target = t.GetComponent<T>();
            else
            {
                Debug.LogWarning(StringEx.Concat("Assertion failed: ", path));
            }
        }

        public static void Bind(this Component component
            , ref GameObject target
            , string path
            , bool deepSearch = false)
        {
            if (component == null || target != null)
                return;

            Transform t = component.transform.Find(path);
            if (t == null && deepSearch)
            {
                int index = path.IndexOf('/');
                if (index != -1)
                {
                    string name = path.Substring(index + 1);
                    t = GetComponentsInChildren<Transform>(component, name);
                }
                else
                    t = GetComponentsInChildren<Transform>(component, path);
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
