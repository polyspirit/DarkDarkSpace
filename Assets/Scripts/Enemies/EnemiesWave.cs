using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesWave : MonoBehaviour
{
    
    [SerializeField] private List<EnemiePosition> _enemiesPositions = new List<EnemiePosition>();

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.GetComponent<EnemiesSpawn>())
        {
            SpawnEnemies();
        }
    }

    private void SpawnEnemies()
    {
        foreach (EnemiePosition enemiePos in _enemiesPositions)
        {
            Instantiate(enemiePos.enemieObj, enemiePos.position, Quaternion.identity);
        }
    }

}

[System.Serializable]
public struct EnemiePosition
{
    public GameObject enemieObj;
    public Transform point;

    // props
    public Vector3 position { get => point.position; }
}