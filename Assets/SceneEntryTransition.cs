using System;
using UnityEngine;

public class SceneEntryTransition : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    [SerializeField] float duration = 2f;

    bool isMoving;

    void Start()
    {
        Move();
    }

    public void Move()
    {
        MoveThen(null);
    }

    public void MoveThen(Action onComplete)
    {
        if (targetTransform == null)
        {
            Debug.LogError("Target Transform belum diatur.", this);
            return;
        }

        if (isMoving)
        {
            return;
        }

        isMoving = true;

        LTDescr tween;
        RectTransform rectTransform = GetComponent<RectTransform>();

        if (rectTransform != null)
        {
            tween = LeanTween.moveX(rectTransform, targetTransform.position.x, duration);
        }
        else
        {
            tween = LeanTween.moveX(gameObject, targetTransform.position.x, duration);
        }

        tween.setOnComplete(() =>
        {
            isMoving = false;
            onComplete?.Invoke();
        });
    }
}
