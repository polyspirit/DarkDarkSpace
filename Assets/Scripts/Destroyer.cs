using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private DestroyerType _type;

    // props
    public DestroyerType type { get => _type; }
}

public enum DestroyerType
{
    Top,
    Bottom
}