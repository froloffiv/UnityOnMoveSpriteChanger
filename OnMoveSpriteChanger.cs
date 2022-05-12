using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class OnMoveSpriteChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _prePosition;
    [SerializeField] private Sprite _upSprite;
    [SerializeField] private Sprite _upRightSprite;
    [SerializeField] private Sprite _upLeftSprite;
    [SerializeField] private Sprite _downSprite;
    [SerializeField] private Sprite _downRightSprite;
    [SerializeField] private Sprite _downLeftSprite;
    [SerializeField] private Sprite _rightSprite;
    [SerializeField] private Sprite _leftSprite;
    private void Awake()
    {
        _prePosition = gameObject.transform.position;
    }
    private void Change()
    {
        if (_prePosition != gameObject.transform.position)
        {
            float x = gameObject.transform.position.x - _prePosition.x;
            float y = gameObject.transform.position.y - _prePosition.y;

            if (x == 0 && y > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _upSprite;
            }
            if (x == 0 && y < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _downSprite;
            }
            if (x > 0 && y == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _rightSprite;
            }
            if (x < 0 && y == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _leftSprite;
            }
            if (x > 0 && y > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _upRightSprite;
            }
            if (x < 0 && y > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _upLeftSprite;
            }
            if (x > 0 && y < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _downRightSprite;
            }
            if (x < 0 && y < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = _downLeftSprite;
            }
            _prePosition = gameObject.transform.position;
        }
    }
    private void FixedUpdate()
    {
        Change();
    }
}
