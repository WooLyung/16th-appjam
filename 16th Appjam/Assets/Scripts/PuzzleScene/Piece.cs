using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Appjam.PuzzleScene
{
    public class Piece : MonoBehaviour
    {
        public bool isCorrect;

        public Vector3 OriginPosition { get; set; }

        private SpriteRenderer sr;

        private void Awake()
        {
            sr = GetComponent<SpriteRenderer>();
            OriginPosition = transform.position;
        }

        private void OnMouseDown()
        {
            sr.sortingOrder = 2;
            StartCoroutine("MouseDownCoroutine");
            GetComponent<BoxCollider2D>().enabled = false;

            for(int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i) != transform)
                    Destroy(transform.parent.GetChild(i).gameObject);
            }

            if (isCorrect == false)
                GameManager.Instance.IsSucceed = false;
        }

        IEnumerator MouseDownCoroutine()
        {
            while(Vector3.Distance(transform.position, GameManager.Instance.PieceDestinations[GameManager.Instance.Index].transform.position) > 0.01f)
            {
                transform.position = Vector3.Lerp(transform.position, GameManager.Instance.PieceDestinations[GameManager.Instance.Index].transform.position, 0.1f);
                yield return null;
            }

            sr.sortingOrder = 0;
            GameManager.Instance.Index++;

            if (GameManager.Instance.Index < GameManager.Instance.PieceObjects.Length)
                GameManager.Instance.InstantiatePieces();
            else
                GameManager.Instance.GameEnd();
        }
    }
}
