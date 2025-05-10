using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Rendering.VirtualTexturing;


public class PlayerController : MonoBehaviour
{
    [SerializeField]public int speed; //Dùng để thay đổi tốc độ
    public Vector3[] point;
    private void Start()
    {
        Debug.Log(speed);
    }

    private void Update()
    {
        
    }
}
