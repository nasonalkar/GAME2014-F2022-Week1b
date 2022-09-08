using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    float _xDirection;
    float _yDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _xDirection = Input.GetAxis("Horizontal") * Time.deltaTime * _speed;
        _yDirection = Input.GetAxis("Vertical") * Time.deltaTime * _speed;

        transform.position = new Vector2(transform.position.x + _xDirection, 
                             transform.position.y + _yDirection) ;
    }
}
