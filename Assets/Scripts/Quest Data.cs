using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest Data")]
public class QuestData : ScriptableObject
{
    public string questName;
    public int questIncome;
    public float questDuration;
}
