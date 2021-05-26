using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialBulletController : MonoBehaviour
{
    [Header("Projectile Settings")]
    public GameObject ProjectilePrefab;         // Prefab to spawn
    public int numberOfProjectiles;             // Number of projectiles to shoot
    public float projectileSpeed;               // Speed of theprojectile
    public float radius = 10f;                  // Helps find the move direction


    private Vector3 startPoint;                 // Starting position of the bullet
    private float secondsToDestroyBullets = 3f; // Destroys the instantiated bullets after x seconds


    private void Start()
    {
        startPoint = transform.position;
        InvokeRepeating("SpawnProjectile", 2f, 1f);
    }

    // Spawns x number of projectiles
    private void SpawnProjectile()
    {
        float angleStep = 360f / numberOfProjectiles;
        float angle = 0f;

        for(int i = 0; i <= numberOfProjectiles; i++)
        {
            // Direction calculations
            float projectileDirXPosition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float projectileDirYPosition = startPoint.x + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector3 projectileVector = new Vector3(projectileDirXPosition, projectileDirYPosition, 0);
            Vector3 projectileMoveDirection = (projectileVector - startPoint).normalized * projectileSpeed;

            GameObject tmpObj = Instantiate(ProjectilePrefab, startPoint, Quaternion.identity);
            tmpObj.GetComponent<Rigidbody2D>().velocity = new Vector3(projectileMoveDirection.x, projectileMoveDirection.y, 0);

            angle += angleStep;

            // Destroys bullets after x seconds
            Destroy(tmpObj, secondsToDestroyBullets);
        }
    }
}
