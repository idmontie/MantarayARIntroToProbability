using System;
using UnityEngine;


public class Lesson1 : MonoBehaviour 
{
	protected Slides slides = null;
	
	// Use this for initialization
	void Start () 
	{
		slides = new Slides("Lesson1");
		
		slides.Add(new Slide(
			"Introduction to Basic Statistics"
		));
		
		slides.Add(new Slide(
			"Whenever you ask yourself \"What is the chance that I will roll a two on a six-sided dice\" or similar questions you are dealing with probability."
			));
		
		slides.Add(new Slide(
			"In these lessons, we will explore what probability is, how to express it, and identifying some probabilties through an augmented reality investigation."
			));
		
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

