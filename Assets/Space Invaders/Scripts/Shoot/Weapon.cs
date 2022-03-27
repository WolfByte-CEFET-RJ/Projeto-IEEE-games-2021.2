using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Tirinho shootObject; //prefab = tirinho
    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        //queria deixar o espa�o como trigger 
        //Esse comando tamb�m acaba com o problema dos tiros estarem se multiplicando
		if (Input.GetButtonDown("Jump"))
		{
            Shoot();
		}
    }

    void Shoot()
	{
        shootObject.playerShoot = true;
        Instantiate(shootObject.gameObject, firePoint.position, firePoint.rotation);
	}
}