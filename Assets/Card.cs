using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card<T> : AbstractCard {

    public static int baseHealth;
    public static int baseAttack;
    public int currentAttack;
    public int currentHealth;
    public int maxHealth;
    public List<CardEffectAction> deathActions;
    public List<CardEffectAction> playActions;
    public List<CardEffectAction> drawActions;
    public List<CardEffectAction> attackActions;
    public List<CardEffectAction> damageActions;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override int getDamage()
    {
        return this.currentAttack;
    }

    public override int getHealth()
    {
        return this.currentHealth;
    }

    public override void onAttack(AbstractCard otherCard)
    {
        foreach (CardEffectAction action in attackActions)
        {
            action.apply();
        }
    }

    public override void onDeath()
    {
        foreach (CardEffectAction action in deathActions)
        {
            action.apply();
        }
    }

    public override void onDraw()
    {
        foreach (CardEffectAction action in drawActions)
        {
            action.apply();
        }
    }

    public override void onPlay()
    {
        foreach (CardEffectAction action in playActions)
        {
            action.apply();
        }
    }

    public override void onDamage(AbstractCard otherCard, int amount)
    {
        foreach (CardEffectAction action in damageActions)
        {
            action.apply();
        }
    }

    public override void addEffect(ActionType type, CardEffectAction action)
    {
        switch (type)
        {
            case ActionType.Attack:
                attackActions.Add(action);
                return;
        }
    }

    public override void attack(AbstractCard otherCard)
    {
        this.onAttack(otherCard);
        this.onDamage(otherCard, this.getDamage());
        otherCard.takeDamage(this.getDamage());
        this.takeDamage(otherCard.getDamage());
    }

    public override void takeDamage(int amount)
    {
        this.currentHealth -= amount;
    }
}
