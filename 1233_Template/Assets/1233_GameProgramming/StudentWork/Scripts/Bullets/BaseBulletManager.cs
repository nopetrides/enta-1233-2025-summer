using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kobolds;

public class BaseBulletManager : MonoBehaviour
{
    [Header("Physics Bullets")]
    [SerializeField] private PhysicsBullet PhysicsBulletPrefab;
    [Header("Particle")]
    [SerializeField] private RaycastBullet BulletParticle;
    
    protected void SpawnPhysicsBullet(Transform shootersTransform)
    {
        // does not call collision until physics system collides

        PhysicsBullet spawnedBullet = Instantiate(PhysicsBulletPrefab, shootersTransform.position, shootersTransform.rotation);
        spawnedBullet.Initialize(this);
    }
    
    public void OnProjectileCollision(Vector3 position, Vector3 rotation)
    {
        // do stuff
            
            
        SpawnParticle(position, rotation);
    }
    
    private void SpawnParticle(Vector3 position, Vector3 rotation)
    {
                
        Instantiate(BulletParticle, position, Quaternion.Euler(rotation));
    }
}
