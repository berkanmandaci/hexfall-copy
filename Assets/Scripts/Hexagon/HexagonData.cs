using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Hexagon
{
    [CreateAssetMenu(menuName = "Hexagon/Hexagon Data")]
    public class HexagonData : ScriptableObject
    {
        public List<Color> colors;
    }
}
