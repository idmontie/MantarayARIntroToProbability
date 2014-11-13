using System;
using UnityEngine;


public class Lesson2 : MonoBehaviour 
{
	Slides slides = null;

	
	void Start ()
	{
		Assets assets = Assets.GetInstance();
		Slides slides = new Slides("Lesson2");
	
		
		slides.Add(new Slide(
			"Objective\n\nIn the following lessons, we will learn what probability is, how to use it, and some of the related vocabulary associated with it."
			));
		
		slides.Add(new Slide(
			"In order to get the most out of these Augmented Reality lessons, you should have a firm understanding of:\n\n" +
			"\t\u2022 Basic Arithmetic: Division, Multiplication, Addition, and Subtraction\n" +
			"\t\u2022 Fractions"
			));
		
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
