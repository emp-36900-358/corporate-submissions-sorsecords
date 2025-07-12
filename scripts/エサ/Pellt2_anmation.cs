using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Pellt2_anmation : Pellet2
{
    public SpriteRenderer pellet_sr; // SpriteRenderer を使用
    public float anim_cycle = 1.0f;  // 点滅のサイクル時間
    private float elapsedTime;       // 経過時間

    // Update is called once per frame
    void Update()
    {

        BlinkingAnim();

    }

    public void BlinkingAnim()
    {

        // 経過時間を加算
        elapsedTime += Time.deltaTime;

        // サイクル内の時間を計算
        float cycleTime = Mathf.Repeat(elapsedTime, anim_cycle);

        // アルファ値を計算 (0 から 1 までの三角波を生成)
        float alpha = Mathf.PingPong(cycleTime / (anim_cycle * 0.5f), 1.0f);

        // SpriteRenderer の色のアルファ値を更新
        if (pellet_sr != null)
        {

            Color color = pellet_sr.color;
            color.a = alpha;
            pellet_sr.color = color;

        }

    }

}