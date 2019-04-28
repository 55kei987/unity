using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int x;
    int z;

    protected float jump_speed = 12.0f;     public bool is_landing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;

        // ワールド座標を基準に、座標を取得
        Vector3 worldPos = myTransform.position;
        worldPos.x = x;    // ワールド座標を基準にした、x座標を1に変更
        worldPos.z = z;    // ワールド座標を基準にした、z座標を1に変更
        myTransform.position = worldPos;  // ワールド座標での座標を設定

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x += -1;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            z += 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            z += -1;
        }
    }
}
