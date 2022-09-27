using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePieceToPlace : MonoBehaviour
{

    //public PawnMovement Pawn;
    public BoardControll Board;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Board.Move(this.transform.position);
    }
}
