using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public partial class PmManager : MonoBehaviour
{

    public Enemy[] enemies;

    public Player player;

    public Transform meal;

    public Tilemap txtmap1, txtmap2, txtmap3, delTile, numtile1, numtile2;

    public int ghostMultiplayer = 1;

    //public Vector3Int tilePosition; // スコアを表示するTileの座標
    //public GameObject scoreTextPrefab; // スコアを表示するTextMeshのプレハブ
    //public static GameObject scoreTextInstance; // TextMeshのインスタンス
    public bool clarglg, overflg;

    public static int score;
    public static int life;

    PmManager_otherfanc otherfanc;
    PmManager_modefanc mode;

    public PmManager_modefanc Mode { get { return mode; } }

    public static object Instance { get; internal set; }

    private void Awake() // Start() ではなく Awake() に変更
    {
        otherfanc = GameObject.Find("Main Camera").GetComponent<PmManager_otherfanc>();

        if (otherfanc == null)
        {
            Debug.LogError("PmManager: PmManager_modefanc が見つかりません。Main Camera にアタッチされていますか？");
        }

        mode = GameObject.Find("Main Camera").GetComponent<PmManager_modefanc>();

        if (mode == null)
        {
            Debug.LogError("PmManager: PmManager_modefanc が見つかりません。Main Camera にアタッチされていますか？");
        }

        player = GameObject.Find("Pacman_Player").GetComponent<Player>();

        if (player == null)
        {
            Debug.LogError("PmManager: Player が見つかりません。'Pacman_Player' の GameObject 名が正しいか確認してください。");
        }

        /*for (int i = 0; i < enemies.Length; i++) {
       
            enemies[i] = GameObject.Find("monster_atlus_0").GetComponent<Enemy>();
            enemies[i] = GameObject.Find("monster_atlus_24").GetComponent<Enemy>();
            enemies[i] = GameObject.Find("monster_atlus_15").GetComponent<Enemy>();
            enemies[i] = GameObject.Find("monster_atlus_16").GetComponent<Enemy>();

        }*/

        player.enabled = true;

    }

    // Start is called before the first frame update
    void Start()
    {

        //Vector3 worldPosition = numtile2.CellToWorld(tilePosition) + new Vector3(0.5f, 0.5f, 0); // 中央に配置
        //scoreTextInstance = Instantiate(scoreTextPrefab, worldPosition, Quaternion.identity);
        overflg = false;
        clarglg = false;
        mode.Invoke(nameof(Mode.IdolScrean), 0.0f);
        CancelInvoke();
        mode.Invoke(nameof(Mode.StartScrean), 3.0f);
        CancelInvoke();
        mode.Invoke(nameof(Mode.ReadyScrean), 7.0f);
        CancelInvoke();
        mode.Invoke(nameof(Mode.NewGame), 11.0f);
        txtmap1.gameObject.SetActive(false);

    }

    // U
    void Update()
    {

        //Invoke(nameof(Mode.NewGame), 5.0f);
        Debug.Log(life);
        Debug.Log(score);
        Debug.Log(player.st);


        if (life > 0 && overflg)
        {

            mode.ReadyScrean();
            txtmap1.gameObject.SetActive(false);

        }

        if (life <= 0 && Input.anyKeyDown)
        {

            overflg = false;
            Debug.Log(overflg);
            otherfanc.SetLife(0);
            player.transform.position = player.respawnPos;
            txtmap2.gameObject.SetActive(false);
            mode.ReadyScrean();

        }

    }

}
