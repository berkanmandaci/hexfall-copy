using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonManager : MonoBehaviour
{
    private List<Vector2> _neigboursCoordinate;
    // Start is called before the first frame update
    void Start()
    {
        SetList();
    }

    private void SetList()
    {
        _neigboursCoordinate = new List<Vector2>
        {
            new Vector2(1, 1),
            new Vector2(1, -1),
            new Vector2(0, -1),
            new Vector2(-1, -1),
            new Vector2(-1, 0),
            new Vector2(-1, 1)
        };
    }
}
