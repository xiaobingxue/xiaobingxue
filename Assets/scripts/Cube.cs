using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public bool isSelected = false; // �Ƿ�ѡ��

    private void OnMouseDown()
    {
        isSelected = !isSelected;
    }
}
