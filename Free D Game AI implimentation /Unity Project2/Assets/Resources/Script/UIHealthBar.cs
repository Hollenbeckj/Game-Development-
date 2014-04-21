﻿using UnityEngine;
using System.Collections;

/* <summary>
 * Health Bar used for 
 * Player
 * </summary>
 */
public class UIHealthBar : MonoBehaviour 
{
	[SerializeField] private Vector2	mStartPostion;
	[SerializeField] private Vector2	mWidthAndHeight;
	[SerializeField] private float		mMaxHealth;

	public float		mCurrentHealth;
	private float		mPercentage;
	private Rect		mRect;
	private Texture2D	mColorTex;

	public Texture2D firstDamageStage;
	public Texture2D secondDamageStage;
	public Texture2D thirdDamageStage;

	#region Unity Function
	private void Awake()
	{
		mCurrentHealth	= mMaxHealth;
		mPercentage 	= mCurrentHealth/mMaxHealth;
		mColorTex 		= new Texture2D(1,1);
		SetColor();
		SetRect();
	}
	private void OnGUI()	{	GUI.DrawTexture( mRect , mColorTex );
	
		if(mCurrentHealth <70)
		{
			float xMin = (Screen.width);
			float yMin = (Screen.height);
			GUI.DrawTexture(new Rect(0,0,xMin,yMin), firstDamageStage);
		}

		if(mCurrentHealth <50)
		{
			float xMin = (Screen.width);
			float yMin = (Screen.height);
			GUI.DrawTexture(new Rect(0,0,xMin,yMin), secondDamageStage);
		}

		if(mCurrentHealth < 30)
		{
			float xMin = (Screen.width);
			float yMin = (Screen.height);
			GUI.DrawTexture(new Rect(0,0,xMin,yMin), thirdDamageStage);
		}
	}


	#endregion

	public void crackingScreen()
	{

	}

	#region Class Function
	public void SubtractHealth(float _value)
	{
		if(mCurrentHealth > 0)
		{
			mCurrentHealth -= _value;
			mPercentage = mCurrentHealth / mMaxHealth;
			if(mCurrentHealth <= 0)	
			{
				if(DestroyGameObject != null) DestroyGameObject();
			}
			SetColor();
			SetRect();
		}
	}
	public void AddHealth(float _value)
	{
		if(mCurrentHealth < mMaxHealth)
		{
			mCurrentHealth += _value;
			mPercentage = mCurrentHealth / mMaxHealth;
			if(mCurrentHealth > mMaxHealth)
				mCurrentHealth = mMaxHealth;
			SetColor();
			SetRect();
		}
	}
	private void SetRect()	{	mRect.Set( mStartPostion.x, mStartPostion.y, mWidthAndHeight.x, mWidthAndHeight.y * mPercentage );	}
	private void SetColor()
	{
		Debug.Log(mPercentage);
		mColorTex.SetPixel(1,1,new Color((1 - mPercentage),mPercentage,0));
		mColorTex.Apply();
	}
	#endregion

	#region Delegate
	public delegate void DestroyGameObjectDelegate();
	public event DestroyGameObjectDelegate DestroyGameObject;
	#endregion
}
