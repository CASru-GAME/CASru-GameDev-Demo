using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    // 上下に移動させるスクリプト
    [SerializeField] private float amp = 6;

    [SerializeField] private float speed = 3;

    private Vector3 _centerPoint;

    bool isMoveUp = true;

    private void Start()
    {
        _centerPoint = this.gameObject.transform.position;
    }

    private void Update()
    {
        // 端に来たら折り返す
        if (_centerPoint.y + amp/2 <= this.gameObject.transform.position.y)
        {
            isMoveUp = false;
        }
        else if (this.gameObject.transform.position.y  <= _centerPoint.y - amp / 2)
        {
            isMoveUp = true;
        }

        // 移動する
        if (isMoveUp)
        {
            this.gameObject.transform.Translate(0,speed * Time.deltaTime,0);
        }
        else
        {
            this.gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
        }  
    }
}
