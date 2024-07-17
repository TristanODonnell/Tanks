using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private float shootingStrengh;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootingPoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
        GameObject bulletClone = Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
        bulletClone.GetComponent<Rigidbody>().AddForce(bulletClone.transform.forward * shootingStrengh, ForceMode.VelocityChange);
        Destroy(bulletClone, 3f);
    }
}
