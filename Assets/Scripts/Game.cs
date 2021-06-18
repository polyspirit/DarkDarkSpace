using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    
    [SerializeField] private GameObject _gameOverObject;

    private static GameObject _gameOverObjectStatic;

    private void Start() 
    {
        _gameOverObjectStatic = _gameOverObject;
    }
    
    public static void GameOver()
    {
        _gameOverObjectStatic.SetActive(true);
    }
    

}
