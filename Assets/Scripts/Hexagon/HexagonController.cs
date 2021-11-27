using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Hexagon
{
    public class HexagonController : MonoBehaviour 
    {
        [SerializeField] private HexagonData _hexagonData;
        [SerializeField] private GameObject _hexagonOutImage;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        private List<HexagonController> selectedHexagon;
        
        private List<GameObject> _neighbours;

        private List<Vector2> _neigboursCoordinate;

        public int[] coordinate=new int[2];
        
        private void Start()
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
          
        public void SetColor()
        {
            var rnd = Random.Range(0, _hexagonData.colors.Count);
            _spriteRenderer.color = _hexagonData.colors[rnd];
        }

        public void ActiveOutImage(bool _bool)
        {
            _hexagonOutImage.SetActive(_bool);
        }

        //Seçildiğinde komşuları seçme fonksiyonu
        public void HexagonNeighbours()
        {
            var counter = 0;
            
            selectedHexagon = new List<HexagonController>();
            selectedHexagon.Add(GetComponent<HexagonController>());
            
            for (int i = 0; i < 6; i++)
            {
                RaycastHit2D[] hit2D = Physics2D.RaycastAll(transform.position, _neigboursCoordinate[i], 20);
                if (hit2D.Length<2)
                {
                    Debug.Log("null");
                }
                else
                {
                    var hexagonController = hit2D[1].collider.gameObject.GetComponent<HexagonController>();
                    selectedHexagon.Add(hexagonController);
                    counter++;
                }

                if (counter==2)
                    break;
            }
            SelectedHexagonsSetActive(true);
            //Yapılacaklar          1- OutImage kaldırılacak    2-Seçilen obje döngüden çıkarılacak      3-hexagonların arası açılacak
        }
        
        public void SelectedHexagonsSetActive(bool _bool)
        {
            foreach (var hexagonController in selectedHexagon)
            {
                hexagonController.ActiveOutImage(_bool);
            }
        }

        public void Score()
        {
            
        }
    }
}
