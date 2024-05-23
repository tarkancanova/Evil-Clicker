using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopmostUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _ownedMoney;
    [SerializeField] private PlayerData _playerData;

    private void Update()
    {
        _ownedMoney.text = "Money: " + _playerData.money;
    }
}
