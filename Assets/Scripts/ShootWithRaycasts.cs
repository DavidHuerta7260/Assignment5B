using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float hitForce = 10f;
    public Camera cam;
    public ParticleSystem muzzleFlash;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // At the beginning of the Shoot() method, play the particle effect
        if (muzzleFlash != null)
        {
            muzzleFlash.Play();
        }

        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            // Get the Target script off the hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            // If a target script was found, make the target take damage
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            // If the shot hits a Rigidbody, apply a force
            if (hitInfo.rigidbody != null)
            {
                // Use the camera�s forward direction (so force pushes in view direction)
                hitInfo.rigidbody.AddForce(cam.transform.forward * hitForce, ForceMode.Impulse);
            }
        }
    }
}
