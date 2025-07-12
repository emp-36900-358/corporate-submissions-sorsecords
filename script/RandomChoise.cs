using Stage;
using System.Collections.Generic;
using UnityEngine;


public class RandomChoise:MonoBehaviour
{

    public class DuplicationOnce 
    {

        Items items;  // Items クラスのインスタンス
        List<Items> itemList = new List<Items>(); // アイテムリスト
        Dictionary<Items, int> itemCounts = new Dictionary<Items, int>(); // 出現回数管理
        public int maxDuplicates = 1; // 各アイテムが最大何回出るか

        void Start()
        {
            // アイテムリストを取得 (仮の処理、実際はItems.csから取得)
            itemList = GetItemListFromItemsClass();

            // 出現回数をリセット
            foreach (var item in itemList)
            {
                itemCounts[item] = 0;
            }
        }

        public Items GetRandomItem()
        {
            List<Items> availableItems = new List<Items>();

            // まだ maxDuplicates 回未満のアイテムを抽選対象にする
            foreach (var item in itemList)
            {
                if (itemCounts[item] < maxDuplicates)
                {
                    availableItems.Add(item);
                }
            }

            if (availableItems.Count == 0)
            {
                Debug.LogWarning("すべてのアイテムが最大出現回数に達しました！");
                return null;
            }

            // ランダム抽選
            int randomIndex = Random.Range(0, availableItems.Count);
            Items selectedItem = availableItems[randomIndex];

            // 出現回数を増やす
            itemCounts[selectedItem]++;

            return selectedItem;
        }

        // 仮のアイテムリスト取得メソッド (実際にはItems.csにあるメソッドを使う)
        private List<Items> GetItemListFromItemsClass()
        {
            return new List<Items>(); // 実際のItemsデータを取得
        }
    }

    public class NoDuplication 
    {

        Stage_List.Stages stages; // Stages.cs の Stage_List を参照
        List<Stage_List.Stages> stageList = new List<Stage_List.Stages>(); // ステージリスト
        int currentIndex = 0; // 取得位置
        int startLevel = 8; // Lv.8 から開始

        void Start()
        {
            // ステージリストを取得し、Lv.8以上のステージのみリスト化
            stageList = GetStageListFromStagesClass();
            // ステージが1つ以上ある場合にのみシャッフル
            if (stageList.Count > 0)
            {
                ShuffleStageList();
            }
            else
            {
                Debug.LogWarning("Lv.8 以上のステージがありません！");
            }
        }

        public Stage_List.Stages GetUniqueRandomStage()
        {
            if (currentIndex >= stageList.Count)
            {
                Debug.LogWarning("すべてのステージが一度ずつ選ばれました！");
                return default(Stage_List.Stages); // 既定値を返す
            }

            return stageList[currentIndex++];
        }

        // リストをシャッフルするメソッド
        void ShuffleStageList()
        {
            for (int i = 0; i < stageList.Count; i++)
            {
                int randomIndex = Random.Range(i, stageList.Count);
                (stageList[i], stageList[randomIndex]) = (stageList[randomIndex], stageList[i]); // Swap
            }
        }

        // 仮のステージリスト取得メソッド (実際にはStages.csのメソッドを使用)
        private List<Stage_List.Stages> GetStageListFromStagesClass()
        {
            // ここで実際のステージデータを取得する
            List<Stage_List.Stages> allStages = new List<Stage_List.Stages>();

            // 仮のステージデータを追加 (テスト用)
            for (int i = 8; i <= 20; i++)
            {
                Stage_List.Stages stage = new Stage_List.Stages(i); // インスタンスを作成
                allStages.Add(stage); // リストに追加        

            }

            return allStages; //実際にはStage_Listのデータを返す

        }

    }

}
