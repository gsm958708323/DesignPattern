using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IWeapon
{
    protected int m_Atk;
    protected float m_AtkRange;
    protected int m_AtkPlusValue;

    protected GameObject m_GameObject;
    protected ICharacter m_Owner;
    protected ParticleSystem m_Particle;
    protected Light m_Light;
    protected LineRenderer m_Line;
    protected AudioSource m_Audio;

    protected float m_EffectDisplayTime;

    public void Fire(Vector3 targetPos)
    {
        /*
         * Design:模板方法
         * 1.显示枪口特效
         * 2.显示子弹轨迹特效
         * 3.设置特效显示时间
         * 4.播放声音
         */
        PlayMuzzleEffect();
        PlayBulletEffect(targetPos);
        SetEffectDisplayTime();
        PlaySound();
    }

    protected virtual void SetEffectDisplayTime()
    {
        DoSetEffectDisplayTime(5);
    }
    protected void DoSetEffectDisplayTime(float time)
    {
        m_EffectDisplayTime = time;
    }
    private void PlaySound()
    {
        m_Audio.clip = null;
        m_Audio.Play();
    }
    protected virtual void PlayBulletEffect(Vector3 targetPos)
    {
        DoPlayBulletEffect(targetPos, 0.5f);
    }
    protected void DoPlayBulletEffect(Vector3 targetPos, float width)
    {
        m_Line.enabled = true;
        m_Line.startWidth = width;
        m_Line.endWidth = width;
        //两点确定一条直线
        m_Line.SetPosition(0, m_GameObject.transform.position);
        m_Line.SetPosition(1, targetPos);
    }
    private void PlayMuzzleEffect()
    {
        m_Particle.Stop();
        m_Particle.Play();
        m_Light.enabled = true;
    }
}
