using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemieBase : ShipBase
{

    private void Update() 
    {
        Move();
    }

    protected abstract void Move();

    private void OnTriggerEnter2D(Collider2D other) 
    {
        BulletBase bullet = other.GetComponent<BulletBase>();
        if(bullet)
        {
            Damage(bullet.Damage);
        }

        Ship ship = other.GetComponent<Ship>();
        if(ship)
        {
            Damage(ship.collisionDamage);
        }

        Destroyer destroyer = other.GetComponent<Destroyer>();
        if(destroyer && (destroyer.type == DestroyerType.Bottom))
        {
            Death();
        }
    }


}
