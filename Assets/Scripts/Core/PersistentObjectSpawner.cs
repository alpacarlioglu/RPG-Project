using System;
using UnityEngine;

namespace RPG.Core
{
    public class PersistentObjectSpawner : MonoBehaviour
    {
        [SerializeField] GameObject persistentObjectPrefab;

        public static bool hasSpawned = false;
        private void Awake()
        {
            if (hasSpawned) return;
            
            SpawnPersistentObjects();
            
            hasSpawned = true;
        }

        private void SpawnPersistentObjects()
        {
            GameObject persistentObject = Instantiate(persistentObjectPrefab, transform.position, Quaternion.identity);
            DontDestroyOnLoad(persistentObject);
        }
    }
}