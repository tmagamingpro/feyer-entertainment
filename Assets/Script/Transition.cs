using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    [SerializeField] float duration;

    bool isMoving;

    public void Move()
    {
        MoveThen(null);
    }

    public void MoveThenLoadScene(int sceneBuildIndex)
    {
        MoveThen(() => SceneManager.LoadSceneAsync(sceneBuildIndex));
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
        LeanTween.moveX(gameObject, targetTransform.position.x, duration)
            .setOnComplete(() =>
            {
                isMoving = false;
                onComplete?.Invoke();
            });
        }
}
