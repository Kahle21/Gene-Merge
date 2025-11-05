using UnityEngine;

public class TraitDebug : MonoBehaviour
{
    void Start()
    {
        // Loads all TraitSO placed under Assets/Resources/Traits
        var traits = Resources.LoadAll<TraitSO>("Traits");
        Debug.Log($"[TraitDebug] Loaded {traits.Length} traits");
        foreach (var t in traits)
            Debug.Log($" - {t.displayName} ({t.slot}, {t.rarity}) tags:[{string.Join(",", t.tags ?? new string[0])}]");
    }
}

