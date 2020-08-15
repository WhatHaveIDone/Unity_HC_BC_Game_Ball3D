using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 基於MVC架構 本質為關卡管理器 </summary>
public class MVCGame : MonoBehaviour
{
    /// <summary> 基礎模組 </summary>
    [SerializeField] GameObject mod;
    /// <summary> 玩家座標 </summary>
    [SerializeField] Transform player;

    void Start()    
    {
        // 初始化時執行一次
        Debug.Log("初始化完成~");

        // 預先生成一排模組
        CreateMod();
        CreateMod();
        CreateMod();
        CreateMod();
    }

    /// <summary> 要生成東西的'門檻',隨著每一次遇到門檻,會自動下降 </summary>
    float door = -2f;

    void Update()  
    {
        // 每一禎執行一次

        // 如果玩家的Y值小於門檻值時
        if (player.position.y < door)
        {
            // 降低門檻供下次使用
            door += -2f;
            // 呼叫關卡生成器
            CreateMod();

        }
        root.transform.Rotate(0f,Input.GetAxis("Mouse X")*5f ,0f);
    }


    [SerializeField] Transform root;
    /// <summary> 關卡生成器 </summary>
    void CreateMod()
    {
        // 降低MVCGgame物件本身的座標
        this.transform.Translate(0f, -2f, 0f);
        // 亂數 在0~360間抽出一個數字
        float r = Random.Range(0,360);
        // 利用抽出的數字 旋轉MVCGame本身
        this.transform.Rotate(0f, r, 0f);
        // 利用MVCGgame本身的參數 生成模組 並放入母物件中
        Instantiate(mod, this.transform.position, this.transform.rotation).transform.SetParent(root);
    }

}
