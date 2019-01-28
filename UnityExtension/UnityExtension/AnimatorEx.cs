using UnityEngine;

namespace UnityExtension
{
    /// <summary>
    /// Extension method defined for the UnityEngine.Animator class
    /// </summary>
    public static class AnimatorEx
    {
        public static readonly string BaseLayer = "Base Layer.";

        public static AnimatorStateInfo GetFocusStateInfo(this Animator animator, int layerIndex = 0)
        {
            if (animator != null)
            {
                AnimatorStateInfo info;
                if (animator.IsInTransition(layerIndex))
                    info = animator.GetNextAnimatorStateInfo(layerIndex);
                else
                    info = animator.GetCurrentAnimatorStateInfo(layerIndex);
                return info;
            }
            return default(AnimatorStateInfo);
        }

        /// <summary>
        /// Gets a value that indicates whether the animator is playing.
        /// </summary>
        public static bool IsPlaying(this Animator animator, int layerIndex = 0)
        {
            if (animator != null)
            {
                AnimatorStateInfo info = animator.GetFocusStateInfo(layerIndex);
                if (info.loop || info.normalizedTime < 1f)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Gets a value that indicates whether the animator is playing.
        /// </summary>
        public static bool IsPlaying(this Animator animator, string stateName, int layerIndex = 0)
        {
            if (animator != null)
            {
                if (string.IsNullOrEmpty(stateName))
                    return false;

                string fullName = string.Empty;
                if (layerIndex == 0)
                    fullName = StringEx.Concat(BaseLayer, stateName);
                else
                    fullName = StringEx.Concat(animator.GetLayerName(layerIndex), stateName);

                AnimatorStateInfo info = animator.GetFocusStateInfo(layerIndex);
                if (info.IsName(fullName) && (info.loop || info.normalizedTime < 1f))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Gets a value that indicates whether the animator is playing.
        /// </summary>
        public static bool IsPlaying(this Animator animator, int fullPathHash, int layerIndex = 0)
        {
            if (animator != null)
            {
                AnimatorStateInfo info = animator.GetFocusStateInfo(layerIndex);
                if (info.fullPathHash == fullPathHash && (info.loop || info.normalizedTime < 1f))
                    return true;
            }
            return false;
        }

        public static float GetNormalizedTime(this Animator animator, int fullPathHash, int layerIndex = 0)
        {
            if (animator != null)
            {
                AnimatorStateInfo info = animator.GetFocusStateInfo(layerIndex);
                if (info.fullPathHash == fullPathHash)
                    return info.normalizedTime;
            }
            return -1f;
        }

        public static float GetAnimatorStateLength(this Animator animator, int layerIndex = 0)
        {
            if (animator != null)
            {
                AnimatorStateInfo info = animator.GetFocusStateInfo(layerIndex);
                return info.length;
            }
            return 0f;
        }

        public static float GetAnimationClipLengh(this Animator animator, string clipName, int layerIndex = 0)
        {
            if (animator != null)
            {
                AnimationClip[] clips = animator.runtimeAnimatorController.animationClips;
                for (int i = 0; i < clips.Length; i++)
                {
                    AnimationClip clip = clips[i];
                    if (clip.name == clipName)
                        return clip.length;
                }
            }
            return 0f;
        }
    }
}