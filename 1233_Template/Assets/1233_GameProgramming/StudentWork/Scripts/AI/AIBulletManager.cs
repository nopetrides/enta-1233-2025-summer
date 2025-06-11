using System.Collections;
using System.Collections.Generic;
using Kobolds;
using UnityEngine;

public class AIBulletManager : BaseBulletManager
{
    [SerializeField] private Transform BulletSpawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // todo add a way to trigger the shooting for the AI 
        // ONLY do it when it sees the player
    }

    private void Fire()
    {
        SpawnPhysicsBullet(BulletSpawnPoint);
    }
}
