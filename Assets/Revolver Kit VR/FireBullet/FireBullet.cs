using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;
    public float launchSpeed;

    public void FireBulletMethod()
    {
        GameObject newObject = Instantiate(bullet, spawnpoint.position, spawnpoint.rotation, null);

        if (newObject.TryGetComponent(out Rigidbody rigidBody))
        {
            ApplyForce(rigidBody);
        }
    }

    void ApplyForce(Rigidbody rigidBody)
    {
        Vector3 force = spawnpoint.forward * launchSpeed;
            rigidBody.AddForce(force);
    }
}
