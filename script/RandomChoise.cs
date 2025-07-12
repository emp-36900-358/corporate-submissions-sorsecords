using Stage;
using System.Collections.Generic;
using UnityEngine;


public class RandomChoise:MonoBehaviour
{

    public class DuplicationOnce 
    {

        Items items;  // Items �N���X�̃C���X�^���X
        List<Items> itemList = new List<Items>(); // �A�C�e�����X�g
        Dictionary<Items, int> itemCounts = new Dictionary<Items, int>(); // �o���񐔊Ǘ�
        public int maxDuplicates = 1; // �e�A�C�e�����ő剽��o�邩

        void Start()
        {
            // �A�C�e�����X�g���擾 (���̏����A���ۂ�Items.cs����擾)
            itemList = GetItemListFromItemsClass();

            // �o���񐔂����Z�b�g
            foreach (var item in itemList)
            {
                itemCounts[item] = 0;
            }
        }

        public Items GetRandomItem()
        {
            List<Items> availableItems = new List<Items>();

            // �܂� maxDuplicates �񖢖��̃A�C�e���𒊑I�Ώۂɂ���
            foreach (var item in itemList)
            {
                if (itemCounts[item] < maxDuplicates)
                {
                    availableItems.Add(item);
                }
            }

            if (availableItems.Count == 0)
            {
                Debug.LogWarning("���ׂẴA�C�e�����ő�o���񐔂ɒB���܂����I");
                return null;
            }

            // �����_�����I
            int randomIndex = Random.Range(0, availableItems.Count);
            Items selectedItem = availableItems[randomIndex];

            // �o���񐔂𑝂₷
            itemCounts[selectedItem]++;

            return selectedItem;
        }

        // ���̃A�C�e�����X�g�擾���\�b�h (���ۂɂ�Items.cs�ɂ��郁�\�b�h���g��)
        private List<Items> GetItemListFromItemsClass()
        {
            return new List<Items>(); // ���ۂ�Items�f�[�^���擾
        }
    }

    public class NoDuplication 
    {

        Stage_List.Stages stages; // Stages.cs �� Stage_List ���Q��
        List<Stage_List.Stages> stageList = new List<Stage_List.Stages>(); // �X�e�[�W���X�g
        int currentIndex = 0; // �擾�ʒu
        int startLevel = 8; // Lv.8 ����J�n

        void Start()
        {
            // �X�e�[�W���X�g���擾���ALv.8�ȏ�̃X�e�[�W�̂݃��X�g��
            stageList = GetStageListFromStagesClass();
            // �X�e�[�W��1�ȏ゠��ꍇ�ɂ̂݃V���b�t��
            if (stageList.Count > 0)
            {
                ShuffleStageList();
            }
            else
            {
                Debug.LogWarning("Lv.8 �ȏ�̃X�e�[�W������܂���I");
            }
        }

        public Stage_List.Stages GetUniqueRandomStage()
        {
            if (currentIndex >= stageList.Count)
            {
                Debug.LogWarning("���ׂẴX�e�[�W����x���I�΂�܂����I");
                return default(Stage_List.Stages); // ����l��Ԃ�
            }

            return stageList[currentIndex++];
        }

        // ���X�g���V���b�t�����郁�\�b�h
        void ShuffleStageList()
        {
            for (int i = 0; i < stageList.Count; i++)
            {
                int randomIndex = Random.Range(i, stageList.Count);
                (stageList[i], stageList[randomIndex]) = (stageList[randomIndex], stageList[i]); // Swap
            }
        }

        // ���̃X�e�[�W���X�g�擾���\�b�h (���ۂɂ�Stages.cs�̃��\�b�h���g�p)
        private List<Stage_List.Stages> GetStageListFromStagesClass()
        {
            // �����Ŏ��ۂ̃X�e�[�W�f�[�^���擾����
            List<Stage_List.Stages> allStages = new List<Stage_List.Stages>();

            // ���̃X�e�[�W�f�[�^��ǉ� (�e�X�g�p)
            for (int i = 8; i <= 20; i++)
            {
                Stage_List.Stages stage = new Stage_List.Stages(i); // �C���X�^���X���쐬
                allStages.Add(stage); // ���X�g�ɒǉ�        

            }

            return allStages; //���ۂɂ�Stage_List�̃f�[�^��Ԃ�

        }

    }

}
