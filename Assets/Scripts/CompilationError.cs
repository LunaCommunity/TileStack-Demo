using UnityEngine;
using UnityEngine.AI;

public class CompilationError : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent = null;

    private void Start()
    {
#if !UNITY_LUNA
        _agent.autoRepath = true;
#endif
        
        //...
    }
}