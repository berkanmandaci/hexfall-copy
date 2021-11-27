using UnityEngine;

namespace Grid
{
    [CreateAssetMenu(menuName="Grid/Grid Data")]
    public class GridData : ScriptableObject
    {
        [Header("Distance")]
        public float colDis;
        public float rowDis;
        public float colDownDis;
        [Header("Counts")]
        public int rowCount;
        public int colCount;
    }
}

