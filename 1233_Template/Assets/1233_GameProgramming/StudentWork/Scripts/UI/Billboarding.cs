using UnityEngine;

public class Billboarding : MonoBehaviour
{
	private Camera _camera;

	private void LateUpdate()
	{
		transform.forward = _camera.transform.forward;
	}
}
