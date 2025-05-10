using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class ShowLog : MonoBehaviour
{


    private void Start()
    {
        // Gọi sau hàm Awake và OnEnable và trước khi nó cập nhật khung hình đầu tiên
        Debug.Log("Start");
    }


    private void Update()
    {
        Debug.Log("Update");
    }
}

    