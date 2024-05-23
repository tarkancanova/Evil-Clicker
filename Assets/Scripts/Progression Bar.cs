using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ProgressionBar : MonoBehaviour
{
    private Image _image;
    [SerializeField] private QuestManager _questManager;
    private QuestData[] _questDataList;
    [SerializeField] private int _barIndex;


    private void Start()
    {
        _image = GetComponent<Image>();
        _questDataList = _questManager.GetComponent<QuestManager>().questDataList;
    }

    private void Update()
    {
        if (_image.fillAmount == 1f)
        {
            ResetBar();
        }
    }

    public void FillTheBar()
    {
        _image.DOFillAmount(1f, _questDataList[_barIndex].questDuration);
    }

    private void ResetBar()
    {
        _image.fillAmount = 0;
    }
    //private float _currentProgression;
    //private float _maxProgression = 100;
    //private float _progressAmountPerChange = 5;
    //[SerializeField] private float _fillSpeed;
    //[SerializeField] private GameObject _continueButton;

    //private void Awake()
    //{
    //    _image = GetComponent<Image>();
    //    _currentProgression = 0;
    //}

    //public void UpdateProgression()
    //{
    //    _currentProgression += _progressAmountPerChange;
    //    FillTheBar();
    //}

    //public void FillTheBar()
    //{

    //    float targetFillAmount = _currentProgression / _maxProgression;
    //    _image.DOFillAmount(targetFillAmount, _fillSpeed);
    //}

}
