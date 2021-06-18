using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipBase : MonoBehaviour
{
    
    [SerializeField] protected float _speed = 10f;
    [SerializeField] protected float _health = 50f;
    
    protected float _collisionDamage;

    // props
    public float collisionDamage { get => _collisionDamage; }

    private void Start() 
    {
        _collisionDamage = _health;
    }

    protected void Damage(float damage)
    {
        _health -= damage;
        if(_health <= 0)
        {
            Death();
        }
    }

    protected virtual void Death()
    {
        Destroy(gameObject);
    }

}
