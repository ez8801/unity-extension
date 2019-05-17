# unity-extension
Unity3d Extensions

## UnityExtension.AnimatorEx Class Reference
| Static Methods | |
| ------------ | ------------ |
| AnimatorStateInfo GetFocusStateInfo(this Animator animator, int layerIndex = 0) |
| bool IsPlaying(this Animator animator, int layerIndex = 0) | Gets a value that indicates whether the animator is playing.
| bool IsPlaying(this Animator animator, string stateName, int layerIndex = 0) | Gets a value that indicates whether the animator is playing. |
| bool IsPlaying(this Animator animator, int fullPathHash, int layerIndex = 0) | Gets a value that indicates whether the animator is playing. |
| float GetNormalizedTime(this Animator animator, int fullPathHash, int layerIndex = 0) |
| float GetAnimatorStateLength(this Animator animator, int layerIndex = 0) |
| loat GetAnimationClipLengh(this Animator animator, string clipName, int layerIndex = 0) | 

### Example

```sh

Debug.Log(_Animator.IsPlaying("StateName")); // Displays 'true or false'
Debug.Log(_Animator.GetAnimationClipLengh("ClipName"));

```

## UnityExtension.BehaviourEx Class Reference

| Static Methods |
| ------------ |
| void SetEnableSafely(this Behaviour comp, bool enabled) |

## UnityExtension.ComponentEx Class Reference

| Static Methods |
| ------------ |
| void SetActiveSafely(this Component comp, bool active) |
| bool GetActiveInHierarchy(this Component comp) |
| bool GetActiveSelf(this Component comp) |
| T GetComponentsInChildren<T>(this Component component, string name) where T : Component |
| void Bind<T>(this Component component, ref T target, string path, bool deepSearch = false) where T : Component |
| void Bind(this Component component, ref GameObject target, string path , bool deepSearch = false) |
  
## UnityExtension.GameObjectEx Class Reference

| Static Methods |
| ------------ |
| void SetLocalPositionX(this GameObject go, float x) |
| void SetActiveSafely(this GameObject go, bool active) |
| bool GetActiveInHierarchy(this GameObject gameObject) |
| bool GetActiveSelf(this GameObject gameObject) |
| T GetComponentsInChildren<T>(this GameObject go, string name) where T : Component |
| void Bind<T>(this GameObject go, ref T target, string path, bool deepSearch = false) where T : Component |
| void Bind(this GameObject go, ref GameObject target, string path, bool deepSearch = false) |
  
## UnityExtension.StringEx Class Reference
| Static Methods |
| ------------ |
| string Format(string format, object arg) |
| string Format(string format, object arg1, object arg2) |
| string Format(string format, object arg1, object arg2, object arg3) |
| string Format(string format, params object[] args) |
| string Concat(string arg0, string arg1) |
| string Concat(string arg0, string arg1, string arg2) |
| string Concat(string arg0, string arg1, string arg2, string arg3) |
| string Concat(params string[] args) |
| string Concat(object arg0, object arg1) |
| string Concat(object arg0, object arg1, object arg2) |
| string Concat(object arg0, object arg1, object arg2, object arg3) |
| string Concat(params object[] args) |
| string Join(string separator, string[] value) |
| string Join(string separator, params object[] args) |
| string Combine(params string[] values) |

## UnityExtension.TransformEx Class Reference
| Static Methods |
| ------------ |
| void SetPositionX(this Transform t, float x) |
| void SetPositionY(this Transform t, float y) |
| void SetPositionZ(this Transform t, float z) |
| void SetPositionXY(this Transform t, float x, float y) |
| void SetPositionYZ(this Transform t, float y, float z) |
| void SetPositionXZ(this Transform t, float x, float z) |
| void SetPositionY(this Transform t, Transform source, float y) |
| void SetPositionY(this Transform t, Vector3 source, float y) |
| void SetLocalPositionX(this Transform t, float x) |
| void SetLocalPositionY(this Transform t, float y) |
| void SetLocalPositionZ(this Transform t, float z) |
| void SetLocalPositionXY(this Transform t, float x, float y) |
| void SetLocalPositionYZ(this Transform t, float y, float z) |
| void SetLocalPositionXZ(this Transform t, float x, float z) |
| void SetLocalPosition(this Transform t, Transform src) |
| void SetLocalScaleX(this Transform t, float x) |
| void SetLocalScaleY(this Transform t, float y) |
| void SetLocalScaleZ(this Transform t, float z) |
| void SetLocalScaleXY(this Transform t, float x, float y) |
| void SetLocalScaleXZ(this Transform t, float x, float z) |
| void SetActiveSafely(this Transform t, bool active) |
| void Copy(this Transform target, Transform src) |
| void AttachNode(this Transform t, Transform child) |
| void AttachIdentityNode(this Transform t, Transform child) |
| void Identify(this Transform t) |
| string GetFullPath(this Transform t, Transform root = null) |
| Vector3 Direction(this Transform t, Transform target) |
| Vector3 Direction(this Transform t, Vector3 targetPosition) |
| float Distance(this Transform t, Transform target) |


## UnityExtension.VectorEx Class Reference
| Static Methods |
| ------------ |
| Vector3 Direction(this Vector3 source, Vector3 target) |
| Vector3 XZ(this Vector3 v) |
| float Distance(this Vector3 v, Vector3 target) |
| float DistanceXZ(this Vector3 v, Vector3 target) |
