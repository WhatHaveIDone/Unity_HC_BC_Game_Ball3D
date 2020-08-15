using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVCGame : MonoBehaviour
{
    [SerializeField] GameObject mod;
    void Start()    
    {
        // 初始化時執行一次
        Debug.Log("初始化完成~");
        
        // 實例化模組
        Instantiate(mod);
    }

    void Update()  
    {
        // 每一禎執行一次
    }
}
