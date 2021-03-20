using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CustomEditor(typeof(CardSetup))]
public class CardSetupEditor : Editor
{
    public CardSetup _target = null;
    public ECardType _targetLastType = ECardType.hero;



    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (_target == null)
        {
            _target = target as CardSetup;
            _targetLastType = _target.cardType;
        }

        if (_target.cardType != _targetLastType)
        {
            _targetLastType = _target.cardType;

            if (_target.cardType == ECardType.hero)
            {
                _target.card = new Hero();
                _target.cardObject = new HeroObject();

                EditorUtility.SetDirty(target);
            }
            else if (_target.cardType == ECardType.boss)
            {
                _target.card = new Boss();
                _target.cardObject = new BossObject();

                EditorUtility.SetDirty(target);
            }
            else if (_target.cardType == ECardType.spell)
            {
                _target.card = new Spell();
                _target.cardObject = new SpellObject();

                EditorUtility.SetDirty(target);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        else
        {
            if(_target.cardType == ECardType.hero)
            {
                if(_target.card as Hero == null || _target.cardObject as HeroObject == null)
                {
                    _target.card = new Hero();
                    _target.cardObject = new HeroObject();

                    EditorUtility.SetDirty(target);
                }
            }
            else if(_target.cardType == ECardType.boss)
            {
                if (_target.card as Boss == null || _target.cardObject as BossObject == null)
                {
                    _target.card = new Boss();
                    _target.cardObject = new BossObject();

                    EditorUtility.SetDirty(target);
                }
            }
            else if(_target.cardType == ECardType.spell)
            {
                if (_target.card as Spell == null || _target.cardObject as SpellObject == null)
                {
                    _target.card = new Spell();
                    _target.cardObject = new SpellObject();

                    EditorUtility.SetDirty(target);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
