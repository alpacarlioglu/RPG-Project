using System;
using System.Collections;
using RPG.Core;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        private CanvasGroup canvasGroup;
        
        private void Start()
        {
             canvasGroup = GetComponent<CanvasGroup>();
             if (!PersistentObjectSpawner.hasSpawned)
             {
                 StartCoroutine(FadeOutIn());
             }
        }

        public IEnumerator FadeOutIn()
        {
            yield return FadeOut(3f);
            yield return FadeIn(1f);
            IsFadeFinished(true);
        }
        
        public IEnumerator FadeOut(float time)
        {
            while (canvasGroup.alpha < 1) // alpha is not 1
            {
                // moving alpha toward 1
                canvasGroup.alpha += Time.deltaTime / time;
                print (canvasGroup.alpha);
                yield return null; 
            }
        }

        public IEnumerator FadeIn(float time)
        {
            while (canvasGroup.alpha > 0) 
            {
                canvasGroup.alpha -= Time.deltaTime / time;
                yield return null; 
            }
        }

        public bool IsFadeFinished(bool isFinished = false)
        {
            return isFinished;
        }
        
    }
}