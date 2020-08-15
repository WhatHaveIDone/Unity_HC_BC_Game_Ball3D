using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;

    /// <summary> 碰撞的瞬間 </summary>
    private void OnCollisionEnter(Collision collision)
    {
        // 如果碰到我的人是 Pie
        if(collision.gameObject.tag == "Pie")
        {
            // = 左邊變成右邊
            // == 左邊等於右邊?

            // 改變玩家的物理
            rigidbody.velocity = new Vector3(0f, 5f, 0f);


        }

    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
