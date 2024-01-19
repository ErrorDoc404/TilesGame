using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public Transform _transform;

    
    void Update()
    {
        OnMove();        
    }
    public void OnMove()
    {
        Vector2 paddlePos = _transform.position;
        paddlePos.x = Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,-2.2f,2.14f);
        _transform.position = paddlePos;
    }
}
