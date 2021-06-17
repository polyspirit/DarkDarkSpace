using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemieBase : MonoBehaviour
{
    
    [SerializeField] protected float _speed = 10f;
    [SerializeField] protected float _health = 10f;

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
            Damage(bullet);
        }    
    }

    private void Damage(BulletBase bullet)
    {
        _health -= bullet.Damage;
        if(_health <= 0)
        {
            Destroy(gameObject);
        }

    }


}
