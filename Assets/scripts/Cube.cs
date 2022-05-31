using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public bool isSelected = false; // 是否被选中

    private void OnMouseDown()
    {
        isSelected = !isSelected;
    }
}
