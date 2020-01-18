using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserWeapon : Weapon
{

    public GameObject laserBullet;
    public float cadencia;
   

    public override float GetCadencia()
    {
        return cadencia;
    }

    public override void Shoot()
    {

        Instantiate(laserBullet, this.transform.position, Quaternion.identity, null);
    }
}

