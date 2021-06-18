using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : MonoBehaviour
{

    [SerializeField] protected float _speed = 0.5f;
    [SerializeField] protected float _damage = 5f;

    // props
    public float Damage { get => _damage; }
    
    private void Update()
    {
        Fly();
    }

    protected virtual void Fly()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + _speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Destroyer destroyer = other.GetComponent<Destroyer>();
        if( other.GetComponent<EnemieBase>() || (destroyer && (destroyer.type == DestroyerType.Top)) )
        {
            Destroy(gameObject);
        }
    }

}
