using System;
using UnityEngine;


public class Lesson5 : MonoBehaviour 
{
	Slides slides = null;
	
	void Start ()
	{
		slides = new Slides("Lesson5");
		
		slides.Add(new Slide(
			"Fractions, Decimals, and Percentages\n\nSo far, we have expressed probability in the form of a percentage.\n" +
			"\n"+
			"However, probabilities can be expressed in the form of ratios and fractions."
			));
		slides.Add(new Slide(
			"In the following lesson, we will investigate different ways we can express probabilities and how to convert between them."
			));
		
		slides.Add (new Slide(
			"We'll first talk about ratios.  A ratio is a comparison often expressed in the form 1:2 or 3:4 (read as 1 to 2, or 3 to 4) and are often referred to as \"the odds of an event occurring.\""
			));
		
		slides.Add(new Slide(
			"Let's look at an example.  If we have 3 sick fish out of 10 fish, we would say that 30% of the fish are sick.  With ratios however, you compare the sick fish to the not sick fish.  So the ratio of sick fish to healthy fish is 3:7 (read as 3 to 7).  In other words, the odds that a fish is sick is 3 to 7."
			));
		
		slides.Add(new Slide(
			"While confusing at first, ratios are often prefered in everyday life.  A cake recipe may call for \"3 parts flour to 1 part milk\", or in other words, 75% flour to 25% milk."
			));
		
		slides.Add(new Slide(
			"It is much easier to multiply amounts using ratios than percentages. If you wanted to make two batches of the cake recipe you could simply multiply the ratio by two: 6 parts flour to 2 parts milk."
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
