using System;
using System.Collections;
using System.Collections.Generic;
using Hexagon;
using Unity.Mathematics;
using UnityEngine;

namespace Grid
{
   public class GridManager : MonoBehaviour
   {
      [SerializeField] private GameObject hexagon;
      [SerializeField] private GridData _gridData;
      
      private void Start()
      {
         GridObject();
      }

      private void GridObject()
      {
         Vector2 hexVec = new Vector2(0, 0);
         for (int i = 0; i < _gridData.rowCount; i++)
         {
            for (int j = 0; j < _gridData.colCount; j++)
            {
               CreateHexagon(hexVec, i, j);
               hexVec.y += _gridData.colDis;
            }
            
            hexVec.y = i % 2 == 0 ? _gridData.colDownDis : 0;
            
            hexVec.x += _gridData.rowDis;
         }
      }

      private void CreateHexagon(Vector2 hexPos,int x,int y)
      {
         var _hexagon= Instantiate(hexagon, hexPos, quaternion.identity, transform);
         var hexagonController= _hexagon.GetComponent<HexagonController>();
         hexagonController.SetColor();
         hexagonController.coordinate[0] = x;
         hexagonController.coordinate[1] = y;
      }
   }
}
