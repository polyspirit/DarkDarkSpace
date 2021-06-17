using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMover : MonoBehaviour
{
    
    [SerializeField] private RectTransform _canvasTransform;
    [SerializeField] private float _speed;
    [SerializeField] bool _isRepeated = false;

    private float _height;
    private float _startYPosition;

    private void Start() 
    {
        _startYPosition = transform.position.y;
        _height = _canvasTransform.rect.height * _canvasTransform.localScale.y;
    }

    private void Update() 
    {
        if(_isRepeated)
        {
            if( (transform.position.y - (_height/ 2)) > 0 )
            {
                MoveDown();
            }
            else
            {
                transform.position = new Vector3(transform.position.x, _startYPosition, 0);
            }
        }
        else
        {
            MoveDown();
        }
    }

    private void MoveDown()
    {
        transform.position = new Vector3(
            transform.position.x, transform.position.y - (_speed * Time.deltaTime), 0
        );
    }

}
