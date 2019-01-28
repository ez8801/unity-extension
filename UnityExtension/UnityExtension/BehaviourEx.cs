using UnityEngine;

namespace UnityExtension
{
    /// <summary>
    /// Extension method defined for the UnityEngine.Behaviour class
    /// </summary>
    public static class BehaviourEx
    {
        public static void SetEnableSafely(this Behaviour comp, bool enabled)
        {
            if (comp != null)
                comp.enabled = enabled;
        }
    }
}
