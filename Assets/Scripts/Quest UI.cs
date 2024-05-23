using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    [SerializeField] private GameObject _questContainer;
    [SerializeField] private GameObject _questManager;

    private void Start()
    {
        AssignQuestsToUI();
    }

    private void AssignQuestsToUI()
    {
        QuestData[] questDataList = _questManager.GetComponent<QuestManager>().questDataList;
        Transform parentTransform = _questContainer.transform;
        int childCount = parentTransform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = parentTransform.GetChild(i);
            child.GetChild(0).GetComponent<TMP_Text>().text = questDataList[i].questName + "\n" + "Income: " + questDataList[i].questIncome + " " +
                "Duration: " + questDataList[i].questDuration;
        }
    }
}
