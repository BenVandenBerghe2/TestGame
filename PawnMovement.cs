using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnMovement : MonoBehaviour
{
    [SerializeField]
    private MovePieceToPlace MoveOption;
    [SerializeField]
    private BoardControll _boardControll;


    private Vector3 Position;
    private bool Longmove = true;
    private bool Selected = false;
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per framemy
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!Selected)
        {
            _boardControll.SelectedPiece = this.gameObject;
            MovePieceToPlace go = Instantiate(MoveOption, transform.position + new Vector3(0, 0.4f, 2.5f), Quaternion.identity);
            go.Board = _boardControll;
            if (Longmove)
            {
                MovePieceToPlace go2 = Instantiate(MoveOption, transform.position + new Vector3(0, 0.4f, 5f), Quaternion.identity);
                go.Board = _boardControll;
            }

            Selected = true;
        }
    } 
}
