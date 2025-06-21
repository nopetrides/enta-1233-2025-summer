using UnityEngine;
using UnityEngine.AI;

public class MoveToTransformAgent : MonoBehaviour
{
    [SerializeField] private NavMeshAgent NavMeshAgent;

	public void Update()
	{
		if (!PlayerLocatorSingleton.Instance) return;
		
		NavMeshAgent.SetDestination(PlayerLocatorSingleton.Instance.transform.position);
	}
}
