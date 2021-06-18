using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMover : MonoBehaviour
{
    
    [SerializeField] private RectTransform _canvasTransform;
    [SerializeField] private float _speed;
    [SerializeField] bool _isRepeated = false;

    private float _screenHeight;
    private float _startYPosition;

    private void Start() 
    {   
        _screenHeight = _canvasTransform.rect.height * _canvasTransform.localScale.y;

        if(_isRepeated)
        {
            // increase height by size of screen height
            RectTransform rt = GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, rt.sizeDelta.y + _canvasTransform.rect.height);
            transform.position = new Vector3(transform.position.x, transform.position.y + _screenHeight, 0);
        }

        _startYPosition = transform.position.y;
    }

    private void Update() 
    {
        if(_isRepeated)
        {
            if( (transform.position.y - (_screenHeight/ 2)) > 0 )
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
