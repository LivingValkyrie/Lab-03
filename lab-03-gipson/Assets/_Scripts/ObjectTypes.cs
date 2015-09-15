using UnityEngine;
using System.Collections;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: ObjectTypes 
/// </summary>
[System.Serializable]
public class ObjectTypes : MonoBehaviour {
    #region Fields

    public ObjectType type;
    public float breakablePoints;
    public bool solidMoving;
    public Vector3 solidStart;
    public Vector3 solidEnd;
    public DamageTypes damageType;
    public float damageAmount;
    public HealingTypes healingType;
    public HealingPickups healingPickupType;
    public float healingAmount;

    #endregion

    void Start() {}

    void Update() {}

}

public enum ObjectType {
    BREAKABLE,
    SOLID,
    DAMAGING,
    HEALING,
    PASSABLE
}

public enum DamageTypes {
    FIRE,
    PHYSICAL
}

public enum HealingTypes {
    HEALTH,
    SHIELD
}

public enum HealingPickups {
    CONTACT,
    INTERACTION
}