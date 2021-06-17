using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    
    [SerializeField] protected float _interval = 0.1f;
    [SerializeField] protected BulletBase _bullet;
    [SerializeField] protected List<Transform> _guns = new List<Transform>();

    private float _timeToNextBullet = 0f;
    private Ship _ship;

    private void Start() 
    {
        _ship = GetComponentInParent<Ship>();
    }

    private void Update() 
    {
        if(_ship.OnHold)
            {
            if(_timeToNextBullet < _interval)
            {
                _timeToNextBullet += Time.deltaTime;
            }
            else
            {
                _timeToNextBullet = 0f;
                Fire();
            }
        }
    }

    private void Fire()
    {
        foreach (Transform gunTransform in _guns)
        {
            BulletBase bullet = Instantiate(_bullet, gunTransform.position, Quaternion.identity);
        }
    }
    
}
