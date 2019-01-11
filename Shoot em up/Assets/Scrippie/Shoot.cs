using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bulletPrefab;

    public void ShootBullet()
    {
        Instantiate(bulletPrefab);
    }
}
