using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Stage;

public class instanceblocks : MonoBehaviour
{

    public GameObject blockPrefab0, blockPrefab1, blockPrefab2, blockPrefab3, blockPrefab4, blockPrefab5, blockPrefab6;
    public enum Status {Fine, Dead, Damaged};
    public static int instancecnt;
    float blockWidth = 0.6f; // ブロックの横幅（仮定）
    float blockHeight = 0.25f; // ブロックの縦幅（仮定）
    ball1.Status bStatus;

    // Start is called before the first frame update
    void Start()
    {

        OutputLevel1map();
        //Instantiate(blockPrefab6, new Vector3(-1.72f, 2.92f, 0.0f), Quaternion.identity);

    }

    public void OutputLevel1map()
    {


        bStatus = ball1.Status.Fine;
        instancecnt = 21;

        for (int i = 0; i < NormalStges.map1.GetLength(0); i++)
        {

            for (int j = 0; j < NormalStges.map1.GetLength(1); j++)
            {

                float xOffset = -1.8f + j * blockWidth; // 横方向の位置調整
                float yOffset = 0.25f + i * blockHeight; // 縦方向の位置調整

                switch (NormalStges.map1[i, j])
                {

                    case 1:
                        Instantiate(blockPrefab1, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                        break;

                    case 2:
                        Instantiate(blockPrefab2, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                        break;

                    case 3:
                        Instantiate(blockPrefab3, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                        break;

                    case 4:
                        Instantiate(blockPrefab4, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                        break;

                    case 5:
                        Instantiate(blockPrefab5, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                        break;


                }
            }
        }
    }

    public void OutputLevel2map()
    {
            bStatus = ball1.Status.Fine;
            instancecnt = 28;

        if (bbmanager.nowlevel == 2 && bStatus == ball1.Status.Fine)
        {

            for (int i = 0; i < NormalStges.map2.GetLength(0); i++)
            {

                for (int j = 0; j < NormalStges.map2.GetLength(1); j++)
                {

                    float xOffset = -1.8f + j * blockWidth; // 横方向の位置調整
                    float yOffset = 0.25f + i * blockHeight; // 縦方向の位置調整

                    switch (NormalStges.map2[i, j])
                    {

                        case 1:
                            Instantiate(blockPrefab1, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 2:
                            Instantiate(blockPrefab2, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 3:
                            Instantiate(blockPrefab3, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 4:
                            Instantiate(blockPrefab4, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 5:
                            Instantiate(blockPrefab5, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                    }

                }

            }

        }

    }

    public void OutputLevel3map()
    {
        bStatus = ball1.Status.Fine;
        instancecnt = 35;

        if (bbmanager.nowlevel == 3 && bStatus == ball1.Status.Fine)
        {

            for (int i = 0; i < NormalStges.map3.GetLength(0); i++)
            {

                for (int j = 0; j < NormalStges.map3.GetLength(1); j++)
                {

                    float xOffset = -1.8f + j * blockWidth; // 横方向の位置調整
                    float yOffset = 0.25f + i * blockHeight; // 縦方向の位置調整

                    switch (NormalStges.map3[i, j])
                    {

                        case 1:
                            Instantiate(blockPrefab1, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 2:
                            Instantiate(blockPrefab2, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 3:
                            Instantiate(blockPrefab3, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 4:
                            Instantiate(blockPrefab4, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 5:
                            Instantiate(blockPrefab5, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

       
                    }

                }

            }

        }

    }

    public void OutputLevel4_7map()
    {
        bStatus = ball1.Status.Fine;
        instancecnt = 35;

        if ( bbmanager.nowlevel > 3 && bbmanager.nowlevel < 8 && bStatus == ball1.Status.Fine)
        {

            for (int i = 0; i < NormalStges.map4_7.GetLength(0); i++)
            {

                for (int j = 0; j < NormalStges.map4_7.GetLength(1); j++)
                {

                    float xOffset = -1.8f + j * blockWidth; // 横方向の位置調整
                    float yOffset = 0.25f + i * blockHeight; // 縦方向の位置調整

                    switch (NormalStges.map4_7[i, j])
                    {

                        case 1:
                            Instantiate(blockPrefab1, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 2:
                            Instantiate(blockPrefab2, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 3:
                            Instantiate(blockPrefab3, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 4:
                            Instantiate(blockPrefab4, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 5:
                            Instantiate(blockPrefab5, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 6:
                            Instantiate(blockPrefab6, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                    }

                }

            }

        }

    }

    public void OutputMapTile8()
    {
        bStatus = ball1.Status.Fine;
        instancecnt = 63;

        if (bbmanager.nowlevel > 7 && bStatus == ball1.Status.Fine)
        {

            for (int i = 0; i < NormalStges.map8.GetLength(0); i++)
            {

                for (int j = 0; j < NormalStges.map8.GetLength(1); j++)
                {

                    float xOffset = -1.8f + j * blockWidth; // 横方向の位置調整
                    float yOffset = 0.25f + i * blockHeight; // 縦方向の位置調整

                    switch (NormalStges.map2[i, j])
                    {

                        case 0:
                            Instantiate(blockPrefab0, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 1:
                            Instantiate(blockPrefab1, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 2:
                            Instantiate(blockPrefab2, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 3:
                            Instantiate(blockPrefab3, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 4:
                            Instantiate(blockPrefab4, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 5:
                            Instantiate(blockPrefab5, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 6:
                            Instantiate(blockPrefab6, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                    }

                }

            }

        }

    }

    public void OutpuMapTile9()
    {
        bStatus = ball1.Status.Fine;
        instancecnt = 105;

        if (bbmanager.nowlevel > 7 && bStatus == ball1.Status.Fine)
        {

            for (int i = 0; i < NormalStges.map8.GetLength(0); i++)
            {

                for (int j = 0; j < NormalStges.map8.GetLength(1); j++)
                {

                    float xOffset = -1.8f + j * blockWidth; // 横方向の位置調整
                    float yOffset = 0.25f + i * blockHeight; // 縦方向の位置調整

                    switch (NormalStges.map2[i, j])
                    {

                        case 0:
                            Instantiate(blockPrefab0, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 1:
                            Instantiate(blockPrefab1, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 2:
                            Instantiate(blockPrefab2, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 3:
                            Instantiate(blockPrefab3, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 4:
                            Instantiate(blockPrefab4, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 5:
                            Instantiate(blockPrefab5, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                        case 6:
                            Instantiate(blockPrefab6, new Vector3(xOffset, yOffset, 0.0f), Quaternion.identity);
                            break;

                    }

                }

            }

        }

    }

}