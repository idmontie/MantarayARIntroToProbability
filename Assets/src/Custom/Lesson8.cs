using System;
using UnityEngine;
public class Lesson8 : MonoBehaviour
{
	public Lesson8 ()
	{
	}

	protected Slides slides = null;

	// Use this for initialization
	void Start () 
	{
		slides = new Slides("Lesson8");
		
		slides.Add(new Slide(
			"Review\n\nIn the previous lessons, we have learned that probability is the chance of an event occuring."
			));
		
		slides.Add(new Slide(
			"By tallying fish, we can determine what percentage of fish have been affected by polution.\n\nBy using that percentage, we can make a guess at the probability that a fish is affected by pollution."
			));

		slides.Add(new Slide(
			"Probabilities can be expressed in different ways, such as fractions, ratios, and percentages.\n\nThe following are all the same representations of a probability:\n" +
			"\t\u2022 1/3\n" +
			"\t\u2022 1:2\n" +
			"\t\u2022 33.3%\n"
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


