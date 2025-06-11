using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Kobolds
{
	public class BulletManager : BaseBulletManager
	{
        [Header("External Scripts")]
		[SerializeField] private Camera Cam;
        [SerializeField] private KoboldInputs Inputs;

        

        [Header("Raycast")]
        
        [SerializeField] private LayerMask RaycastMask;
        [SerializeField] private ShootType ShootingCalculation;

        public enum ShootType
        {
            Raycast = 0,
            Physics = 1,
        }

		private void Update()
		{
			if (Inputs.Aim && Inputs.Fire) OnFirePressed();
			Inputs.Fire = false;
		}

		private void OnFirePressed()
		{
            Debug.Log("Firing projectile");
            switch (ShootingCalculation)
            {
                case ShootType.Raycast:
                    DoRaycastShot();
                    break;
                case ShootType.Physics:
                    SpawnPhysicsBullet(Cam.transform);
                    break;
                default:
                    Debug.LogError("Unexpected value");
                    break;
            }
		}

        

        private void DoRaycastShot()
        {
            if (Physics.Raycast(
                    Cam.transform.position,
                    Cam.transform.forward, 
                    out RaycastHit hit,
                    Mathf.Infinity, 
                    RaycastMask))
            {
                Debug.Log("Raycast Hit!");
                OnProjectileCollision(hit.point, hit.normal);
            }
            else
            {
                Debug.Log("Raycast Miss");
            }
        }

        

        

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            if (Inputs.Aim)
                Gizmos.DrawLine(Cam.transform.position, Cam.transform.position + Cam.transform.forward * 100);
        }

        private void CleanupParticle()
        {
            
        }
    }
}
