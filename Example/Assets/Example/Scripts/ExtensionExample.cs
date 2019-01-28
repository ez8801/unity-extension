using UnityEngine;
using UnityExtension;

public class ExtensionExample : MonoBehaviour
{
    public Animator _Animator;

    // Start is called before the first frame update
    void Start()
    {
        // Transform Extension        
        transform.SetPositionY(8801f);                      // transform.position = new Vector3(transform.position.x, 8801f, transform.position.z);

        // String Extension
        Debug.Log(StringEx.Combine("a", "b", "c", "d"));    // Displays 'a/b/c/d'
        Debug.Log(StringEx.Concat("a", "b", "c", "d"));     // Displays 'abcd'
        Debug.Log(StringEx.Join(",", "a", "b", "c", "d"));  // Displays 'a,b,c,d'

        // GameObject Extension
        gameObject.SetActiveSafely(true);
        Debug.LogWarning(gameObject.GetActiveInHierarchy());
        Debug.LogWarning(gameObject.GetActiveSelf());

        // Animator Extension
        Debug.Log(_Animator.IsPlaying());
        Debug.Log(_Animator.IsPlaying("StateName"));
    }
}
