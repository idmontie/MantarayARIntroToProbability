using System;
using UnityEngine;


public class LessonVariability : MonoBehaviour 
{
	Slides slides = null;
	
	
	void Start ()
	{
		Assets assets = Assets.GetInstance();
		Slides slides = new Slides("LessonVariability");
		
		
		slides.Add (new Slide (
			"Variability"
		));

		// TODO Variability
		
		this.slides = slides;
	}
	
	void OnGUI () 
	{
		slides.OnGUI(gameObject);
	}
	
	void Update () 
	{
		slides.Update(gameObject);
	}
}
