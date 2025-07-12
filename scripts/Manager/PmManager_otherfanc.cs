using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PmManager_otherfanc : MonoBehaviour
{

    private PmManager_modefanc mng_m;
    Enemy enemy;

    public PmManager_modefanc Mmg_mode { get { return mng_m; } }

    public static object Instance { get; internal set; }

    private void Start()
    {

        mng_m = GameObject.Find("Main Camera").GetComponent<PmManager_modefanc>();
        if (mng_m == null)
        {

            Debug.LogError("PmManager: mode (PmManager_modefanc) が null です。初期化を確認してください。");
            return;

        }
    }

    public void Setscore(int nowScore)
    {

        PmManager.score = nowScore;
        //UpdateScoreDisplay();

    }

    public void SetLife(int nowLife)
    {

        PmManager.life = nowLife;

    }

    public void InitGame()

    {

        mng_m.Mng.txtmap1.gameObject.SetActive(false);
        foreach (Transform pellet in Mmg_mode.Mng.meal)
        {
            pellet.gameObject.SetActive(true);
        }

        ResetStates();

    }


    public void ResetStates()
    {

        GhostResetMultiplayer();
        for (int i = 0; i < Mmg_mode.Mng.enemies.Length; i++) Mmg_mode.Mng.enemies[i].ResetState();
        mng_m.Mng.player.ResetStates();

    }

    public void EnemyEten(Enemy enemy)
    {

        Setscore(PmManager.score + enemy.eatenPt * Mmg_mode.Mng.ghostMultiplayer);
        Mmg_mode.Mng.ghostMultiplayer++;
  
    }

    public void PlayerEten()
    {
        if (Mmg_mode.Mng?.player != null)
        {
            Debug.Log("プレイヤーを非表示にします");
            mng_m.Mng.player.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("プレイヤーが存在しないか、null です");
        }

        if (PmManager.life > 0)
        {
            //SetLife(PmManager.life - 1); // 残機を減らしすぎない
            Debug.Log($"残機: {PmManager.life}");
            Invoke(nameof(ResetStates), 3.0f);
        }
        else
        {
            SetLife(0);
            Debug.Log("GameOver() を実行します");
            mng_m.GameOver();
        }
    }

    public void EatenNormalpellets(Pellets1 meel)
    {

        meel.gameObject.SetActive(false);

        Setscore(PmManager.score + meel.points);

        if(!CleaningPellets())
        {

            Mmg_mode.Mng.player.gameObject.SetActive(false);
            Invoke(nameof(InitGame), 3.0f);

        }

    }

    public void Eatenpowerpellets(Pellet2 meel)
    {

        EatenNormalpellets(meel);
        CancelInvoke();
        Invoke(nameof(GhostResetMultiplayer), meel.duration);

    }

    private bool CleaningPellets()
    {

        foreach(Transform pellet in Mmg_mode.Mng.meal)
        {

            if(pellet.gameObject.activeSelf)
            {

                return true;

            }

        }

        return false;

    }

    void GhostResetMultiplayer()
    {

        Mmg_mode.Mng.ghostMultiplayer = 1;

    }

    /*private void UpdateScoreDisplay()
    {
        // スコアをTextMeshに表示
        if (PmManager.scoreTextInstance != null)
        {
            var textMesh = PmManager.scoreTextInstance.GetComponent<TextMesh>();
            if (textMesh != null)
            {
                textMesh.text = PmManager.score.ToString();
            }
        }
    }*/

}
