using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private Transform _checklistParent;
    [SerializeField] private ChecklistItemUI _checklistItemPrefab;

    [SerializeField] private TMP_Text _commonText;
    [SerializeField] private TMP_Text _uncommonText;
    [SerializeField] private TMP_Text _rareText;
    [SerializeField] private TMP_Text _timerText;

    private List<ChecklistItemUI> _checklistItems;

    public void SetRequiredItems(List<GameObject> items)
    {
        _checklistItems = new List<ChecklistItemUI>();

        foreach (GameObject item in items)
        {
            ChecklistItemUI checklistItem =
                Instantiate(_checklistItemPrefab, _checklistParent);

            checklistItem.SetItem(item);
            _checklistItems.Add(checklistItem);
        }
    }

    public void KickedItem(GameObject item)
    {
        foreach (ChecklistItemUI checklistItem in _checklistItems)
        {
            if (checklistItem.RequiredItem == item)
            {
                checklistItem.FoundItem();
            }
        }
    }

    public void UpdatePointsText(
        int commonPoints,
        int uncommonPoints,
        int rarePoints)
    {
        if (_commonText != null)
        {
            _commonText.text = "common:" + commonPoints;
        }

        if (_uncommonText != null)
        {
            _uncommonText.text = "uncommon:" + uncommonPoints;
        }

        if (_rareText != null)
        {
            _rareText.text = "rare:" + rarePoints;
        }
    }

    public void UpdateTimerText(float timeLeft)
    {
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }

        if (_timerText != null)
        {
            _timerText.text = timeLeft.ToString("0.00");
        }
    }
}