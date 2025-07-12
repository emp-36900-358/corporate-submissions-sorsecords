using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Pellt2_anmation : Pellet2
{
    public SpriteRenderer pellet_sr; // SpriteRenderer ���g�p
    public float anim_cycle = 1.0f;  // �_�ł̃T�C�N������
    private float elapsedTime;       // �o�ߎ���

    // Update is called once per frame
    void Update()
    {

        BlinkingAnim();

    }

    public void BlinkingAnim()
    {

        // �o�ߎ��Ԃ����Z
        elapsedTime += Time.deltaTime;

        // �T�C�N�����̎��Ԃ��v�Z
        float cycleTime = Mathf.Repeat(elapsedTime, anim_cycle);

        // �A���t�@�l���v�Z (0 ���� 1 �܂ł̎O�p�g�𐶐�)
        float alpha = Mathf.PingPong(cycleTime / (anim_cycle * 0.5f), 1.0f);

        // SpriteRenderer �̐F�̃A���t�@�l���X�V
        if (pellet_sr != null)
        {

            Color color = pellet_sr.color;
            color.a = alpha;
            pellet_sr.color = color;

        }

    }

}