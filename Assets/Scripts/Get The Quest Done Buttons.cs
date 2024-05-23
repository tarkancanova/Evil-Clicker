using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTheQuestDoneButtons : MonoBehaviour
{
    [SerializeField] private QuestManager _questManager;
    public int buttonIndex;
    public int questIndex;
    private QuestData[] _questDataList;
    [SerializeField] private PlayerData _playerData;

    private void Start()
    {
        buttonIndex = questIndex;
        _questDataList = _questManager.GetComponent<QuestManager>().questDataList;

        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnClickButton);
        }
    }

    private void OnClickButton()
    {
        StartCoroutine(GetQuestDone());
        transform.parent.GetChild(2).GetComponent<ProgressionBar>().FillTheBar();
    }

    private IEnumerator GetQuestDone()
    {
        yield return new WaitForSeconds(_questDataList[questIndex].questDuration);
        _playerData.money += _questDataList[questIndex].questIncome;
    }

}

