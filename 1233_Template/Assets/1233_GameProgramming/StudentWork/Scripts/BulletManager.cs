using System;
using UnityEngine;

namespace Kobolds
{
    public class BulletManager : MonoBehaviour
    {
        [SerializeField] private Camera Cam;

        [SerializeField] private GameObject BulletPrefab;

        [SerializeField] private KoboldInputs Inputs;

        private void Update()
        {
            if (Inputs.Aim && Inputs.Fire)
            {
                OnFirePressed();
            }
            Inputs.Fire = false;
        }

        private void OnFirePressed()
        {
            Vector3 direction = Cam.transform.forward;
            
            Instantiate(BulletPrefab, Cam.transform.position, Cam.transform.rotation);
        }
    }
}