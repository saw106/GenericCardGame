using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class AbstractCard : MonoBehaviour {
    public abstract int getDamage();
    public abstract int getHealth();
    public abstract void attack(AbstractCard otherCard);
    public abstract void takeDamage(int amount);
    public abstract void onDraw();
    public abstract void onPlay();
    public abstract void onDeath();
    public abstract void onDamage(AbstractCard otherCard, int amount);
    public abstract void onAttack(AbstractCard otherCard);
    public abstract void addEffect(ActionType type, CardEffectAction action);
}
