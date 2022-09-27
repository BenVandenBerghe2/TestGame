using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardControll : MonoBehaviour
{
    public GameObject SelectedPiece;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 NewPosition)
    {
        SelectedPiece.transform.position = NewPosition;
    }
}
