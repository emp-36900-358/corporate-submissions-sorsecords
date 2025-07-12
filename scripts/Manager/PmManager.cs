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

    //public Vector3Int tilePosition; // �X�R�A��\������Tile�̍��W
    //public GameObject scoreTextPrefab; // �X�R�A��\������TextMesh�̃v���n�u
    //public static GameObject scoreTextInstance; // TextMesh�̃C���X�^���X
    public bool clarglg, overflg;

    public static int score;
    public static int life;

    PmManager_otherfanc otherfanc;
    PmManager_modefanc mode;

    public PmManager_modefanc Mode { get { return mode; } }

    public static object Instance { get; internal set; }

    private void Awake() // Start() �ł͂Ȃ� Awake() �ɕύX
    {
        otherfanc = GameObject.Find("Main Camera").GetComponent<PmManager_otherfanc>();

        if (otherfanc == null)
        {
            Debug.LogError("PmManager: PmManager_modefanc ��������܂���BMain Camera �ɃA�^�b�`����Ă��܂����H");
        }

        mode = GameObject.Find("Main Camera").GetComponent<PmManager_modefanc>();

        if (mode == null)
        {
            Debug.LogError("PmManager: PmManager_modefanc ��������܂���BMain Camera �ɃA�^�b�`����Ă��܂����H");
        }

        player = GameObject.Find("Pacman_Player").GetComponent<Player>();

        if (player == null)
        {
            Debug.LogError("PmManager: Player ��������܂���B'Pacman_Player' �� GameObject �������������m�F���Ă��������B");
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

        //Vector3 worldPosition = numtile2.CellToWorld(tilePosition) + new Vector3(0.5f, 0.5f, 0); // �����ɔz�u
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
