using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPressMoveRight : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    void Update()
    {
        if (Input.GetKey("right"))
        {
            this.gameObject.transform.Translate(speed * Time.deltaTime,0,0);
        }
    }
}
