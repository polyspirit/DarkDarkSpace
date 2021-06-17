using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieSimple : EnemieBase
{

    protected override void Move()
    {
        transform.position = new Vector3(
            transform.position.x, 
            transform.position.y - (_speed * Time.deltaTime), 
            0
        );
    }

}
