using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    Box [] board;
    public void SetOnSquare(Box box){
        board[box.GetNum()] = box;
    }
}
