using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : ShipBase
{

    private bool _onHold = false;

    // props
    public bool OnHold { get => _onHold; }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if(_onHold)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0;
            Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

            mousePos.x = mousePos.x - objectPos.x;
            mousePos.y = mousePos.y - objectPos.y;

            Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = 0;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, _speed * Time.deltaTime);
        }
    }

    private void OnMouseDown() 
    {
        _onHold = true;
    }

    private void OnMouseUp() 
    {
        _onHold = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemieBase enemie = other.GetComponent<EnemieBase>();
        if(enemie)
        {
            Damage(enemie.collisionDamage);
        }
    }

    protected override void Death()
    {
        Destroy(gameObject);
        Game.GameOver();
    }

}
