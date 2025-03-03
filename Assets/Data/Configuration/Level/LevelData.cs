using System.Collections.Generic;
using UnityEngine;
namespace RTS
{
    [CreateAssetMenu(menuName = "RTS/New Level")]
    public class LevelData : ScriptableObject
    {
        public List<LevelSlot> Slots = new List<LevelSlot>();
        public int Columns;
        public int Rows;
        public LevelConfiguration Configuration;
    }
}