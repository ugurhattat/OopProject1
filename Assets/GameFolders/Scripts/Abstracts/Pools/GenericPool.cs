using OopProject1.Combats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OopProject1.Abstracts.Pools
{
    public abstract class GenericPool<T> : MonoBehaviour where T : Component
    {
        [SerializeField] T[] prefabs;
        [SerializeField] int countLoop = 5;

        Queue<T> _poolPrefabs = new Queue<T>();

        private void Awake()
        {
            SingletonObject();
        }

        private void OnEnable()
        {
            if (GameManager.Instance != null)

            GameManager.Instance.OnSceneChanged += ResetAllObjects;
        }

        private void OnDisable()
        {
            if (GameManager.Instance != null)

            GameManager.Instance.OnSceneChanged -= ResetAllObjects;
        }

        private void Start()
        {
            GrowPoolPrefab();
        }

        protected abstract void SingletonObject();

        public T Get() //eger havuzda yeterli obje yoksa yeni obje olustur varsa bana havuzdan bir obje ver
        {
            if (_poolPrefabs.Count == 0)
            {
                GrowPoolPrefab();
            }

            return _poolPrefabs.Dequeue();
        }

        public abstract void ResetAllObjects();

        private void GrowPoolPrefab() //bana countLoop kadar obje olustur,parentlarini set et,set active(true)yi kapat ve pool a ekle kullanmak uzere
        {
            if (prefabs == null || prefabs.Length == 0)
            {
                Debug.LogError($"[{name}] Pool 'prefabs' dizisi bos! Inspector'da en az 1 prefab ekle.");

                return;
            }
            for (int i = 0; i < countLoop; i++)
            {
                T newPrefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);
            }
        }

        public void Set(T poolObject) //destroylamak yerine objenin activeSet ini kapatir ve pool a dahil eder yeniden
        {
            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);
        }
    }
}


