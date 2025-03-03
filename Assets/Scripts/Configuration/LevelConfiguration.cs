using System.Collections.Generic;
using UnityEngine;
namespace RTS
{
    [CreateAssetMenu(menuName = "RTS/New Configuration")]
    public class LevelConfiguration : ScriptableObject
    {
        public List<LevelItem> LevelItems = new List<LevelItem>();
        public LevelItem FindByType(LevelItemType type)
        {
            return LevelItems.Find(item => item.Type == type);
        }
    }
}