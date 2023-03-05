using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClickable
{
    void Click();
}

public interface IDamageable<T>
{
    int Health { get; set; }

    void Damage(T damageTaken);
}

public interface IKillable
{
    void Kill();
}
