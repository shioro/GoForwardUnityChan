using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //地面の位置
    //private float groundLevel = -3.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //TODO 地面かキュービに接触しているかどうかを調べる
        //bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        //this.animator.SetBool("isGround", isGround);

        //TODO 接触している時にはボリュームを1にする
        //GetComponent<AudioSource>().volume = (isGround) ? 0 : 1;

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "CubePrefab(Clone)" || collision.gameObject.name == "ground")
        {
            GetComponent<AudioSource>().Play();
        }
    }
    
}
