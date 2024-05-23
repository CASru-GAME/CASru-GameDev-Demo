using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    // ampを振幅としてspeedの速さでcenterPointを中心とした上下運動を行う
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
        // 移動方向の変更判定を行う
        if (_centerPoint.y + amp/2 <= this.gameObject.transform.position.y)
        {
            isMoveUp = false;
        }
        else if (this.gameObject.transform.position.y  <= _centerPoint.y - amp / 2)
        {
            isMoveUp = true;
        }

        // 上下移動を行う
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
