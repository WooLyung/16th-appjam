using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Appjam.PuzzleScene
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; set; }

        public GameObject[] PieceObjects;
        public GameObject[] PieceDestinations;

        public int Index { get; set; }
        public bool IsSucceed { get; set; }

        private void OnDestroy()
        {
            Instance = null;
        }

        private void Awake()
        {
            Instance = this;
            Index = 0;
            IsSucceed = true;
        }

        private void Start()
        {
            InstantiatePieces();
        }

        public void InstantiatePieces()
        {
            Instantiate(PieceObjects[Index], new Vector3(6, 0, 0), Quaternion.identity);
        }

        public void GameEnd()
        {
            if (IsSucceed)
            {
                Debug.Log("Succeed");
                DataManager.count++;
            }
            else
            {
                Debug.Log("Not Succeed");
            }

            SceneManager.LoadScene("Stage");
        }
    }
}