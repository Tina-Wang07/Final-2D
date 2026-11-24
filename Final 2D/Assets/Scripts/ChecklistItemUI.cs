using UnityEngine;
using UnityEngine.UI;

public class ChecklistItemUI : MonoBehaviour
{
    [SerializeField] private Image _itemImage;
    [SerializeField] private Image _checkImage;
    [SerializeField] private Sprite _filledCheckSprite;

    public GameObject RequiredItem { get; private set; }

    public void SetItem(GameObject itemObject)
    {
        RequiredItem = itemObject;

        _itemImage.sprite =
            itemObject.GetComponent<SpriteRenderer>().sprite;

        _checkImage.gameObject.SetActive(false);
    }

    public void FoundItem()
    {
        _checkImage.sprite = _filledCheckSprite;
        _checkImage.gameObject.SetActive(true);
    }
}