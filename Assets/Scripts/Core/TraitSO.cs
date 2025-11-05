using UnityEngine;

public enum TraitSlot { Head, Body, Tail, Wings, Element, Passive, Active }
public enum Rarity { C, B, A, S, SS }

[CreateAssetMenu(menuName = "Genes/Trait")]
public class TraitSO : ScriptableObject
{
    [Header("Identity")]
    public string id;
    public string displayName;

    [Header("Classification")]
    public TraitSlot slot;
    public Rarity rarity;
    public string element;   // e.g., "Fire","Ice","Bio","None"

    [Header("Presentation")]
    public Sprite icon;
    public GameObject prefab;
    [TextArea] public string lore;

    [Header("Stats")]
    public int hpFlat;
    public int atkFlat;
    public int defFlat;
    public float speedMul = 1f;

    [Header("Tags")]
    public string[] tags;
}

