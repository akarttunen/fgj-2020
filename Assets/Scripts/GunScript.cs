using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public float impactForce = 30f;
    public float magazineSize = 30f;
    public float reloadTime = 2f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource audioSourceObj;
    public AudioClip gunShootSound;
    public AudioClip gunReloadSound;

    private float nextTimeToFire = 0f;
    private float nextTimeToReload = 0f;
    private float bulletsLeft = 0f;
    // Update is called once per frame
    void Update()
    {

        if(Input.GetButton("Fire1") && Time.time >= nextTimeToFire && bulletsLeft < magazineSize && Time.time >= nextTimeToReload) {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R) && Time.time >= nextTimeToReload) 
        {
            nextTimeToReload = Time.time + reloadTime;
            Reload();
        }
    }

    void Shoot() {
        muzzleFlash.Play();
        audioSourceObj.PlayOneShot(gunShootSound);
        RaycastHit hit;
        bulletsLeft += 1;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            

            GameObject ImpactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(ImpactGO, 2f);
        };
    }

    void Reload()
    {
        audioSourceObj.PlayOneShot(gunReloadSound);
        bulletsLeft = 0f;
    }
}
