using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Cube[] cubes = default;

    private void Update()
    { 

        int beSelectedCubeCount = 0;
        for (int i = 0; i < cubes.Length; i++)
        { 
            if (cubes[i] != null && cubes[i].isSelected)
            {
                beSelectedCubeCount++;
            }
        }

        if (beSelectedCubeCount == 2)
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                if (cubes[i] != null && cubes[i].isSelected)
                {
                    Destroy(cubes[i].gameObject);
                    cubes[i] = null;
                }
        }
        }
        
    }
}
